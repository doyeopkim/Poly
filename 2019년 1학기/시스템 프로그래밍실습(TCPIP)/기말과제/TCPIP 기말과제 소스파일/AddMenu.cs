using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonResto
{
    public partial class AddMenu : Form
    {
        string m_name; //메뉴이름
        string m_price; //메뉴가격
        int menuType;

        //메인에서 보낸 메뉴객체와 연결할 객체
        MenuInfo main;
        MenuInfo side;
        MenuInfo beverage;

        public AddMenu(MenuInfo maininfo, MenuInfo sideinfo, MenuInfo beverageinfo)
        {
            InitializeComponent();
            main = maininfo;
            side = sideinfo;
            beverage = beverageinfo;
        }

        //추가버튼을 눌렸을때
        private void AddMemu_Click(object sender, EventArgs e)
        {
            m_name = nameBox.Text;
            m_price = priceBox.Text;
            if (imgPath.Text != "")
            {
                if (menuType == 1)
                {
                    main.addMenu(m_name, m_price, imgPath.Text);
                    string fileName = (main.menu.Items.Count - 1).ToString();
                    main.FileCopy(imgPath.Text, Application.StartupPath + "\\MainMenu", fileName);
                    MenuManage.MenuSave(main, Application.StartupPath + "\\MainMenu\\MainMenu.txt");
                }
                else if (menuType == 2)
                {
                    side.addMenu(m_name, m_price, imgPath.Text);
                    string fileName = (side.menu.Items.Count - 1).ToString();
                    side.FileCopy(imgPath.Text, Application.StartupPath + "\\SideMenu", fileName);
                    MenuManage.MenuSave(side, Application.StartupPath + "\\SideMenu\\SideMenu.txt");
                }
                else if (menuType == 3)
                {
                    beverage.addMenu(m_name, m_price, imgPath.Text);
                    string fileName = (beverage.menu.Items.Count - 1).ToString();
                    beverage.FileCopy(imgPath.Text, Application.StartupPath + "\\BeverageMenu", fileName);
                    MenuManage.MenuSave(beverage, Application.StartupPath + "\\BeverageMenu\\BeverageMenu.txt");
                }

                MessageBox.Show("추가되었습니다.");
                imgPath.Text = "";
                this.Close();
            }
            else
            {
                MessageBox.Show("사진을 선택해주세요");
                return;
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

        //추가할 메뉴의 종류 선택
        private void mainRB_CheckedChanged(object sender, EventArgs e)
        {
            menuType = 1;
        }
        private void sideRB_CheckedChanged(object sender, EventArgs e)
        {
            menuType = 2;
        }
        private void bRB_CheckedChanged(object sender, EventArgs e)
        {
            menuType = 3;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
