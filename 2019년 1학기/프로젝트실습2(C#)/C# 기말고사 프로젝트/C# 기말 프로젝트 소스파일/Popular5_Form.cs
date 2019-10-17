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
    public partial class Popular5_Form : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=manlesslibrary;Uid=root;Pwd=1234; CharSet=utf8"); // DB 접속

        public Popular5_Form()
        {
            InitializeComponent();
        }

        private void Popular5_Form_Load(object sender, EventArgs e)
        {
            string search_amount_popular5_Query = "select count(*) from book_register where book_popular>0";
            
            string bookp5 = ""; // Read해서 저장하고 있을 변수명
            int count = 0; // 책의 갯수를 저장할 변수
            
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(search_amount_popular5_Query, connection);
            int book_count = Convert.ToInt32(cmd.ExecuteScalar());

            if (book_count > 0 && book_count <= 5)
            {
                string book_popluar5_Query = "SELECT * FROM book_register ORDER BY book_popular DESC LIMIT 0, " + book_count + "";

                MySqlCommand command = new MySqlCommand(book_popluar5_Query, connection);
                MySqlDataReader reader = null;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if ((int)reader["book_popular"] == 0)
                    {
                    }
                    else
                    {
                        bookp5 += (string)reader["book_name"] + '\x01';
                        count++;
                    }
                }
                reader.Close();

                string[] book5 = bookp5.Split('\x01');

                for (int i = 0; i < count; i++)
                {
                    if (i == 0 && book5[i] != "")
                    {
                        One_label.Text = "1위 " + book5[i];
                    }
                    else if (i == 1 && book5[i] != "")
                    {
                        Two_label.Text = "2위 " + book5[i];
                    }
                    else if (i == 2 && book5[i] != "")
                    {
                        Three_label.Text = "3위 " + book5[i];
                    }
                    else if (i == 3 && book5[i] != "")
                    {
                        Four_label.Text = "4위 " + book5[i];
                    }
                    else
                    {
                        Five_label.Text = "5위 " + book5[i];
                    }
                }
            }
            else
            {
                MessageBox.Show("인기 도서 목록이 없습니다.", "알림");
            }
        }

        private void Close_Popular5_Form_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
