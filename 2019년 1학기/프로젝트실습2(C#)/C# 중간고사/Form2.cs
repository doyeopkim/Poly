using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Kimdoyeop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            MessageBox.Show(textBox1.Text + "님이 성공적으로 추가되었습니다.", "안내 메시지", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(textBox1.Text);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrinterSettings printer = new PrinterSettings();
            PrintDocument pd = new PrintDocument();
            printDialog1.PrinterSettings = printer;
            printDialog1.Document = pd;
            printDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("정상적으로 제출되었습니다.", "안내 메시지", MessageBoxButtons.OK);
        }
    }
}
