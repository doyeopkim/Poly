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

namespace Jugal
{
    public partial class Chainge_Member_Info : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=manlesslibrary;Uid=root;Pwd=1234; CharSet=utf8"); // DB 접속

        public Chainge_Member_Info()
        {
            InitializeComponent();
        }

        static string LoginId = Main_Form.LoginId();

        private void Chainge_User_Info_button_Click(object sender, EventArgs e) // 정보 변경 버튼
        {
            if (user_pw_textBox.Text != "" && checkpw_textBox.Text != "" && user_hp_textBox.Text == "") // 비밀번호를 입력하고 연락처를 입력하지 않았다면
            {
                if (user_pw_textBox.Text == checkpw_textBox.Text && user_hp_textBox.Text == "")
                {
                    string change_Query = "UPDATE user_register SET user_pw = '" + user_pw_textBox.Text + "' WHERE user_id = '" + LoginId + "'";

                    connection.Open();
                    MySqlCommand command = new MySqlCommand(change_Query, connection);

                    try//예외 처리
                    {
                        // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                        if (command.ExecuteNonQuery() == 1)
                        {
                            user_pw_textBox.Clear();
                            checkpw_textBox.Clear();
                            user_hp_textBox.Clear();
                            MessageBox.Show("정상적으로 정보가 변경 되었습니다.", "변경 완료");
                            Close();
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
                else if (user_pw_textBox.Text == checkpw_textBox.Text && user_hp_textBox.Text != "")
                {
                    string change_Query = "UPDATE user_register SET user_pw = '" + user_pw_textBox.Text + "', user_hp = '" + user_hp_textBox.Text + "' WHERE user_id = '" + LoginId + "'";

                    connection.Open();
                    MySqlCommand command = new MySqlCommand(change_Query, connection);

                    try//예외 처리
                    {
                        // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                        if (command.ExecuteNonQuery() == 1)
                        {
                            user_pw_textBox.Clear();
                            checkpw_textBox.Clear();
                            user_hp_textBox.Clear();
                            MessageBox.Show("정상적으로 정보가 변경 되었습니다.", "변경 완료");
                            Close();
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
                    MessageBox.Show("비밀번호가 같지 않습니다.", "변경 실패");
                }
            }
            else
            {
                MessageBox.Show("필요한 항목을 입력 해 주세요.", "변경 실패");
            }
        }

        private void Member_Withdrawal_button_Click(object sender, EventArgs e)
        {
            string member_withdrawal_Query = "DELETE FROM user_register WHERE user_id = '" + LoginId + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(member_withdrawal_Query, connection);

            try//예외 처리
            {
                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(LoginId + "님 이용해 주셔서 감사했습니다." + "\n" + "프로그램을 종료합니다.", "탈퇴 완료");
                    Close();
                    Application.Exit();
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
    }
}
