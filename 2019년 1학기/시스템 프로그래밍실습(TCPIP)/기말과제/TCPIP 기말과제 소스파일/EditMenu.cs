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

namespace BonResto
{
    public partial class EditMenu : Form
    {
        //메인에서 보낸 메뉴객체와 연결할 객체
        MenuInfo main;
        MenuInfo side;
        MenuInfo beverage;

        string m_name;
        string m_price;
        int menuType = 1;

        public EditMenu(MenuInfo maininfo, MenuInfo sideinfo, MenuInfo beverageinfo)
        {
            InitializeComponent();
            main = maininfo;
            side = sideinfo;
            beverage = beverageinfo;

            //창이 띄워진 후 리스트를 주메뉴로 표시
            listView1.Clear();
            CopyListView(main.menu, listView1);
            listView1.LargeImageList = main.menuimg;
        }

        //메뉴종류 선택
        private void MainMenu_Click(object sender, EventArgs e)
        {
            menuType = 1;
            mType.Text = "주메뉴";
            listView1.Clear();
            CopyListView(main.menu, listView1);
            listView1.LargeImageList = main.menuimg;
        }

        private void SideMenu_Click(object sender, EventArgs e)
        {
            menuType = 2;
            mType.Text = "사이드메뉴";
            listView1.Clear();
            CopyListView(side.menu, listView1);
            listView1.LargeImageList = side.menuimg;
        }

        private void Beverage_Click(object sender, EventArgs e)
        {
            menuType = 3;
            mType.Text = "음 료";
            listView1.Clear();
            CopyListView(beverage.menu, listView1);
            listView1.LargeImageList = beverage.menuimg;
        }

        //수정버튼
        private void edit_Click(object sender, EventArgs e)
        {
            m_name = nameBox.Text;
            m_price = priceBox.Text;

            int indexnum;
            indexnum = listView1.FocusedItem.Index;

            //사진까지 교체할때
            if (imgPath.Text != "")
            {
                if (menuType == 1)
                {
                    main.menu.Items[indexnum].Text = m_name;
                    main.menu.Items[indexnum].Tag = m_price;
                    FileCopy(imgPath.Text, Application.StartupPath + "\\MainMenu", indexnum.ToString());
                    replaceImg(main, Application.StartupPath + "\\MainMenu\\");
                    MenuManage.MenuSave(main, Application.StartupPath + "\\MainMenu\\MainMenu.txt");

                    listView1.Clear();
                    CopyListView(main.menu, listView1);
                }
                else if (menuType == 2)
                {
                    side.menu.Items[indexnum].Text = m_name;
                    side.menu.Items[indexnum].Tag = m_price;
                    FileCopy(imgPath.Text, Application.StartupPath + "\\SideMenu", indexnum.ToString());
                    replaceImg(side, Application.StartupPath + "\\SideMenu");
                    MenuManage.MenuSave(side, Application.StartupPath + "\\SideMenu\\SideMenu.txt");

                    listView1.Clear();
                    CopyListView(side.menu, listView1);
                }
                else if (menuType == 3)
                {
                    beverage.menu.Items[indexnum].Text = m_name;
                    beverage.menu.Items[indexnum].Tag = m_price;
                    FileCopy(imgPath.Text, Application.StartupPath + "\\BeverageMenu", indexnum.ToString());
                    replaceImg(beverage, Application.StartupPath + "\\BeverageMenu");
                    MenuManage.MenuSave(beverage, Application.StartupPath + "\\BeverageMenu\\BeverageMenu.txt");

                    listView1.Clear();
                    CopyListView(beverage.menu, listView1);
                }
                MessageBox.Show("메뉴가 수정되었습니다.");
                imgPath.Text = "";
            }

            //사진을 안넣고 수정했을때
            else
            {
                if (menuType == 1)
                {
                    main.menu.Items[indexnum].Text = m_name;
                    main.menu.Items[indexnum].Tag = m_price;
                    replaceImg(main, Application.StartupPath + "\\MainMenu\\");
                    MenuManage.MenuSave(main, Application.StartupPath + "\\MainMenu\\MainMenu.txt");

                    listView1.Clear();
                    CopyListView(main.menu, listView1);
                }
                else if (menuType == 2)
                {
                    side.menu.Items[indexnum].Text = m_name;
                    side.menu.Items[indexnum].Tag = m_price;
                    replaceImg(side, Application.StartupPath + "\\SideMenu");
                    MenuManage.MenuSave(side, Application.StartupPath + "\\SideMenu\\SideMenu.txt");

                    listView1.Clear();
                    CopyListView(side.menu, listView1);
                }
                else if (menuType == 3)
                {
                    beverage.menu.Items[indexnum].Text = m_name;
                    beverage.menu.Items[indexnum].Tag = m_price;
                    replaceImg(beverage, Application.StartupPath + "\\BeverageMenu");
                    MenuManage.MenuSave(beverage, Application.StartupPath + "\\BeverageMenu\\BeverageMenu.txt");

                    listView1.Clear();
                    CopyListView(beverage.menu, listView1);
                }
                MessageBox.Show("메뉴가 수정되었습니다.");
                imgPath.Text = "";
            }
        }

        //삭제버튼
        private void delete_Click(object sender, EventArgs e)
        {
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            m_name = nameBox.Text;
            m_price = priceBox.Text;

            int indexnum;
            string deleteFile;
            string fileExt;
            indexnum = listView1.FocusedItem.Index;

            if (menuType == 1)
            {
                deleteFile = indexnum.ToString();
                main.menu.Items[indexnum].Text = m_name;
                main.menu.Items[indexnum].Tag = m_price;
                main.menu.Items[indexnum].Remove();

                DirectoryInfo dir = new DirectoryInfo(Application.StartupPath + "\\MainMenu");
                FileInfo[] files = dir.GetFiles(indexnum + ".*");
                if (files.Length > 0)
                {
                    fileExt = files[0].Extension;
                    deleteFile += fileExt;
                    deleteFile = Path.Combine(Application.StartupPath + "\\MainMenu", deleteFile);
                }
                File.Delete(deleteFile);

                deleteImg(main, Application.StartupPath + "\\MainMenu");
                MenuManage.MenuSave(main, Application.StartupPath + "\\MainMenu\\MainMenu.txt");

                listView1.Clear();
                CopyListView(main.menu, listView1);
            }
            else if (menuType == 2)
            {
                deleteFile = indexnum.ToString();
                side.menu.Items[indexnum].Text = m_name;
                side.menu.Items[indexnum].Tag = m_price;
                side.menu.Items[indexnum].Remove();

                DirectoryInfo dir = new DirectoryInfo(Application.StartupPath + "\\SideMenu");
                FileInfo[] files = dir.GetFiles(indexnum + ".*");
                if (files.Length > 0)
                {
                    fileExt = files[0].Extension;
                    deleteFile += fileExt;
                    deleteFile = Path.Combine(Application.StartupPath + "\\SideMenu", deleteFile);
                }
                File.Delete(deleteFile);

                deleteImg(side, Application.StartupPath + "\\SideMenu");
                MenuManage.MenuSave(side, Application.StartupPath + "\\SideMenu\\SideMenu.txt");

                listView1.Clear();
                CopyListView(side.menu, listView1);
            }
            else if (menuType == 3)
            {
                deleteFile = indexnum.ToString();
                beverage.menu.Items[indexnum].Text = m_name;
                beverage.menu.Items[indexnum].Tag = m_price;
                beverage.menu.Items[indexnum].Remove();

                DirectoryInfo dir = new DirectoryInfo(Application.StartupPath + "\\BeverageMenu");
                FileInfo[] files = dir.GetFiles(indexnum + ".*");
                if (files.Length > 0)
                {
                    fileExt = files[0].Extension;
                    deleteFile += fileExt;
                    deleteFile = Path.Combine(Application.StartupPath + "\\BeverageMenu", deleteFile);
                }
                File.Delete(deleteFile);

                deleteImg(beverage, Application.StartupPath + "\\BeverageMenu");
                MenuManage.MenuSave(beverage, Application.StartupPath + "\\BeverageMenu\\BeverageMenu.txt");

                listView1.Clear();
                CopyListView(beverage.menu, listView1);
            }
        }

        //폼이 로드될때
        private void EditMenu_Load(object sender, EventArgs e)
        {
            MMPanel.Dock = DockStyle.Left;
            MenuInfo.Dock = DockStyle.Right;
            this.Size = new Size(600, 420);
        }

        //해당 메뉴 종류의 리스트뷰를 복사해온다
        private static void CopyListView(ListView source, ListView target)
        {
            for (int i = 0; i < source.Items.Count; i++)
            {
                target.Items.Add(source.Items[i].Text);
                target.Items[i].Tag = source.Items[i].Tag;
                target.Items[i].ImageIndex = i;
            }
        }

        //이미지파일을 추가하기위한 정보
        string m_splitter = "'\\'";
        string m_fName = string.Empty;
        string[] m_split = null;

        //openFileDialog로 이미지파일 추가
        private void FindImg_Click(object sender, EventArgs e)
        {
            char[] delimeter = m_splitter.ToCharArray();

            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.ShowDialog();

            imgPath.Text = openFileDialog1.FileName;
            pictureBox1.ImageLocation = openFileDialog1.FileName;

            m_split = imgPath.Text.Split(delimeter);
            int limit = m_split.Length;

            m_fName = m_split[limit - 1].ToString();
        }

        //사진을 수정할때 파일을 복사해오는 함수
        private string FileCopy(string sourceFile, string destPath, string fileName)
        {
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            string filePath = Path.GetDirectoryName(sourceFile);  // 파일 경로
            string fileExt = Path.GetExtension(sourceFile); //파일 확장자
            fileName += fileExt;
            string newFile = Path.Combine(destPath, fileName);
            if (File.Exists(newFile))  // 파일의 존재 유무 확인 : 파일이 존재하면
            {
                string message = "사진을 교체하여 수정하시겠습니까?";
                DialogResult dialogResult = MessageBox.Show(message, "알림", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    File.Delete(newFile);  // 존재하는 파일 삭제
                    File.Copy(sourceFile, newFile);
                }
                else
                {
                    MessageBox.Show("수정를 취소하였습니다");
                }
            }
            else   // 파일의 존재하지 않으면    

            {
                File.Copy(sourceFile, newFile);
            }
            return newFile;
        }

        //제품을 선택할때 정보를 표시
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexnum;
            indexnum = listView1.FocusedItem.Index;
            nameBox.Text = listView1.Items[indexnum].Text;
            priceBox.Text = listView1.Items[indexnum].Tag.ToString();
        }

        //사진파일 교체 함수
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

        //사진파일 삭제시 파일이름 재정렬 함수
        private void deleteImg(MenuInfo currentMenu, string currentpath)
        {
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            string oldName;
            string fileExt;
            string oldFile;
            string nextName;
            string nextFile;

            currentMenu.menuimg.Images.Clear();
            int index = currentMenu.menu.Items.Count;

            for (int i = 0; i < index; i++)
            {
                oldName = i.ToString();

                DirectoryInfo dir = new DirectoryInfo(currentpath);
                FileInfo[] files = dir.GetFiles(i + ".*");

                if (files.Length > 0) //파일이 있으면
                {
                    fileExt = files[0].Extension;
                    oldName += fileExt;
                    oldFile = Path.Combine(currentpath, oldName);
                    currentMenu.menuimg.Images.Add(Image.FromFile(oldFile));
                }

                else //파일이 없으면
                {
                    nextName = (i + 1).ToString();

                    files = dir.GetFiles((i + 1) + ".*");
                    if (files.Length > 0)
                    {
                        fileExt = files[0].Extension;
                        nextName += fileExt;
                        oldName += fileExt;
                    }
                    else
                        break;

                    nextFile = Path.Combine(currentpath, nextName);
                    oldFile = Path.Combine(currentpath, oldName);

                    if (File.Exists(oldFile))  // 파일의 존재 유무 확인 : 파일이 존재하면
                    {
                        break;
                    }
                    else   // 파일의 존재하지 않으면    
                    {
                        if (File.Exists(nextFile))
                        {
                            File.Copy(nextFile, oldFile);
                            File.Delete(nextFile);
                            currentMenu.menuimg.Images.Add(Image.FromFile(oldFile));
                        }
                        else
                            break;
                    }
                }
            }
        }

        private void MType_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
