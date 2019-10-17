using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jugal
{
    public partial class Search_Idpw_Form : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=manlesslibrary;Uid=root;Pwd=1234; CharSet=utf8"); // DB 접속

        public Search_Idpw_Form()
        {
            InitializeComponent();
        }

        private void search_idpw_button_Click(object sender, EventArgs e)
        {
            // 어떤 항목이 입력되지 않았다면
            if (user_name_textBox.Text == "" || user_hp_textBox.Text == "")
            {
                MessageBox.Show("모든 항목을 입력 해 주세요!", "오류");
            }

            else
            {
                string search_id = "", search_pw = "";
                
                try
                {
                    string serarch_user_idpw = "SELECT user_id, user_pw FROM user_register WHERE user_name = '" + user_name_textBox.Text + "' AND user_hp = '" + user_hp_textBox.Text + "'";
                    connection.Open();
                    MySqlDataReader reader = null;
                    MySqlCommand command = new MySqlCommand(serarch_user_idpw, connection);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        search_id = (string)reader["user_id"];
                        search_pw = (string)reader["user_pw"];
                    }
                    reader.Close();
                    if (search_id != "" && search_pw != "")
                    {
                        MessageBox.Show("아이디는 " + search_id + " 비밀번호는 " + search_pw + " 입니다.", "ID,PW 찾기");
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("계정이 없거나 이름 또는 연락처가 잘못 되었습니다.", "ID,PW 찾기 실패");
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
    }
}
