using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kimdoyeop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("C#");
            listBox1.Items.Add("웹프로그래밍실습");
            listBox1.Items.Add("프로젝트실습II");
            listBox1.Items.Add("데이터베이스");
            listBox1.Items.Add("정보통신공학");
            listBox1.Items.Add("디지털공학");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
        }
    }
}
