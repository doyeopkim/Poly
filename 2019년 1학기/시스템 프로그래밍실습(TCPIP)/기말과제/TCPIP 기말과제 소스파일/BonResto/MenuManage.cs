using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonResto
{
    class MenuManage
    {
        //메뉴파일을 불러오는 함수
        public static void MenuLoad(MenuInfo currentmenu, string currentpath)
        {
            ListView listView;
            listView = currentmenu.menu;
            Dictionary<string, string> Msg = new Dictionary<string, string>(); // 문자열 키를 인덱스로 사용하는 테이블을 생성하기 위해 선언

            String MessageListFile = currentpath; // 메세지가 들어 있는 파일을 지정

            if (File.Exists(MessageListFile)) // 파일 존재 유무, 있으면 처리한다.
            {
                FileStream MessageFile = File.Open(MessageListFile, FileMode.OpenOrCreate, FileAccess.Read); // 파일을 열되 없다면 생성하고 권한은 읽기 전용으로 생성
                StreamReader MessageStream = new StreamReader(MessageFile, Encoding.Default); // 스트림 생성

                MessageStream.BaseStream.Seek(0, SeekOrigin.Begin); // 파일을 읽어가기 시작한다.

                while (MessageStream.Peek() > -1)
                {
                    String ReadLine = MessageStream.ReadLine(); // String형 변수에 파일 내의 한 줄을 읽어온다.
                    int SplitIndex = ReadLine.IndexOf("\t"); // Tab을 구분자로 두고 구분자를 기준으로 잘라내기 위해 인덱스를 얻는다.
                    if (SplitIndex == 0 || SplitIndex == -1 || ReadLine.StartsWith(";")) { continue; } // 맨 첫문자가 구분자이거나 또는 없거나, ; 로 시작하는 경우 스킵
                    Msg[ReadLine.Substring(0, SplitIndex).ToLower()] = ReadLine.Substring(SplitIndex + 1); // 테이블에 구분자 전의 값을 키, 후를 값으로 리스트를 생성한다.
                }

                MessageStream.Close();

                int i = 0;

                foreach (KeyValuePair<string, string> Message in Msg)
                {
                    listView.Items.Add(Message.Key);
                    listView.Items[i].Tag = Message.Value;
                    i++;
                }
            }
            else // 파일이 없으면 찾을 수 없다는 메세지 출력
            {
            }
        }

        //메뉴정보를 파일에 저장하는 함수
        public static void MenuSave(MenuInfo currentmenu, string currentpath)
        {
            ListView listView;
            listView = currentmenu.menu;
            StreamWriter sw = new StreamWriter(new FileStream(currentpath, FileMode.Create), Encoding.Default);
            for (int i = 0; i < listView.Items.Count; i++)
                sw.WriteLine("{0}\t{1}", listView.Items[i].Text, listView.Items[i].Tag.ToString());
            sw.Close();
        }
    }
}
