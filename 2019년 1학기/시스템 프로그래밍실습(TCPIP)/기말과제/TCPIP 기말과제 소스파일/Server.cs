using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace BonResto
{
    public partial class Server : Form
    {
        TcpListener server = null;
        TcpClient client = null;

        //메뉴객체에 보낼 리스트뷰
        ListView mainMenu = new ListView();
        ListView sideMenu = new ListView();
        ListView beverageMenu = new ListView();

        //메뉴정보를 담은 객체
        MenuInfo mainInfo;
        MenuInfo sideInfo;
        MenuInfo beverageInfo;

        public Server()
        {
            InitializeComponent();

            Thread t = new Thread(InitSocket);
            t.IsBackground = true;
            t.Start();

            //메뉴정보 폴더체크
            DirectoryInfo mmf = new DirectoryInfo(Application.StartupPath + @"\MainMenu");
            if (!mmf.Exists) { mmf.Create(); }
            DirectoryInfo smf = new DirectoryInfo(Application.StartupPath + @"\SideMenu");
            if (!smf.Exists) { smf.Create(); }
            DirectoryInfo bf = new DirectoryInfo(Application.StartupPath + @"\BeverageMenu");
            if (!bf.Exists) { bf.Create(); }

            //각 메뉴별 객체 생성
            mainInfo = new MenuInfo(mainMenu, mainImg);
            sideInfo = new MenuInfo(sideMenu, sideImg);
            beverageInfo = new MenuInfo(beverageMenu, beverageImg);

            //메뉴파일이 있다면 불러온다
            MenuManage.MenuLoad(mainInfo, Application.StartupPath + "\\MainMenu\\MainMenu.txt");
            MenuManage.MenuLoad(sideInfo, Application.StartupPath + "\\SideMenu\\SideMenu.txt");
            MenuManage.MenuLoad(beverageInfo, Application.StartupPath + "\\BeverageMenu\\BeverageMenu.txt");

            //사진파일을 불러온다
            replaceImg(mainInfo, Application.StartupPath + "\\MainMenu\\");
            replaceImg(sideInfo, Application.StartupPath + "\\SideMenu\\");
            replaceImg(beverageInfo, Application.StartupPath + "\\BeverageMenu\\");
        }

        // ******************************** 통신코드 ********************************
        private void InitSocket()
        {
            server = new TcpListener(IPAddress.Any, 9999); // 서버 접속, IP 포트
            client = default(TcpClient); // 소켓 설정
            server.Start(); // 서버 시작
            AddClient(listBox1, "서버 열림"); // 서버가 연결되면 서버 열림 출력

            while (true)
            {
                try
                {
                    client = server.AcceptTcpClient(); // Client 소켓 접속 허용

                    handleClient h_client = new handleClient();
                    h_client.OnReceived += new handleClient.MessageDisplayHandler(DisplayText);
                    h_client.startClient(client);
                }
                catch (SocketException se)
                {
                    AddClient(listBox1, "클라이언트 접속 실패");
                }
                catch (Exception ex)
                {
                    //Trace.WriteLine(string.Format("InitSocket - Exception : {0}", ex.Message));
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null)
            {
                client.Close();
                client = null;
            }

            if (server != null)
            {
                server.Stop();
                server = null;
            }
        }

        private void DisplayText(string text)
        {
            if (listBox1.InvokeRequired)
            {
                listBox1.BeginInvoke(new MethodInvoker(delegate
                {
                    listBox1.Items.Add(text);
                }));
            }
        }

        void AddClient(Control ctrl, string s) // 클라이언트 접속 알림
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    listBox1.Items.Add(s);

                }));
            }
        }

        // ******************************** 통신코드 ********************************

        //메뉴추가
        private void AddMenu_Click(object sender, EventArgs e)
        {
            AddMenu addMenu = new AddMenu(mainInfo, sideInfo, beverageInfo);
            addMenu.Show();
        }
        //메뉴수정
        private void EditMenu_Click(object sender, EventArgs e)
        {
            EditMenu editMenu = new EditMenu(mainInfo, sideInfo, beverageInfo);
            editMenu.Show();
        }

        //메뉴사진을 불러오는 함수
        private void replaceImg(MenuInfo currentMenu, string currentpath)
        {
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            string fileName;
            string fileExt;
            string addFile;

            currentMenu.menuimg.Images.Clear();
            int index = currentMenu.menu.Items.Count;

            for (int i = 0; i < index; i++)
            {
                fileName = i.ToString();

                DirectoryInfo dir = new DirectoryInfo(currentpath);
                FileInfo[] files = dir.GetFiles(i + ".*");

                if (files.Length > 0)
                {
                    fileExt = files[0].Extension;
                    fileName += fileExt;
                    addFile = Path.Combine(currentpath, fileName);
                    currentMenu.menuimg.Images.Add(Image.FromFile(addFile));
                }
                else
                {
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.Items[0]);
        }
    }
}
