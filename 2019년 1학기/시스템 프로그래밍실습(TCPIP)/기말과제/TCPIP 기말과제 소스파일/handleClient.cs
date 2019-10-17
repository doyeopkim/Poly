using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace BonResto
{
    class handleClient
    {
        TcpClient clientSocket;
        int sendmenu = 0;

        public void startClient(TcpClient ClientSocket)
        {
            this.clientSocket = ClientSocket;

            Thread t_hanlder = new Thread(startBusiness);
            t_hanlder.IsBackground = true;
            t_hanlder.Start();
        }

        public delegate void MessageDisplayHandler(string text);
        public event MessageDisplayHandler OnReceived;

        public delegate void CalculateClientCounter();
        public event CalculateClientCounter OnCalculated;

        private void startBusiness()
        {
            NetworkStream stream = null;
            try
            {
                byte[] buffer = new byte[1024];
                string msg = string.Empty;
                int bytes = 0;

                int i = 0, j =0, k = 0; // 저장된 메뉴가 몇개인지 셀 변수
                
                //메인 메뉴 경로
                string Path = Application.StartupPath + "\\MainMenu";
                string Path1 = Application.StartupPath + "\\SideMenu";
                string Path2 = Application.StartupPath + "\\BeverageMenu";

                //메인 메뉴
                string[] m_img = m_img = Enumerable.Repeat(Application.StartupPath + "\\MainMenu\\", 1000).ToArray(); // 이미지 경로를 저장할 변수
                string[] m_info = System.IO.File.ReadAllLines(Path + "\\MainMenu.txt", Encoding.Default);
                //사이드 메뉴
                string[] s_img = s_img = Enumerable.Repeat(Application.StartupPath + "\\SideMenu\\", 1000).ToArray();
                string[] s_info = System.IO.File.ReadAllLines(Path1 + "\\SideMenu.txt", Encoding.Default);
                // 음료 메뉴
                string[] b_img = b_img = Enumerable.Repeat(Application.StartupPath + "\\BeverageMenu\\", 1000).ToArray();
                string[] b_info = System.IO.File.ReadAllLines(Path2 + "\\BeverageMenu.txt", Encoding.Default);

                while (true) // 받은 메시지 출력
                {
                    stream = clientSocket.GetStream();

                    if (sendmenu == 0)
                    {
                        //해당 폴더가 존재하는지 확인
                        if (System.IO.Directory.Exists(Path))
                        {
                            //DirectoryInfo 객체 생성
                            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Path);
                            //해당 폴더에 있는 파일이름을 출력
                            foreach (var item in di.GetFiles())
                            {
                                m_img[i] += item.ToString();
                                i++;
                            }
                        }
                        i--; // 텍스트파일까지 불러와서 1감소


                        for (int s = 0; s < i; s++) // 메뉴목록 전송
                        {
                            byte[] sbuffer = Encoding.Unicode.GetBytes("main" + '\x01' + m_img[s] + '\x01' + m_info[s] + "$"); // 순서대로 식별 이미지경로, 메뉴이름, 가격
                            stream.Write(sbuffer, 0, sbuffer.Length);
                            stream.Flush();
                        }
                        // 여기까지 메인 메뉴 전송****************************************************************************************************************************

                        if (System.IO.Directory.Exists(Path1))
                        {
                            //DirectoryInfo 객체 생성
                            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Path1);
                            //해당 폴더에 있는 파일이름을 출력
                            foreach (var item in di.GetFiles())
                            {
                                s_img[j] += item.ToString();
                                j++;
                            }
                        }
                        j--; // 텍스트파일까지 불러와서 1감소


                        for (int s = 0; s < j; s++) // 메뉴목록 전송
                        {
                            byte[] sbuffer = Encoding.Unicode.GetBytes("side" + '\x01' + s_img[s] + '\x01' + s_info[s] + "$"); // 순서대로 식별 이미지경로, 메뉴이름, 가격
                            stream.Write(sbuffer, 0, sbuffer.Length);
                            stream.Flush();
                        }

                        // 여기까지 사이드 메뉴 전송****************************************************************************************************************************

                        if (System.IO.Directory.Exists(Path2))
                        {
                            //DirectoryInfo 객체 생성
                            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Path2);
                            //해당 폴더에 있는 파일이름을 출력
                            foreach (var item in di.GetFiles())
                            {
                                b_img[k] += item.ToString();
                                k++;
                            }
                        }
                        k--; // 텍스트파일까지 불러와서 1감소


                        for (int s = 0; s < k; s++) // 메뉴목록 전송
                        {
                            byte[] sbuffer = Encoding.Unicode.GetBytes("beve" + '\x01' + b_img[s] + '\x01' + b_info[s] + "$"); // 순서대로 식별 이미지경로, 메뉴이름, 가격
                            stream.Write(sbuffer, 0, sbuffer.Length);
                            stream.Flush();
                        }
                        sendmenu = 1;
                    }

                    // 여기까지 음료 메뉴 전송****************************************************************************************************************************

                    // 여기까지 메뉴목록 정보 전송


                    // 아래로 주문목록 받기

                    stream = clientSocket.GetStream();
                    bytes = stream.Read(buffer, 0, buffer.Length);
                    msg = Encoding.Unicode.GetString(buffer, 0, bytes);
                    msg = msg.Substring(0, msg.IndexOf("$"));
                    string[] addmsg = msg.Split('\x01');

                    if (OnReceived != null && addmsg[0] != "require") // 메뉴받기
                        OnReceived(addmsg[0]);
                    if (addmsg[0] != "require" && addmsg[1] != "")
                        OnReceived("요청사항 : " + addmsg[1]);
                    if (addmsg[0] == "require")
                    {
                        OnReceived(addmsg[1]);
                    }
                    
                }
            }

            catch (SocketException se)
            {
                //Trace.WriteLine(string.Format("doChat - SocketException : {0}", se.Message));

                if (clientSocket != null)
                {
                    clientSocket.Close();
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                //Trace.WriteLine(string.Format("doChat - Exception : {0}", ex.Message));

                if (clientSocket != null)
                {
                    clientSocket.Close();
                    stream.Close();
                }
            }
        }
    }
}
