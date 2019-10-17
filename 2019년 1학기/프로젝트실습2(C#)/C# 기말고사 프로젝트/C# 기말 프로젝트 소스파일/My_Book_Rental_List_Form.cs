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
    public partial class My_Book_Rental_List_Form : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=manlesslibrary;Uid=root;Pwd=1234; CharSet=utf8"); // DB 접속

        public void My_Book_Rental_ListView(string Query) // 로그인한 사람의 렌탈리스트 뷰에 추가 메서드
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(Query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                My_Book_Rental_List_listView.Items.Clear(); // View가 중복조회 되는것을 방지한다.

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["book_name"].ToString());
                    listitem.SubItems.Add(dr["book_author"].ToString());
                    listitem.SubItems.Add(dr["book_publisher"].ToString());
                    listitem.SubItems.Add(dr["book_code"].ToString());
                    listitem.SubItems.Add(dr["book_deadline"].ToString());
                    My_Book_Rental_List_listView.Items.Add(listitem);
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
        public My_Book_Rental_List_Form()
        {
            InitializeComponent();
        }

        private void Renewal_book_button_Click(object sender, EventArgs e) // 연장신청 버튼
        {
            My_Book_Rental_ListView("SELECT book_name, book_author, book_publisher, book_code, book_userid, book_deadline FROM book_rental WHERE book_userid = 'LoginId'"); // LoginID 변경
        }

        private void Return_book_buutton_Click(object sender, EventArgs e) // 반납 버튼
        {
            ListView.SelectedListViewItemCollection returnbook = this.My_Book_Rental_List_listView.SelectedItems;

            string book_name = "", book_author = "", book_publisher = "", book_code = "", book_categorize = ""; // 리스트뷰의 선택된 값을 임시로 저장하고 있을 변수 

            foreach (ListViewItem item in returnbook) // 반납 할 책이름과 작가명을 변수에 저장
            {
                book_name = (item.SubItems[0].Text);
                book_author = (item.SubItems[1].Text);
                book_publisher = (item.SubItems[2].Text);
                book_code = (item.SubItems[3].Text);
                book_categorize = (item.SubItems[4].Text);
            }

            int amount = 0; // 책을 반납하면 수량을 올라가게 만들 변수

            // 선택된 값 저장 -> 인서트 문에 담기
            string book_return_Query = "DELETE FROM book_rental WHERE book_name = '" + book_name + "' AND book_code = '" + book_code + "'";
            string book_amount_Query = "SELECT book_amount FROM book_register WHERE book_name = '" + book_name + "' AND book_code = '" + book_code + "'";

            // 책 정보를 DB에 저장
            connection.Open();
            MySqlCommand command = new MySqlCommand(book_return_Query, connection);

            MySqlDataReader reader = null;
            MySqlCommand cmd = new MySqlCommand(book_amount_Query, connection);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                amount = (int)reader["book_amount"];
            }
            reader.Close();

            amount++; // 선택된 책의 amount 값(수량)을 1 증가

            string book_register_update_amount_Query = "UPDATE book_register SET book_amount = " + amount + " WHERE book_name = '" + book_name + "' AND book_code = '" + book_code + "'";
            string book_present_update_amount_Query = "UPDATE book_present SET book_amount = " + amount + " WHERE book_name = '" + book_name + "' AND book_code = '" + book_code + "'";
            MySqlCommand register_update = new MySqlCommand(book_register_update_amount_Query, connection);
            MySqlCommand present_update = new MySqlCommand(book_present_update_amount_Query, connection);

            try//예외 처리
            {
                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                if (command.ExecuteNonQuery() == 1 && register_update.ExecuteNonQuery() == 1 && present_update.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("정상적으로 반납 되었습니다.", "반납 완료");
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
                My_Book_Rental_ListView("SELECT * FROM book_rental");
            }
        }
    }
}
