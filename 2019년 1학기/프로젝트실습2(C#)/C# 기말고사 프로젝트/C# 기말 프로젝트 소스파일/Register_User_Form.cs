using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

// 해야할 것 : 아이디 중복체크

namespace Jugal
{

    public partial class Register_User_Form : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=manlesslibrary;Uid=root;Pwd=1234; CharSet=utf8"); // DB 접속

        public Register_User_Form()
        {
            InitializeComponent();
        }

        private void user_Register_button_Click(object sender, EventArgs e)
        {
            // 어떤 항목이 입력되지 않았다면
            if (user_name_textBox.Text == "" || user_id_textBox.Text == "" || user_pw_textBox.Text == "" || checkpw_textBox.Text == "" || user_hp_textBox.Text == "")
            {
                MessageBox.Show("모든 항목을 입력 해 주세요!", "오류");
            }
            // 비밀번호 재입력이 일치하지 않다면
            else if (user_pw_textBox.Text != checkpw_textBox.Text)
            {
                MessageBox.Show("비밀번호를 다시 확인 해 주세요!", "비밀번호 확인");
            }
            // 모든 조건이 맞다면 아이디 저장
            else
            {
                string duplQuery = "SELECT user_id FROM user_register WHERE user_id = '" + user_id_textBox.Text + "'";
                string insertQuery = "INSERT INTO user_register VALUES('" + user_name_textBox.Text + "', '" + user_id_textBox.Text + "', '" + user_pw_textBox.Text + "' , '" + user_hp_textBox.Text + "')";
                // 이름, 아이디, 비밀번호, 연락처를 DB에 저장

                connection.Open();
                MySqlCommand cmd = new MySqlCommand(duplQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                // 아이디가 없다면
                if (!reader.Read())
                {
                    reader.Close();
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);

                    try//예외 처리
                    {
                        // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("정상적으로 회원가입이 되었습니다.", "가입 완료");
                            this.Visible = false;
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
                    }
                }
                else
                {
                    MessageBox.Show("이미 존재하는 ID 입니다.");
                    connection.Close();
                }
            }
        }
    }
}