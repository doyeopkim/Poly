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
    public partial class Admin_Form : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=manlesslibrary;Uid=root;Pwd=1234; CharSet=utf8"); // DB 접속

        public Admin_Form()
        {
            InitializeComponent();
        }

        private void Admin_Search_button_Click(object sender, EventArgs e)
        {
            if (Admin_Search_textBox.Text != "") // 텍스트 박스에 입력된 값이 없는게 아니라면
            {
                try
                {
                    connection.Open();
                    string Query = "SELECT * FROM book_register WHERE book_name LIKE '%" + Admin_Search_textBox.Text + "%'";
                    MySqlCommand command = new MySqlCommand(Query, connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(Query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Admin_Book_List_listView.Items.Clear(); // View가 중복조회 되는것을 방지한다.

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        ListViewItem listitem = new ListViewItem(dr["book_name"].ToString());
                        listitem.SubItems.Add(dr["book_author"].ToString());
                        listitem.SubItems.Add(dr["book_publisher"].ToString());
                        listitem.SubItems.Add(dr["book_code"].ToString());
                        listitem.SubItems.Add(dr["book_categorize"].ToString());
                        listitem.SubItems.Add(dr["book_amount"].ToString());
                        Admin_Book_List_listView.Items.Add(listitem);
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
            else
            {
                try
                {
                    // book_register 테이블을 register_listView에 출력
                    connection.Open();
                    string Query = "SELECT * FROM book_register";
                    MySqlCommand command = new MySqlCommand(Query, connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(Query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Admin_Book_List_listView.Items.Clear(); // View가 중복조회 되는것을 방지한다.

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        ListViewItem listitem = new ListViewItem(dr["book_name"].ToString());
                        listitem.SubItems.Add(dr["book_author"].ToString());
                        listitem.SubItems.Add(dr["book_publisher"].ToString());
                        listitem.SubItems.Add(dr["book_code"].ToString());
                        listitem.SubItems.Add(dr["book_categorize"].ToString());
                        listitem.SubItems.Add(dr["book_amount"].ToString());
                        Admin_Book_List_listView.Items.Add(listitem);
                    }
                    // book_retnal 테이블을 rental-listView에 출력
                    string book_present_Querry = "SELECT * FROM book_rental";
                    MySqlCommand com = new MySqlCommand(book_present_Querry, connection);
                    MySqlDataAdapter dap = new MySqlDataAdapter(book_present_Querry, connection);
                    DataTable dtp = new DataTable();
                    dap.Fill(dtp);
                    Admin_Book_Rental_List_listView.Items.Clear(); // View가 중복조회 되는것을 방지한다.

                    for (int i = 0; i < dtp.Rows.Count; i++)
                    {
                        DataRow drp = dtp.Rows[i];
                        ListViewItem listitem = new ListViewItem(drp["book_name"].ToString());
                        listitem.SubItems.Add(drp["book_author"].ToString());
                        listitem.SubItems.Add(drp["book_publisher"].ToString());
                        listitem.SubItems.Add(drp["book_code"].ToString());
                        listitem.SubItems.Add(drp["book_userid"].ToString());
                        listitem.SubItems.Add(drp["book_userhp"].ToString());
                        listitem.SubItems.Add(drp["book_deadline"].ToString());
                        Admin_Book_Rental_List_listView.Items.Add(listitem);
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

        private void Delete_Book_button_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection deletebook = this.Admin_Book_List_listView.SelectedItems;

            string book_name = "", book_author = ""; // 임시로 저장하고 있을 책이름과 작가명

            foreach (ListViewItem item in deletebook) // 지울 책이름과 작가명을 변수에 저장
            {
                book_name = (item.SubItems[0].Text);
                book_author = (item.SubItems[1].Text);
            }

            //MessageBox.Show(book_name + " " + book_author);
            connection.Open();
            string delete_book_register_Query = "DELETE FROM book_register WHERE book_name = '" + book_name + "' AND book_author = '" + book_author + "'";
            string delete_book_present_Query = "DELETE FROM book_present WHERE book_name = '" + book_name + "' AND book_author = '" + book_author + "'";
            MySqlCommand command = new MySqlCommand(delete_book_register_Query, connection);
            MySqlCommand cmd = new MySqlCommand(delete_book_present_Query, connection);

            try//예외 처리
            {
                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                if (command.ExecuteNonQuery() == 1 && cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("목록에서 책을 삭제했습니다..", "삭제 완료");

                    // 삭제하고 다시 리스트뷰를 갱신
                    string Query = "SELECT * FROM book_register";
                    MySqlCommand recommand = new MySqlCommand(Query, connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(Query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Admin_Book_List_listView.Items.Clear(); // View가 중복조회 되는것을 방지한다.

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        ListViewItem listitem = new ListViewItem(dr["book_name"].ToString());
                        listitem.SubItems.Add(dr["book_author"].ToString());
                        listitem.SubItems.Add(dr["book_publisher"].ToString());
                        listitem.SubItems.Add(dr["book_code"].ToString());
                        listitem.SubItems.Add(dr["book_categorize"].ToString());
                        listitem.SubItems.Add(dr["book_amount"].ToString());
                        Admin_Book_List_listView.Items.Add(listitem);
                    }
                }
                else
                {
                    MessageBox.Show("지울 책을 선택해 주세요", "삭제 오류");
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