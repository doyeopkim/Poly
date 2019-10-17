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
    public partial class Register_Book_Form : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=manlesslibrary;Uid=root;Pwd=1234;CharSet=utf8;"); // DB 접속

        public Register_Book_Form()
        {
            InitializeComponent();
        }

        private void book_register_button_Click(object sender, EventArgs e)
        {
            // 어떤 항목이 입력되지 않았다면
            if (book_name_textBox.Text == "" || book_author_textBox.Text == "" || book_publisher_textBox.Text == "" || book_code_textBox.Text == "" || book_amount_textBox.Text == "" || book_categorize_textBox.Text == "" || book_info_textBox.Text == "")
            {
                MessageBox.Show("모든 항목을 입력 해 주세요!", "오류");
            }
            
            // 모든 조건이 맞다면 책 정보 저장
            else
            {
                string duplQuery = "SELECT book_amount, book_pamount FROM book_register WHERE book_code = '" + book_code_textBox.Text + "'";
                int amount = 0, pamount = 0;
                string book_register_Query = "INSERT INTO book_register VALUES('" + book_name_textBox.Text + "', '" + book_author_textBox.Text + "', '" + book_publisher_textBox.Text + "', '" + book_code_textBox.Text + "' , '" + book_categorize_textBox.Text + "', '" + book_amount_textBox.Text + "', '" + book_amount_textBox.Text + "', '" + book_info_textBox.Text + "', 0, NULL)";
                // 책 정보를 DB에 저장
                connection.Open();

                MySqlDataReader reader = null;
                MySqlCommand cmd = new MySqlCommand(duplQuery, connection);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    amount = (int)reader["book_amount"];
                    pamount = (int)reader["book_pamount"];
                }
                reader.Close();

                if (amount != 0)
                {
                    string amount_update_Query = "UPDATE book_register SET book_amount = " + (amount + int.Parse(book_amount_textBox.Text)) + ", book_pamount = " + (pamount + int.Parse(book_amount_textBox.Text)) + " WHERE book_code = '" + book_code_textBox.Text + "'";
                    MySqlCommand cd = new MySqlCommand(amount_update_Query, connection);

                    if (cd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("이미 있는 책 정보에 수량에" + book_amount_textBox.Text + "개 추가되었습다.", "등록 완료");
                        book_name_textBox.Clear();
                        book_author_textBox.Clear();
                        book_publisher_textBox.Clear();
                        book_code_textBox.Clear();
                        book_amount_textBox.Clear();
                        book_categorize_textBox.Clear();
                        book_info_textBox.Clear();

                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("오류", "오류");
                        connection.Close();
                    }
                }
                else
                {
                    MySqlCommand command = new MySqlCommand(book_register_Query, connection);

                    try//예외 처리
                    {
                        // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("정상적으로 책 정보가 등록되었습다.", "등록 완료");
                            book_name_textBox.Clear();
                            book_author_textBox.Clear();
                            book_publisher_textBox.Clear();
                            book_code_textBox.Clear();
                            book_amount_textBox.Clear();
                            book_categorize_textBox.Clear();
                            book_info_textBox.Clear();
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            book_categorize_textBox.Text = "사회학";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            book_categorize_textBox.Text = "과학";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            book_categorize_textBox.Text = "예술";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            book_categorize_textBox.Text = "외국어";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            book_categorize_textBox.Text = "소설";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            book_categorize_textBox.Text = "만화";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            book_categorize_textBox.Text = "컴퓨터";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            book_categorize_textBox.Text = "외국서적";
        }
    }
}
