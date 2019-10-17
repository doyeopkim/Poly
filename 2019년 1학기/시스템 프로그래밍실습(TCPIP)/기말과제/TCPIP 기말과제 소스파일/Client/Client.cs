using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text.RegularExpressions;

namespace FastFoodDemo
{
    public partial class Client : Form
    {
        TcpClient clientSocket = new TcpClient();
        IPAddress thisAddress;

        MySecondCustmControl mc = new MySecondCustmControl();

        int price = 0; // 가격 저장할 전역 변수

        public Client()
        {
            InitializeComponent();

            new Thread(delegate ()
            {
                InitSocket();
            }).Start();

            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
        }

        private void InitSocket()
        {
            IPHostEntry he = Dns.GetHostEntry(Dns.GetHostName());

            // 처음으로 발견되는 ipv4 주소를 사용한다.
            foreach (IPAddress addr in he.AddressList)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    thisAddress = addr;
                    break;
                }
            }

            // 주소가 없다면..
            if (thisAddress == null)
                // 로컬호스트 주소를 사용한다.
                thisAddress = IPAddress.Loopback;
            try
            {
                clientSocket.Connect(thisAddress, 9999);
                MessageBox.Show("연결성공이다");
                
                ReceiveMenu();// 메뉴 받을 함수
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message, "Error");
                Application.Exit(); // 서버에 접속하지 못한다면 프로그램 종료
            }
        }

        private void ReceiveMenu() // 메뉴 받는 메소드
        {
            NetworkStream stream = null;

            try
            {
                byte[] buffer = new byte[1024];
                byte[] a_buffer = new byte[1024];
                string msg = string.Empty;
                int bytes = 0;

                int menu_amount = 0;
                
                stream = clientSocket.GetStream();
                bytes = stream.Read(buffer, 0, buffer.Length);
                msg = Encoding.Unicode.GetString(buffer, 0, bytes);
                string[] menu_info = msg.Split('$');
                string[] menu = new string [menu_info.Length];

                for (int i = 0; i < menu_info.Length; i++)
                {
                    menu[i] = menu_info[i];
                }

                for (int i = 0; i < (menu.Length-1); i++)
                {
                    string[] tokens = menu[i].Split('\x01'); // \x01기준으로 자름
                    string menutype = tokens[0];
                    string m_img = tokens[1];
                    string m_name = tokens[2];
                    string[] m_menuinfo = m_name.Split('\t');

                    if (menutype == "main")
                    {
                        DisplayMainMenu(m_img, m_menuinfo[0], m_menuinfo[1]);
                    }
                    else if (menutype == "side")
                    {
                        DisplaySideMenu(m_img, m_menuinfo[0], m_menuinfo[1]);
                    }
                    else if (menutype == "beve")
                    {
                        DisplayBeveMenu(m_img, m_menuinfo[0], m_menuinfo[1]);
                    }
                }
            }
            catch (SocketException se)
            {
                MessageBox.Show("메뉴 받기 실패", "소켓 오류");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) // 폼이 닫힐 때
        {
            NetworkStream stream = clientSocket.GetStream();
            String temp = "1번 테이블 접속 종료";
            byte[] sbuffer = Encoding.Unicode.GetBytes(temp + "$"); // listBox1의 아이템을 전송
            stream.Write(sbuffer, 0, sbuffer.Length);
            stream.Flush();

            if (clientSocket != null)
                clientSocket.Close();
        }

        // 주문하기 버튼 클릭

        public void DisplayMainMenu(string m_img, string name, string price) // 받은 메뉴를 리스트뷰에 추가할 메소드
        {
            this.Invoke(new MethodInvoker(delegate
            {
                int index = listView1.Items.Count;
                listView1.Items.Add(name);
                listView1.Items[index].Tag = price;
                imageList1.Images.Add(Bitmap.FromFile(m_img));
                imageList4.Images.Add(Bitmap.FromFile(m_img)); // picturebox 출력용
                listView1.Items[index].ImageIndex = index;      
            }));
        }

        public void DisplaySideMenu(string m_img, string name, string price) // 받은 메뉴를 리스트뷰에 추가할 메소드
        {
            this.Invoke(new MethodInvoker(delegate
            {
                int index = listView2.Items.Count;
                listView2.Items.Add(name);
                listView2.Items[index].Tag = price;
                imageList2.Images.Add(Bitmap.FromFile(m_img));
                imageList5.Images.Add(Bitmap.FromFile(m_img)); // picturebox 출력용
                listView2.Items[index].ImageIndex = index;
            }));
        }

        public void DisplayBeveMenu(string m_img, string name, string price) // 받은 메뉴를 리스트뷰에 추가할 메소드
        {
            this.Invoke(new MethodInvoker(delegate
            {
                int index = listView3.Items.Count;
                listView3.Items.Add(name);
                listView3.Items[index].Tag = price;
                imageList3.Images.Add(Bitmap.FromFile(m_img));
                imageList6.Images.Add(Bitmap.FromFile(m_img)); // picturebox 출력용
                listView3.Items[index].ImageIndex = index;
            }));
        }

        // ***************************************************통신 코드***************************************************

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            
            listView1.Show();
            listView2.Hide();
            listView3.Hide();

            if (this.listView2.SelectedIndices.Count > 0)
            {
                for (int i = 0; i < this.listView2.SelectedIndices.Count; i++)
                {
                    this.listView2.Items[this.listView2.SelectedIndices[i]].Selected = false;
                }
            }

            if (this.listView3.SelectedIndices.Count > 0)
            {
                for (int i = 0; i < this.listView3.SelectedIndices.Count; i++)
                {
                    this.listView3.Items[this.listView3.SelectedIndices[i]].Selected = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            listView2.Show();
            listView1.Hide();
            listView3.Hide();

            if (this.listView1.SelectedIndices.Count > 0)
            {
                for (int i = 0; i < this.listView1.SelectedIndices.Count; i++)
                {
                    this.listView1.Items[this.listView1.SelectedIndices[i]].Selected = false;
                }
            }

            if (this.listView3.SelectedIndices.Count > 0)
            {
                for (int i = 0; i < this.listView3.SelectedIndices.Count; i++)
                {
                    this.listView3.Items[this.listView3.SelectedIndices[i]].Selected = false;
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listView3.Show();
            listView1.Hide();
            listView2.Hide();
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;

            if (this.listView1.SelectedIndices.Count > 0)
            {
                for (int i = 0; i < this.listView1.SelectedIndices.Count; i++)
                {
                    this.listView1.Items[this.listView1.SelectedIndices[i]].Selected = false;
                }
            }

            if (this.listView2.SelectedIndices.Count > 0)
            {
                for (int i = 0; i < this.listView2.SelectedIndices.Count; i++)
                {
                    this.listView2.Items[this.listView2.SelectedIndices[i]].Selected = false;
                }
            }
        }

        private void Add_menu_Click(object sender, EventArgs e) // 메뉴 추가 메소드
        {
            if (listView1.SelectedIndices.Count > 0) // 메인 메뉴가 선택되었을 떄
            {
                int indexnum = listView1.FocusedItem.Index;
                string m_name = listView1.Items[indexnum].Text;

                if (Order_listView.Items.Count == 0) // 주문목록이 1도 없다면
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = m_name;
                    item.SubItems.Add(1.ToString());
                    amount_label.Text = 1.ToString();
                    Order_listView.Items.Add(item);

                    string sprice = listView1.Items[indexnum].Tag.ToString(); // 가격 갱신
                    price += int.Parse(sprice);
                    price_label.Text = "가격 : " + price.ToString();
                }

                else // 주문목록이 있다면
                {
                    int excute = 0; // 입력된 값이 있는지 없는지 찾을 때

                    for (int i = 0; i < Order_listView.Items.Count; i++)
                    {
                        if (Order_listView.Items[i].Text == m_name)
                        {
                            string amount = Order_listView.Items[i].SubItems[1].Text;
                            int addamount = int.Parse(amount);
                            addamount++;
                            Order_listView.Items[i].SubItems[1].Text = addamount.ToString();
                            amount_label.Text = addamount.ToString();

                            string sprice = listView1.Items[indexnum].Tag.ToString(); // 가격 갱신
                            price += int.Parse(sprice);
                            price_label.Text = "가격 : " + price.ToString();

                            excute = 1;
                        }
                    }
                    if (excute == 0) // 중복되는 값이 없다면 추가
                    {
                        ListViewItem item = new ListViewItem(m_name);
                        item.SubItems.Add(1.ToString());
                        amount_label.Text = 1.ToString();
                        Order_listView.Items.Add(item);

                        string sprice = listView1.Items[indexnum].Tag.ToString(); // 가격 갱신
                        price += int.Parse(sprice);
                        price_label.Text = "가격 : " + price.ToString();
                    }
                }  
            }

            else if (listView2.SelectedIndices.Count > 0) // 사이드 메뉴가 선택 되었을 떄
            {
                int indexnum = listView2.FocusedItem.Index;
                string m_name = listView2.Items[indexnum].Text;

                if (Order_listView.Items.Count == 0) // 주문목록이 1도 없다면
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = m_name;
                    item.SubItems.Add(1.ToString());
                    amount_label.Text = 1.ToString();
                    Order_listView.Items.Add(item);

                    string sprice = listView2.Items[indexnum].Tag.ToString(); // 가격 갱신
                    price += int.Parse(sprice);
                    price_label.Text = "가격 : " + price.ToString();
                }

                else // 주문목록이 있다면
                {
                    int excute = 0; // 입력된 값이 있는지 없는지 찾을 때

                    for (int i = 0; i < Order_listView.Items.Count; i++)
                    {
                        if (Order_listView.Items[i].Text == m_name)
                        {
                            string amount = Order_listView.Items[i].SubItems[1].Text;
                            int addamount = int.Parse(amount);
                            addamount++;
                            Order_listView.Items[i].SubItems[1].Text = addamount.ToString();
                            amount_label.Text = addamount.ToString();

                            string sprice = listView2.Items[indexnum].Tag.ToString(); // 가격 갱신
                            price += int.Parse(sprice);
                            price_label.Text = "가격 : " + price.ToString();

                            excute = 1;
                        }
                    }
                    if (excute == 0) // 중복되는 값이 없다면 추가
                    {
                        ListViewItem item = new ListViewItem(m_name);
                        item.SubItems.Add(1.ToString());
                        amount_label.Text = 1.ToString();
                        Order_listView.Items.Add(item);

                        string sprice = listView2.Items[indexnum].Tag.ToString(); // 가격 갱신
                        price += int.Parse(sprice);
                        price_label.Text = "가격 : " + price.ToString();
                    }
                }
            }

            else if (listView3.SelectedIndices.Count > 0) // 음료 메뉴가 선택 되었을 떄
            {

                int indexnum = listView3.FocusedItem.Index;
                string m_name = listView3.Items[indexnum].Text;

                if (Order_listView.Items.Count == 0) // 주문목록이 1도 없다면
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = m_name;
                    item.SubItems.Add(1.ToString());
                    amount_label.Text = 1.ToString();
                    Order_listView.Items.Add(item);

                    string sprice = listView3.Items[indexnum].Tag.ToString(); // 가격 갱신
                    price += int.Parse(sprice);
                    price_label.Text = "가격 : " + price.ToString();
                }

                else // 주문목록이 있다면
                {
                    int excute = 0; // 입력된 값이 있는지 없는지 찾을 때

                    for (int i = 0; i < Order_listView.Items.Count; i++)
                    {
                        if (Order_listView.Items[i].Text == m_name)
                        {
                            string amount = Order_listView.Items[i].SubItems[1].Text;
                            int addamount = int.Parse(amount);
                            addamount++;
                            Order_listView.Items[i].SubItems[1].Text = addamount.ToString();
                            amount_label.Text = addamount.ToString();

                            string sprice = listView3.Items[indexnum].Tag.ToString(); // 가격 갱신
                            price += int.Parse(sprice);
                            price_label.Text = "가격 : " + price.ToString();

                            excute = 1;
                        }
                    }
                    if (excute == 0) // 중복되는 값이 없다면 추가
                    {
                        ListViewItem item = new ListViewItem(m_name);
                        item.SubItems.Add(1.ToString());
                        amount_label.Text = 1.ToString();
                        Order_listView.Items.Add(item);

                        string sprice = listView3.Items[indexnum].Tag.ToString(); // 가격 갱신
                        price += int.Parse(sprice);
                        price_label.Text = "가격 : " + price.ToString();
                    }
                }
            }
        }

        private void Delete_menu_Click(object sender, EventArgs e) // 메뉴 삭제 메소드
        {
            if (listView1.SelectedIndices.Count > 0) // 메인 메뉴가 선택되었을 떄
            {
                int indexnum = listView1.FocusedItem.Index;
                string m_name = listView1.Items[indexnum].Text;

                if (Order_listView.Items.Count == 0) // 주문목록이 1도 없다면
                {
                    MessageBox.Show("지울 목록을 선택해 주세요");
                }

                else // 주문목록이 있다면
                {
                    for (int i = 0; i < Order_listView.Items.Count; i++)
                    {
                        if (Order_listView.Items[i].Text == m_name)
                        {
                            string amount = Order_listView.Items[i].SubItems[1].Text;
                            int delamount = int.Parse(amount);
                            delamount--;

                            string sprice = listView1.Items[indexnum].Tag.ToString(); // 가격 갱신
                            price -= int.Parse(sprice);
                            price_label.Text = "가격 : " + price.ToString();

                            if (delamount == 0)
                            {
                                Order_listView.Items.RemoveAt(i);
                                amount_label.Text = "0";
                            }
                            else
                            {
                                Order_listView.Items[i].SubItems[1].Text = delamount.ToString();
                                amount_label.Text = delamount.ToString();
                            }
                        }
                    }
                }
            }

            else if (listView2.SelectedIndices.Count > 0) // 사이드 메뉴가 선택 되었을 떄
            {
                int indexnum = listView2.FocusedItem.Index;
                string m_name = listView2.Items[indexnum].Text;

                if (Order_listView.Items.Count == 0) // 주문목록이 1도 없다면
                {
                    MessageBox.Show("지울 목록을 선택해 주세요");
                }

                else // 주문목록이 있다면
                {
                    for (int i = 0; i < Order_listView.Items.Count; i++)
                    {
                        if (Order_listView.Items[i].Text == m_name)
                        {
                            string amount = Order_listView.Items[i].SubItems[1].Text;
                            int delamount = int.Parse(amount);
                            delamount--;

                            string sprice = listView2.Items[indexnum].Tag.ToString(); // 가격 갱신
                            price -= int.Parse(sprice);
                            price_label.Text = "가격 : " + price.ToString();

                            if (delamount == 0)
                            {
                                Order_listView.Items.RemoveAt(i);
                                amount_label.Text = "0";
                            }
                            else
                            {
                                Order_listView.Items[i].SubItems[1].Text = delamount.ToString();
                                amount_label.Text = delamount.ToString();
                            }
                        }
                    }
                }
            }

            else if (listView3.SelectedIndices.Count > 0) // 음료 메뉴가 선택 되었을 떄
            {
                int indexnum = listView3.FocusedItem.Index;
                string m_name = listView3.Items[indexnum].Text;

                if (Order_listView.Items.Count == 0) // 주문목록이 1도 없다면
                {
                    MessageBox.Show("지울 목록을 선택해 주세요");
                }

                else // 주문목록이 있다면
                {
                    for (int i = 0; i < Order_listView.Items.Count; i++)
                    {
                        if (Order_listView.Items[i].Text == m_name)
                        {
                            string amount = Order_listView.Items[i].SubItems[1].Text;
                            int delamount = int.Parse(amount);
                            delamount--;

                            string sprice = listView3.Items[indexnum].Tag.ToString(); // 가격 갱신
                            price -= int.Parse(sprice);
                            price_label.Text = "가격 : " + price.ToString();

                            if (delamount == 0)
                            {
                                Order_listView.Items.RemoveAt(i);
                                amount_label.Text = "0";
                            }
                            else
                            {
                                Order_listView.Items[i].SubItems[1].Text = delamount.ToString();
                                amount_label.Text = delamount.ToString();
                            }
                        }
                    }
                }
            }
        }

        private void Order_button_Click(object sender, EventArgs e) // 주문 버튼 클릭
        {
            NetworkStream stream = clientSocket.GetStream();
            String temp = "1번 테이블 주문 : ";
            int i = 0;
            foreach (var listViewItem in Order_listView.Items) // 리스트박스1에 있는 값을 모두 더함
            {
                temp += Order_listView.Items[i].SubItems[0].Text + " 수량 : " + Order_listView.Items[i].SubItems[1].Text + " ";
                i++;
            }

            temp += "\x01" + textBox1.Text; // 요청사항을 더함
            if (Order_listView.Items.Count == 0)
            {
                MessageBox.Show("주문 목록이 없습니다!");
            }
            else
            {
                byte[] sbuffer = Encoding.Unicode.GetBytes(temp + "$"); // listBox1의 아이템을 전송
                stream.Write(sbuffer, 0, sbuffer.Length);
                stream.Flush();
                MessageBox.Show("주문이 완료되었습니다.");
            }
            foreach (var listViewItem in Order_listView.Items) // 리스트뷰아이템2에 있는 값을 모두 지움
            {
                Order_listView.Items[0].Remove(); // 주문목록 초기화
            }
            price_label.Text = "가격 : 0";
            amount_label.Text = "0";
            price = 0;
            textBox1.Clear();
        }

        private void Call_button_Click(object sender, EventArgs e) // 직원 호출 버튼 누를 때
        {
            NetworkStream stream = clientSocket.GetStream();
            String temp = "1번 테이블 직원호출!";
            byte[] sbuffer = Encoding.Unicode.GetBytes("require" + '\x01' + temp + "$");
            stream.Write(sbuffer, 0, sbuffer.Length);
            stream.Flush();
            MessageBox.Show("직원 호출 요청이 완료되었습니다.");
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            int indexnum = listView1.FocusedItem.Index;
            string m_name = listView1.Items[indexnum].Text;

            amount_label.Text = "0";

            for (int i = 0; i < Order_listView.Items.Count; i++)
            {
                if (Order_listView.Items[i].Text == m_name)
                {
                    string amount = Order_listView.Items[i].SubItems[1].Text;
                    int nowamount = int.Parse(amount);

                    if (nowamount != 0)  // 선택된 리스트뷰1의 리스튜2 수량이 0이 아니라면
                    {
                        amount_label.Text = nowamount.ToString();
                        break;
                    }
                }
            }

            Selected_menu_label.Text = m_name;
            pictureBox1.Image = imageList4.Images[indexnum];
            Selected_menu_price_label2.Text = listView1.Items[indexnum].Tag.ToString() + "원";
        }

        private void listView2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            int indexnum = listView2.FocusedItem.Index;
            string m_name = listView2.Items[indexnum].Text;

            amount_label.Text = "0";

            for (int i = 0; i < Order_listView.Items.Count; i++)
            {
                if (Order_listView.Items[i].Text == m_name)
                {
                    string amount = Order_listView.Items[i].SubItems[1].Text;
                    int nowamount = int.Parse(amount);

                    if (nowamount != 0)  // 선택된 리스트뷰1의 리스튜2 수량이 0이 아니라면
                    {
                        amount_label.Text = nowamount.ToString();
                        break;
                    }
                }
            }

            Selected_menu_label.Text = m_name;
            pictureBox1.Image = imageList5.Images[indexnum];
            Selected_menu_price_label2.Text = listView2.Items[indexnum].Tag.ToString() + "원";
        }

        private void listView3_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            int indexnum = listView3.FocusedItem.Index;
            string m_name = listView3.Items[indexnum].Text;

            amount_label.Text = "0";

            for (int i = 0; i < Order_listView.Items.Count; i++)
            {
                if (Order_listView.Items[i].Text == m_name)
                {
                    string amount = Order_listView.Items[i].SubItems[1].Text;
                    int nowamount = int.Parse(amount);

                    if (nowamount != 0)  // 선택된 리스트뷰1의 리스튜2 수량이 0이 아니라면
                    {
                        amount_label.Text = nowamount.ToString();
                        break;
                    }
                }
            }

            Selected_menu_price_label2.Text = m_name;
            pictureBox1.Image = imageList6.Images[indexnum];
            Selected_menu_price_label.Text = listView3.Items[indexnum].Tag.ToString() + "원";
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
