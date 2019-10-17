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
    public partial class Book_Rental_List_Form : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=manlesslibrary;Uid=root;Pwd=1234; CharSet=utf8"); // DB 접속

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
                    listitem.SubItems.Add(dr["book_amount"].ToString());
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
        static string id = "LoginID"; // static 변수를 이용하여 로그인 한 아이디로 수정

        public Book_Rental_List_Form()
        {
            InitializeComponent();
        }

        private void Rental_book_button_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection rentalbook = this.User_Book_List_listView.SelectedItems;

            string book_name = "", book_author = "", book_publisher = "", book_code = "", book_categorize = ""; // 리스트뷰의 선택된 값을 임시로 저장하고 있을 변수 

            foreach (ListViewItem item in rentalbook) // 지울 책이름과 작가명을 변수에 저장
            {
                book_name = (item.SubItems[0].Text);
                book_author = (item.SubItems[1].Text);
                book_publisher = (item.SubItems[2].Text);
                book_code = (item.SubItems[3].Text);
                book_categorize = (item.SubItems[4].Text);
            }

            int popular = 0, amount = 0;

            // 선택된 값 저장 -> 인서트 문에 담기
            string book_rental_Query = "INSERT INTO book_rental(book_name, book_author, book_publisher, book_code, book_userid, book_userhp, book_deadline) VALUES('" + book_name + "', '" + book_author + "', '" + book_publisher + "', '" + book_code + "', '" + id + "', 'userhp', '" + DateTime.Now.ToString("yyyy.MM.dd") + "')";
            string book_popluar_Query = "SELECT book_amount, book_popular FROM book_register WHERE book_name = '" + book_name + "' AND book_code = '" + book_code + "'"; 

            // 책 정보를 DB에 저장
            connection.Open();
            MySqlCommand command = new MySqlCommand(book_rental_Query, connection);

            MySqlDataReader reader = null;
            MySqlCommand cmd = new MySqlCommand(book_popluar_Query, connection);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                amount = (int)reader["book_amount"];
                popular = (int)reader["book_popular"];
            }
            reader.Close();

            amount--; // 선택된 책의 amount 값(수량)을 1 감소
            popular++; // 선택된 책의 popular 값(대여)을 1 증가

            if (amount <= -1) // 책이 0개라면
            {
                MessageBox.Show("책 보유량이 0 입니다!", "대여 실패");
                connection.Close();
            }

            else
            {
                string book_register_update_Query = "UPDATE book_register SET book_amount = '" + amount.ToString() + "', book_popular = '" + popular.ToString() + "' WHERE book_name = '" + book_name + "' AND book_code = '" + book_code + "'";
                string book_present_amount_update_Query = "UPDATE book_present SET book_amount = '" + amount.ToString() + "' WHERE book_name = '" + book_name + "' AND book_code = '" + book_code + "'";

                MySqlCommand register_update = new MySqlCommand(book_register_update_Query, connection);
                MySqlCommand present_update = new MySqlCommand(book_present_amount_update_Query, connection);

                try//예외 처리
                {
                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                    if (command.ExecuteNonQuery() == 1 && register_update.ExecuteNonQuery() == 1 && present_update.ExecuteNonQuery() == 1)
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
                    Book_Rental_List_View("SELECT * FROM book_present");
                }
            }
        }

        private void Search_book_button_Click(object sender, EventArgs e)
        {
            if (Book_Search_textBox.Text != "") // 텍스트 박스에 입력된 값이 없는게 아니라면
            {
                Book_Rental_List_View("SELECT * FROM book_present WHERE book_name LIKE '%" + Book_Search_textBox.Text + "%'");
            }
            else
            {
                MessageBox.Show("값을 입력해 주세요!", "검색 오류");
            }
        }

        private void User_Book_List_listView_SelectedIndexChanged(object sender, EventArgs e)
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

        // 라디오 버튼 이벤트 처리

        private void All_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Book_Rental_List_View("SELECT * FROM book_present");
        }

        private void Society_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Book_Rental_List_View("SELECT * FROM book_present WHERE book_categorize = 1");
        }

        private void Science_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Book_Rental_List_View("SELECT * FROM book_present WHERE book_categorize = 2");
        }

        private void Art_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Book_Rental_List_View("SELECT * FROM book_present WHERE book_categorize = 3");
        }

        private void ForeignL_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Book_Rental_List_View("SELECT * FROM book_present WHERE book_categorize = 4");
        }

        private void Novel_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Book_Rental_List_View("SELECT * FROM book_present WHERE book_categorize = 5");
        }

        private void Comic_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Book_Rental_List_View("SELECT * FROM book_present WHERE book_categorize = 6");
        }

        private void Computer_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Book_Rental_List_View("SELECT * FROM book_present WHERE book_categorize = 7");
        }

        private void ForeignB_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Book_Rental_List_View("SELECT * FROM book_present WHERE book_categorize = 8");
        }
    }
}
