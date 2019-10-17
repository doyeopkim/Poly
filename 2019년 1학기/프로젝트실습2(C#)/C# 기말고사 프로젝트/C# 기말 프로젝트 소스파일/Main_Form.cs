using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Jugal
{
    public partial class Main_Form : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=manlesslibrary;Uid=root;Pwd=1234; CharSet=utf8"); // DB 접속

        static string LoginID = ""; // 저장하고 있을 ID명

        public static string LoginId()
        {
            return LoginID;
        }

        public Main_Form()
        {
            InitializeComponent();
        }

        internal class ListviewItemComparer : IComparer // listView Sorting을 위한 클래스
        {
            private int column;
            public String sort = "asc";

            public ListviewItemComparer(int column, String sort)
            {
                this.column = column;
                this.sort = sort;
            }

            public int Compare(object x, object y)
            {
                if (sort == "asc")
                {
                    return String.Compare(((ListViewItem)x).SubItems[column].Text, ((ListViewItem)y).SubItems[column].Text);
                }
                else
                {
                    return String.Compare(((ListViewItem)y).SubItems[column].Text, ((ListViewItem)x).SubItems[column].Text);
                }
            }
        }

        public void Notice() // 예약한 책이 있으면 알림
        {
            string notice_Query = "SELECT book_name, book_code FROM book_reservation WHERE book_userid = '" + LoginID + "'";

            string bookcd = "", bookname = "";
            int count = 0, rvcount = -1;

            connection.Open();
            MySqlCommand command = new MySqlCommand(notice_Query, connection);

            try
            {
                MySqlDataReader reader = null;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    bookcd += (string)reader["book_code"] + " ";
                    count++;
                }
                reader.Close();
                string[] bookcode = bookcd.Split('\x020');

                if (bookcode[0] != "")
                {
                    for (int i = 0; i < count; i++)
                    {
                        MySqlCommand cm = new MySqlCommand("SELECT book_name FROM book_register WHERE book_code = '" + bookcode[i] + "' AND book_pamount >= 1", connection);

                            MySqlDataReader rd = null;
                            rd = cm.ExecuteReader();

                            while (rd.Read())
                            {
                                bookname += (string)rd["book_name"] + " ";

                                if ((string)rd["book_name"] != "")
                                {
                                rvcount = i;
                                }
                            }
                             rd.Close();

                       if (rvcount != -1)
                        { 
                            MySqlCommand delete_reservation = new MySqlCommand("DELETE FROM book_reservation WHERE book_code = '" + bookcode[rvcount] + "' AND book_userid = '" + LoginID + "'", connection);

                            if (delete_reservation.ExecuteNonQuery() == 1)
                            {

                            }
                            else
                            {
                                MessageBox.Show("예약 알림 오류", "오류");
                            }
                        }
                        rvcount = -1;
                    }
                    if (bookname != "")
                    {
                        MessageBox.Show(bookname + "\n" + "도서가 반납되었습니다.", "알림 신청 도서 반납 알림");
                    }
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "예기치 못한 오류 발생");
            }
            finally
            {
                connection.Close();
            }
        }


        private void login_button_Click(object sender, EventArgs e) // 로그인 버튼
        {
            // 어떤 항목이 입력되지 않았다면
            if (loginid_textBox.Text == "" || loginpw_textBox.Text == "")
            {
                MessageBox.Show("아이디와 비밀번호를 입력해 주세요!", "로그인 오류");
            }
            // 로그인 성공
            else
            {
                string loginQuery = "SELECT user_id, user_pw FROM user_register WHERE (user_id = '" + loginid_textBox.Text + "' and user_pw = '" + loginpw_textBox.Text + "')";
                // 이름, 아이디, 비밀번호, 연락처를 DB에 저장
                connection.Open();
                MySqlCommand command = new MySqlCommand(loginQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();

                try//예외 처리
                {
                    // 아이디가 없거나 비밀번호가 틀렸다면
                    if (!reader.Read())
                    {
                        MessageBox.Show("아이디가 없거나 비밀번호가 틀렸습니다!", "로그인 실패");
                    }
                    // 로그인 성공시
                    else
                    {
                        LoginID = loginid_textBox.Text;

                        if (LoginID == "admin")
                        {
                            MessageBox.Show("관리자 접속", "관리자 모드");
                            loginid_textBox.Clear();
                            loginpw_textBox.Clear();
                            connection.Close();
                            Main_Panel.Hide();
                            Admin_Panel.Show();
                            try
                            {
                                // book_register 테이블을 register_listView에 출력
                                connection.Open();

                                Admin_book_register_listview(); // 현재 보유 도서 리스트뷰 갱신

                                // book_retnal 테이블을 rental-listView에 출력
                                string book_rental_Querry = "SELECT * FROM book_rental";
                                MySqlCommand com = new MySqlCommand(book_rental_Querry, connection);
                                MySqlDataAdapter dap = new MySqlDataAdapter(book_rental_Querry, connection);
                                DataTable dtp = new DataTable();
                                dap.Fill(dtp);
                                Admin_Book_Rental_List_listView.Items.Clear(); // View가 중복조회 되는것을 방지한다.

                                for (int i = 0; i < dtp.Rows.Count; i++)
                                {
                                    DataRow drp = dtp.Rows[i];
                                    ListViewItem listitem = new ListViewItem(drp["book_name"].ToString());
                                    listitem.SubItems.Add(drp["book_author"].ToString());
                                    listitem.SubItems.Add(drp["book_publisher"].ToString());
                                    listitem.SubItems.Add(drp["book_code"].ToString());
                                    listitem.SubItems.Add(drp["book_userid"].ToString());
                                    listitem.SubItems.Add(drp["book_userhp"].ToString());
                                    listitem.SubItems.Add(drp["book_deadline"].ToString());
                                    Admin_Book_Rental_List_listView.Items.Add(listitem);
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                connection.Close();
                            }
                            Admin_Panel.Show();
                        }
                        else
                        {
                            MessageBox.Show(LoginID + "님 환영합니다.", "로그인 성공");
                            loginid_textBox.Clear();
                            loginpw_textBox.Clear();
                            connection.Close();
                            Book_Rental_List_View("SELECT * FROM book_register");
                            Main_Panel.Hide();
                            Book_Rental_List_Panel.Show();
                            Notice();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "예기치 못한 오류 발생");
                    connection.Close();
                }
            }  
        }

        private void register_button_Click(object sender, EventArgs e) // 회원 가입 폼 띄우기
        {
            Register_User_Form RU = new Register_User_Form();
            RU.StartPosition = FormStartPosition.Manual;
            RU.Location = new Point(300, 150);
            RU.ShowDialog();
        }

        private void findidpw_button_Click(object sender, EventArgs e) // ID, PW 찾기 폼 띄우기
        {
            Search_Idpw_Form SIP = new Search_Idpw_Form();
            SIP.StartPosition = FormStartPosition.Manual;
            SIP.Location = new Point(450, 275);
            SIP.ShowDialog();
        }

        // Main_Form

        public void Admin_book_register_listview() // Admin book register 리스트뷰 갱신 메서드
        {
            // 삭제하고 다시 리스트뷰를 갱신
            string Query = "SELECT * FROM book_register";
            MySqlCommand recommand = new MySqlCommand(Query, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(Query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Admin_Book_List_listView.Items.Clear(); // View가 중복조회 되는것을 방지한다.

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["book_name"].ToString());
                listitem.SubItems.Add(dr["book_author"].ToString());
                listitem.SubItems.Add(dr["book_publisher"].ToString());
                listitem.SubItems.Add(dr["book_code"].ToString());
                listitem.SubItems.Add(dr["book_categorize"].ToString());
                listitem.SubItems.Add(dr["book_amount"].ToString());
                Admin_Book_List_listView.Items.Add(listitem);
            }
        }

        private void Admin_Logout_ToolStripMenuItem_Click(object sender, EventArgs e) // 관리자 로그아웃
        {
            Admin_Panel.Hide();
            Main_Panel.Show();
        }

        private void Admin_Search_button_Click(object sender, EventArgs e) // 관리자 검색
        {
            if (Admin_Search_textBox.Text != "") // 텍스트 박스에 입력된 값이 없는게 아니라면
            {
                try
                {
                    connection.Open();
                    string Query = "SELECT * FROM book_register WHERE book_name LIKE '%" + Admin_Search_textBox.Text + "%'";
                    MySqlCommand command = new MySqlCommand(Query, connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(Query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Admin_Book_List_listView.Items.Clear(); // View가 중복조회 되는것을 방지한다.

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        ListViewItem listitem = new ListViewItem(dr["book_name"].ToString());
                        listitem.SubItems.Add(dr["book_author"].ToString());
                        listitem.SubItems.Add(dr["book_publisher"].ToString());
                        listitem.SubItems.Add(dr["book_code"].ToString());
                        listitem.SubItems.Add(dr["book_categorize"].ToString());
                        listitem.SubItems.Add(dr["book_amount"].ToString());
                        Admin_Book_List_listView.Items.Add(listitem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                try
                {
                    // book_register 테이블을 register_listView에 출력
                    connection.Open();
                    string Query = "SELECT * FROM book_register";
                    MySqlCommand command = new MySqlCommand(Query, connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(Query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Admin_Book_List_listView.Items.Clear(); // View가 중복조회 되는것을 방지한다.

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        ListViewItem listitem = new ListViewItem(dr["book_name"].ToString());
                        listitem.SubItems.Add(dr["book_author"].ToString());
                        listitem.SubItems.Add(dr["book_publisher"].ToString());
                        listitem.SubItems.Add(dr["book_code"].ToString());
                        listitem.SubItems.Add(dr["book_categorize"].ToString());
                        listitem.SubItems.Add(dr["book_amount"].ToString());
                        Admin_Book_List_listView.Items.Add(listitem);
                    }
                    // book_retnal 테이블을 rental-listView에 출력
                    string book_rental_Querry = "SELECT * FROM book_rental";
                    MySqlCommand com = new MySqlCommand(book_rental_Querry, connection);
                    MySqlDataAdapter dap = new MySqlDataAdapter(book_rental_Querry, connection);
                    DataTable dtp = new DataTable();
                    dap.Fill(dtp);
                    Admin_Book_Rental_List_listView.Items.Clear(); // View가 중복조회 되는것을 방지한다.

                    for (int i = 0; i < dtp.Rows.Count; i++)
                    {
                        DataRow drp = dtp.Rows[i];
                        ListViewItem listitem = new ListViewItem(drp["book_name"].ToString());
                        listitem.SubItems.Add(drp["book_author"].ToString());
                        listitem.SubItems.Add(drp["book_publisher"].ToString());
                        listitem.SubItems.Add(drp["book_code"].ToString());
                        listitem.SubItems.Add(drp["book_userid"].ToString());
                        listitem.SubItems.Add(drp["book_userhp"].ToString());
                        listitem.SubItems.Add(drp["book_deadline"].ToString());
                        Admin_Book_Rental_List_listView.Items.Add(listitem);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void Delete_Book_button_Click(object sender, EventArgs e) // 도서 삭제 버튼
        {
            ListView.SelectedListViewItemCollection deletebook = this.Admin_Book_List_listView.SelectedItems;

            string book_name = "", book_code = ""; // 임시로 저장하고 있을 도서이름, 도서코드와 도서수량
            int book_amount = 0;

            foreach (ListViewItem item in deletebook) // 지울 책이름과 작가명을 변수에 저장
            {
                book_name = (item.SubItems[0].Text);
                book_code = (item.SubItems[1].Text);
                book_amount = int.Parse(item.SubItems[5].Text);
            }

            //MessageBox.Show(book_name + " " + book_author);
            connection.Open();
            if (book_amount == 1)
            {
                string delete_book_register_Query = "DELETE FROM book_register WHERE book_name = '" + book_name + "' AND book_author = '" + book_code + "'";
                MySqlCommand command = new MySqlCommand(delete_book_register_Query, connection);

                try//예외 처리
                {
                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("목록에서 책을 삭제했습니다..", "삭제 완료");

                        Admin_book_register_listview(); // 삭제하고 다시 리스트뷰를 갱신
                    }
                    else
                    {
                        MessageBox.Show("지울 책을 선택해 주세요", "삭제 오류");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "예기치 못한 오류 발생");
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                string delete_book_register_Query = "UPDATE book_register SET book_amount = " + (book_amount-1) + ", book_pamount = " + (book_amount-1) + " WHERE book_name = '" + book_name + "' AND book_author = '" + book_code + "'";
                MySqlCommand command = new MySqlCommand(delete_book_register_Query, connection);

                try//예외 처리
                {
                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("목록에서 책을 삭제했습니다..", "삭제 완료");

                        Admin_book_register_listview(); // 삭제하고 다시 리스트뷰를 갱신
                    }
                    else
                    {
                        MessageBox.Show("지울 책을 선택해 주세요", "삭제 오류");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "예기치 못한 오류 발생");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void Register_Book_button_Click(object sender, EventArgs e) // 도서 추가 폼
        {
            Register_Book_Form RB = new Register_Book_Form();
            RB.StartPosition = FormStartPosition.Manual;
            RB.Location = new Point(400, 175);
            RB.ShowDialog();
        }

        private void Admin_Book_List_listView_ColumnClick(object sender, ColumnClickEventArgs e) // 정렬을 위한 Admin_Book 현재 컬럼 클릭 이벤트
        {
            if (this.Admin_Book_List_listView.Sorting == SortOrder.Ascending || Admin_Book_List_listView.Sorting == SortOrder.None)
            {
                this.Admin_Book_List_listView.ListViewItemSorter = new ListviewItemComparer(e.Column, "desc");
                Admin_Book_List_listView.Sorting = SortOrder.Descending;
            }
            else
            {
                this.Admin_Book_List_listView.ListViewItemSorter = new ListviewItemComparer(e.Column, "asc");
                Admin_Book_List_listView.Sorting = SortOrder.Ascending;
            }
            Admin_Book_List_listView.Sort();
        }

        private void Admin_Book_Rental_List_listView_ColumnClick(object sender, ColumnClickEventArgs e) // 정렬을 위한 Admin_Rental_Book 현재 컬럼 클릭 이벤트
        {
            if (this.Admin_Book_Rental_List_listView.Sorting == SortOrder.Ascending || Admin_Book_Rental_List_listView.Sorting == SortOrder.None)
            {
                this.Admin_Book_Rental_List_listView.ListViewItemSorter = new ListviewItemComparer(e.Column, "desc");
                Admin_Book_Rental_List_listView.Sorting = SortOrder.Descending;
            }
            else
            {
                this.Admin_Book_Rental_List_listView.ListViewItemSorter = new ListviewItemComparer(e.Column, "asc");
                Admin_Book_Rental_List_listView.Sorting = SortOrder.Ascending;
            }
            Admin_Book_Rental_List_listView.Sort();
        }

        // Admin_Form 

        public void Book_Rental_List_View(string Query) // 렌탈리스트 뷰에 추가 메서드
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(Query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                User_Book_List_listView.Items.Clear(); // View가 중복조회 되는것을 방지한다.

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["book_name"].ToString());
                    listitem.SubItems.Add(dr["book_author"].ToString());
                    listitem.SubItems.Add(dr["book_publisher"].ToString());
                    listitem.SubItems.Add(dr["book_code"].ToString());
                    listitem.SubItems.Add(dr["book_categorize"].ToString());
                    listitem.SubItems.Add(dr["book_pamount"].ToString());
                    listitem.SubItems.Add(dr["book_deadline"].ToString());
                    User_Book_List_listView.Items.Add(listitem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public string add_deadline() // deadline에 저장할 날짜(현재날짜 +14일) 메서드 
        {
            DateTime now = DateTime.Now;
            now = now.AddDays(14);
            return(now.ToString("yyyy.MM.dd"));
        }

        private void Rental_book_button_Click(object sender, EventArgs e) // 도서 대여 버튼
        {
            ListView.SelectedListViewItemCollection rentalbook = this.User_Book_List_listView.SelectedItems;

            string book_name = "", book_author = "", book_publisher = "", book_code = "", book_categorize = ""; // 리스트뷰의 선택된 값을 임시로 저장하고 있을 변수 

            string ymd = add_deadline(); // ymd에 현재날짜 +14(도서 반납기한)를 저장

            foreach (ListViewItem item in rentalbook) // 빌릴 책이름과 작가명을 변수에 저장
            {
                book_name = (item.SubItems[0].Text);
                book_author = (item.SubItems[1].Text);
                book_publisher = (item.SubItems[2].Text);
                book_code = (item.SubItems[3].Text);
                book_categorize = (item.SubItems[4].Text);
            }

            int popular = 0, amount = 0;

            string user_hp = "";

            connection.Open();
            
            string user_hp_Query = "SELECT user_hp FROM user_register WHERE user_id = '" + LoginID + "'";
            MySqlDataReader rd = null;
            MySqlCommand cd = new MySqlCommand(user_hp_Query, connection);
            rd = cd.ExecuteReader();

            while (rd.Read())
            {
                user_hp = (string)rd["user_hp"];
            }
            rd.Close();

            // 선택된 값 저장 -> 인서트 문에 담기
            string book_rental_Query = "INSERT INTO book_rental(book_name, book_author, book_publisher, book_code, book_userid, book_userhp, book_deadline) VALUES('" + book_name + "', '" + book_author + "', '" + book_publisher + "', '" + book_code + "', '" + LoginID + "', '" + user_hp + "', '" + ymd + "')";
            string book_amount_popluar_Query = "SELECT book_pamount, book_popular FROM book_register WHERE book_name = '" + book_name + "' AND book_code = '" + book_code + "'";

            MySqlDataReader reader = null;
            MySqlCommand cmd = new MySqlCommand(book_amount_popluar_Query, connection);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                amount = (int)reader["book_pamount"];
                popular = (int)reader["book_popular"];
            }
            reader.Close();

            amount--; // 선택된 책의 amount 값(수량)을 1 감소
            popular++; // 선택된 책의 popular 값(대여)을 1 증가

            if (book_name == "")
            {
                MessageBox.Show("도서를 선택해 주세요", "오류");
                connection.Close();
            }

            else if (amount <= -1 &&book_name != "") // 책이 0개라면
            {
                MessageBox.Show("책 보유량이 0 입니다!", "대여 실패");
                connection.Close();
            }

            else if (amount == 0) // 책 보유량을 0으로 만든다면 레지스터 테이블의 deadline값을 추가
            {
                // 책 정보를 DB에 저장
                MySqlCommand command = new MySqlCommand(book_rental_Query, connection);

                string book_register_popular_update_Query = "UPDATE book_register SET book_popular = " + popular + ", book_pamount = " + amount + ", book_deadline = '" + ymd + "' WHERE book_name = '" + book_name + "' AND book_code = '" + book_code + "'";
                MySqlCommand register_update = new MySqlCommand(book_register_popular_update_Query, connection);


                try//예외 처리
                {
                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                    if (command.ExecuteNonQuery() == 1 && register_update.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("정상적으로 책 대여에 성공했습니다.", "대여 완료");
                    }
                    else
                    {
                        MessageBox.Show("오류 발생!", "오류");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "예기치 못한 오류 발생");
                }
                finally
                {
                    connection.Close();
                    Book_Rental_List_View("SELECT * FROM book_register");
                }
            }

            else
            {
                // 책 정보를 DB에 저장
                MySqlCommand command = new MySqlCommand(book_rental_Query, connection);

                string book_register_popular_update_Query = "UPDATE book_register SET book_popular = " + popular + ", book_pamount = " + amount + " WHERE book_name = '" + book_name + "' AND book_code = '" + book_code + "'";
                MySqlCommand register_update = new MySqlCommand(book_register_popular_update_Query, connection);


                try//예외 처리
                {
                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                    if (command.ExecuteNonQuery() == 1 && register_update.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("정상적으로 책 대여에 성공했습니다.", "대여 완료");
                    }
                    else
                    {
                        MessageBox.Show("오류 발생!", "오류");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "예기치 못한 오류 발생");
                }
                finally
                {
                    connection.Close();
                    Book_Rental_List_View("SELECT * FROM book_register");
                }
            }
        }

        private void Search_book_button_Click(object sender, EventArgs e) // 사용자 도서 검색 버튼
        {
            if (Book_Search_textBox.Text != "") // 텍스트 박스에 입력된 값이 없는게 아니라면
            {
                Book_Rental_List_View("SELECT * FROM book_register WHERE book_name LIKE '%" + Book_Search_textBox.Text + "%'");
            }
            else
            {
                MessageBox.Show("값을 입력해 주세요!", "검색 오류");
            }
        }

        private void User_Book_List_listView_SelectedIndexChanged(object sender, EventArgs e) // 선택된 도서의 책 정보를 레이블에 표시할 이벤트
        {
            ListView.SelectedListViewItemCollection rentalbook = this.User_Book_List_listView.SelectedItems;

            string book_name = "", book_code = ""; // 리스트뷰의 선택된 값을 임시로 저장하고 있을 변수 

            foreach (ListViewItem item in rentalbook) // 책 인포를 찾을 키워드 책 이름과 코드를 저장
            {
                book_name = (item.SubItems[0].Text);
                book_code = (item.SubItems[3].Text);
            }

            string book_info_Query = "SELECT book_info FROM book_register WHERE book_name = '" + book_name + "' AND book_code = '" + book_code + "'";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(book_info_Query, connection);
                MySqlDataReader reader = null;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Book_info_label.Text = (string)reader["book_info"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void User_Book_List_listView_ColumnClick(object sender, ColumnClickEventArgs e) // 정렬을 위한 User_Book 현재 컬럼 클릭 이벤트
        {
            if (this.User_Book_List_listView.Sorting == SortOrder.Ascending || User_Book_List_listView.Sorting == SortOrder.None)
            {
                this.User_Book_List_listView.ListViewItemSorter = new ListviewItemComparer(e.Column, "desc");
                User_Book_List_listView.Sorting = SortOrder.Descending;
            }
            else
            {
                this.User_Book_List_listView.ListViewItemSorter = new ListviewItemComparer(e.Column, "asc");
                User_Book_List_listView.Sorting = SortOrder.Ascending;
            }
            User_Book_List_listView.Sort();
        }

        // 라디오 버튼 이벤트 처리 **

        private void All_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Book_Rental_List_View("SELECT * FROM book_register");
        }

        private void Society_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Book_Rental_List_View("SELECT * FROM book_register WHERE book_categorize = '사회학'");
        }

        private void Science_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Book_Rental_List_View("SELECT * FROM book_register WHERE book_categorize = '과학'");
        }

        private void Art_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Book_Rental_List_View("SELECT * FROM book_register WHERE book_categorize = '예술'");
        }

        private void ForeignL_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Book_Rental_List_View("SELECT * FROM book_register WHERE book_categorize = '외국어'");
        }

        private void Novel_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Book_Rental_List_View("SELECT * FROM book_register WHERE book_categorize = '소설'");
        }

        private void Comic_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Book_Rental_List_View("SELECT * FROM book_register WHERE book_categorize = '만화'");
        }

        private void Computer_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Book_Rental_List_View("SELECT * FROM book_register WHERE book_categorize = '컴퓨터'");
        }

        private void ForeignB_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Book_Rental_List_View("SELECT * FROM book_register WHERE book_categorize = '외국서적'");
        }

        // 라디오 버튼 이벤트 처리 **

        private void Rental_reservation_button_Click(object sender, EventArgs e) // 대여 예약 신청 버튼
        {
            ListView.SelectedListViewItemCollection rentalbook = this.User_Book_List_listView.SelectedItems;

            string book_name = "", book_author = "", book_publisher = "", book_code = "", book_categorize = ""; // 리스트뷰의 선택된 값을 임시로 저장하고 있을 변수 

            string ymd = add_deadline();

            foreach (ListViewItem item in rentalbook) // 빌릴 책이름과 작가명을 변수에 저장
            {
                book_name = (item.SubItems[0].Text);
                book_author = (item.SubItems[1].Text);
                book_publisher = (item.SubItems[2].Text);
                book_code = (item.SubItems[3].Text);
                book_categorize = (item.SubItems[4].Text);
            }

            int pamount = 0;

            // 선택된 값 저장 -> 인서트 문에 담기

            string book_pamount_Query = "SELECT book_pamount FROM book_register WHERE book_name = '" + book_name + "' AND book_code = '" + book_code + "'";
            // 책 정보를 DB에 저장

            try
            {
                connection.Open();
                MySqlDataReader reader = null;
                MySqlCommand cmd = new MySqlCommand(book_pamount_Query, connection);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pamount = (int)reader["book_pamount"];
                }
                reader.Close();

                if (pamount == 0)
                {
                    string book_reservation_Query = "INSERT INTO book_reservation VALUES('" + book_name + "', '" + book_code + "', '" + LoginID + "')";

                    MySqlCommand book_reservation = new MySqlCommand(book_reservation_Query, connection);

                    try//예외 처리
                    {
                        // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                        if (book_reservation.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("반납 알림이 정상적으로 신청되었습니다.", "대여 알림 성공");
                        }
                        else
                        {
                            MessageBox.Show("오류 발생!", "오류");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "예기치 못한 오류 발생");
                    }
                    finally
                    {
                        connection.Close();
                        Book_Rental_List_View("SELECT * FROM book_register");
                    }
                }

                else
                {
                    MessageBox.Show("책 보유량이 있어 알림 신청을 할 필요가 없습니다!", "대여 알림 실패");
                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("도서를 선택해 주세요", "오류");
            }
        }

        private void Popular5_ToolStripMenuItem_Click(object sender, EventArgs e) // 인기도서 5 폼
        {
            Popular5_Form P5 = new Popular5_Form();
            P5.StartPosition = FormStartPosition.Manual;
            P5.Location = new Point(325, 200);
            P5.ShowDialog();
        }

        private void Return_Book_ToolStripMenuItem_Click(object sender, EventArgs e) // 내 대여 목록 확인 창
        {
            Book_Rental_List_Panel.Hide();
            My_Book_Rental_List_Panel.Show();
            My_Book_Rental_ListView("SELECT * FROM book_rental WHERE book_userid = '" + LoginID + "'");
        }

        private void Change_member_info_ToolStripMenuItem_Click(object sender, EventArgs e) // 회원 정보 변경 창
        {
            Chainge_Member_Info CM = new Chainge_Member_Info();
            CM.StartPosition = FormStartPosition.Manual;
            CM.Location = new Point(300, 150);
            CM.ShowDialog();
        }

        private void Logout_ToolStripMenuItem2_Click(object sender, EventArgs e) // 로그 아웃 버튼 클릭
        {
            LoginID = "";
            Book_Rental_List_Panel.Hide();
            Main_Panel.Show();
        }

        // Book_Rental_List_Panel

        private void Go_Book_Rental_List_Form_button_Click(object sender, EventArgs e) // 돌아가기 버튼
        {
            My_Book_Rental_List_Panel.Hide();
            Book_Rental_List_View("select * from book_register");
            Book_Rental_List_Panel.Show();
        }

        private void Renewal_book_button_Click(object sender, EventArgs e) // 연장 신청 버튼
        {
            ListView.SelectedListViewItemCollection returnbook = this.My_Book_Rental_List_listView.SelectedItems;

            string book_name = "", book_code = ""; // 리스트뷰의 선택된 값을 임시로 저장하고 있을 변수 

            foreach (ListViewItem item in returnbook) // 반납 할 책이름과 작가명을 변수에 저장
            {
                book_name = (item.SubItems[0].Text);
                book_code = (item.SubItems[3].Text);
            }

            string ymd = add_deadline();

            string deadline_renewal_Query = "UPDATE book_rental SET book_deadline = '" + ymd + "' WHERE book_userid = '" + LoginID + "' AND book_name = '" + book_name + "' AND book_code = '" + book_code + "'";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(deadline_renewal_Query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(ymd + "까지 기간이 연장되었습니다.", "연장 성공");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("오류로 인하여 연장에 실패 했습니다", "알림");
            }
            finally
            {
                connection.Close();
            }
        }

        public void My_Book_Rental_ListView(string Query) // 로그인한 사람의 렌탈리스트 뷰에 추가 메서드
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(Query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                My_Book_Rental_List_listView.Items.Clear(); // View가 중복조회 되는것을 방지한다.

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["book_name"].ToString());
                    listitem.SubItems.Add(dr["book_author"].ToString());
                    listitem.SubItems.Add(dr["book_publisher"].ToString());
                    listitem.SubItems.Add(dr["book_code"].ToString());
                    listitem.SubItems.Add(dr["book_deadline"].ToString());
                    My_Book_Rental_List_listView.Items.Add(listitem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("대여 목록이 없습니다", "알림");
            }
            finally
            {
                connection.Close();
            }
        }

        private void Return_book_buutton_Click(object sender, EventArgs e) // 반납 버튼
        {
            ListView.SelectedListViewItemCollection returnbook = this.My_Book_Rental_List_listView.SelectedItems;

            string book_name = "", book_code = "", book_deadline = ""; // 리스트뷰의 선택된 값을 임시로 저장하고 있을 변수 

            foreach (ListViewItem item in returnbook) // 반납 할 책이름과 작가명을 변수에 저장
            {
                book_name = (item.SubItems[0].Text);
                book_code = (item.SubItems[3].Text);
                book_deadline = (item.SubItems[4].Text);
            }

            int amount = 0; // 책을 반납하면 수량을 올라가게 만들 변수

            // 선택된 값 저장 -> 인서트 문에 담기
            string book_return_Query = "DELETE FROM book_rental WHERE book_name = '" + book_name + "' AND book_code = '" + book_code + "' AND book_deadline = '" + book_deadline + "' LIMIT 1";
            string book_amount_Query = "SELECT book_pamount FROM book_register WHERE book_name = '" + book_name + "' AND book_code = '" + book_code + "'";

            // 책 정보를 DB에 저장
            connection.Open();
            MySqlCommand command = new MySqlCommand(book_return_Query, connection);

            MySqlDataReader reader = null;
            MySqlCommand cmd = new MySqlCommand(book_amount_Query, connection);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                amount = (int)reader["book_pamount"];
            }
            reader.Close();

            amount++; // 선택된 책의 amount 값(수량)을 1 증가

            string book_register_update_amount_Query = "UPDATE book_register SET book_pamount = " + amount + ", book_deadline = NULL WHERE book_name = '" + book_name + "' AND book_code = '" + book_code + "'";
            MySqlCommand register_update = new MySqlCommand(book_register_update_amount_Query, connection);

            try//예외 처리
            {
                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                if (command.ExecuteNonQuery() == 1 && register_update.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("정상적으로 반납 되었습니다.", "반납 완료");
                }
                else
                {
                    MessageBox.Show("반납할 책을 선택 해 주세요", "반납 실패");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "예기치 못한 오류 발생");
            }
            finally
            {
                connection.Close();
                My_Book_Rental_ListView("SELECT * FROM book_rental WHERE book_userid = '" + LoginID + "'");
            }
        }

        private void My_Book_Rental_List_listView_ColumnClick(object sender, ColumnClickEventArgs e) // 정렬을 위한 My_Book_Rental_List 현재 컬럼 클릭 이벤트
        {
            if (this.My_Book_Rental_List_listView.Sorting == SortOrder.Ascending || My_Book_Rental_List_listView.Sorting == SortOrder.None)
            {
                this.My_Book_Rental_List_listView.ListViewItemSorter = new ListviewItemComparer(e.Column, "desc");
                My_Book_Rental_List_listView.Sorting = SortOrder.Descending;
            }
            else
            {
                this.My_Book_Rental_List_listView.ListViewItemSorter = new ListviewItemComparer(e.Column, "asc");
                My_Book_Rental_List_listView.Sorting = SortOrder.Ascending;
            }
            My_Book_Rental_List_listView.Sort();
        }
    }
}