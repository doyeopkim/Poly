using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonResto
{
    public partial class DeleteMenu : Form
    {
        public DeleteMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            MMPanel.Show();
            SMPanel.Hide();
            BPanel.Hide();
        }

        private void SideMenu_Click(object sender, EventArgs e)
        {
            SMPanel.Show();
            MMPanel.Hide();
            BPanel.Hide();
        }

        private void Beverage_Click(object sender, EventArgs e)
        {
            BPanel.Show();
            MMPanel.Hide();
            SMPanel.Hide();
        }

        private void DeleteMenu_Load(object sender, EventArgs e)
        {
            MMPanel.Dock = DockStyle.Left;
            SMPanel.Dock = DockStyle.Left;
            BPanel.Dock = DockStyle.Left;
            MenuInfo.Dock = DockStyle.Right;
            SMPanel.Hide();
            BPanel.Hide();
            this.Size = new Size(600, 420);
        }
    }
}
