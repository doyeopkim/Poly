namespace BonResto
{
    partial class EditMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "짜파게티",
            "짜파게티",
            "1000"}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "너구리",
            "너구리",
            "1500"}, 1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMenu));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "채끝살",
            "채끝살",
            "50000"}, 0);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "치즈",
            "치즈",
            "1000"}, 1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "콜라",
            "콜라",
            "1000"}, 0);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "사이다",
            "사이다",
            "1000"}, 1);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SideMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Beverage = new System.Windows.Forms.ToolStripMenuItem();
            this.MMPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MenuInfo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SMPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.BPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.MMPanel.SuspendLayout();
            this.MenuInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SMPanel.SuspendLayout();
            this.BPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu,
            this.SideMenu,
            this.Beverage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1482, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainMenu
            // 
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(66, 24);
            this.MainMenu.Text = "주메뉴";
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // SideMenu
            // 
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(96, 24);
            this.SideMenu.Text = "사이드메뉴";
            this.SideMenu.Click += new System.EventHandler(this.SideMenu_Click);
            // 
            // Beverage
            // 
            this.Beverage.Name = "Beverage";
            this.Beverage.Size = new System.Drawing.Size(51, 24);
            this.Beverage.Text = "음료";
            this.Beverage.Click += new System.EventHandler(this.Beverage_Click);
            // 
            // MMPanel
            // 
            this.MMPanel.Controls.Add(this.label7);
            this.MMPanel.Controls.Add(this.label1);
            this.MMPanel.Controls.Add(this.listView1);
            this.MMPanel.Location = new System.Drawing.Point(12, 31);
            this.MMPanel.Name = "MMPanel";
            this.MMPanel.Size = new System.Drawing.Size(361, 425);
            this.MMPanel.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "주메뉴";
            this.label7.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "메뉴목록";
            // 
            // listView1
            // 
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(6, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(330, 380);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "00.jpg");
            this.imageList1.Images.SetKeyName(1, "01.jpg");
            // 
            // MenuInfo
            // 
            this.MenuInfo.Controls.Add(this.pictureBox1);
            this.MenuInfo.Controls.Add(this.label4);
            this.MenuInfo.Controls.Add(this.textBox2);
            this.MenuInfo.Controls.Add(this.textBox1);
            this.MenuInfo.Controls.Add(this.button2);
            this.MenuInfo.Controls.Add(this.button1);
            this.MenuInfo.Controls.Add(this.label3);
            this.MenuInfo.Controls.Add(this.label2);
            this.MenuInfo.Location = new System.Drawing.Point(1151, 31);
            this.MenuInfo.Name = "MenuInfo";
            this.MenuInfo.Size = new System.Drawing.Size(317, 425);
            this.MenuInfo.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 182);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "메뉴정보";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 303);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 25);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 25);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "수정";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "사진 선택";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "가격 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "제품명 : ";
            // 
            // SMPanel
            // 
            this.SMPanel.Controls.Add(this.label8);
            this.SMPanel.Controls.Add(this.label6);
            this.SMPanel.Controls.Add(this.listView2);
            this.SMPanel.Location = new System.Drawing.Point(395, 31);
            this.SMPanel.Name = "SMPanel";
            this.SMPanel.Size = new System.Drawing.Size(361, 425);
            this.SMPanel.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "사이드메뉴";
            this.label8.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "메뉴목록";
            // 
            // listView2
            // 
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listView2.Location = new System.Drawing.Point(6, 42);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(330, 380);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // BPanel
            // 
            this.BPanel.Controls.Add(this.label9);
            this.BPanel.Controls.Add(this.label10);
            this.BPanel.Controls.Add(this.listView3);
            this.BPanel.Location = new System.Drawing.Point(772, 31);
            this.BPanel.Name = "BPanel";
            this.BPanel.Size = new System.Drawing.Size(361, 425);
            this.BPanel.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "음료메뉴";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "메뉴목록";
            // 
            // listView3
            // 
            this.listView3.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6});
            this.listView3.Location = new System.Drawing.Point(6, 42);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(330, 380);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // EditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 463);
            this.Controls.Add(this.BPanel);
            this.Controls.Add(this.SMPanel);
            this.Controls.Add(this.MenuInfo);
            this.Controls.Add(this.MMPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "EditMenu";
            this.Text = "EditMenu";
            this.Load += new System.EventHandler(this.EditMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MMPanel.ResumeLayout(false);
            this.MMPanel.PerformLayout();
            this.MenuInfo.ResumeLayout(false);
            this.MenuInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SMPanel.ResumeLayout(false);
            this.SMPanel.PerformLayout();
            this.BPanel.ResumeLayout(false);
            this.BPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainMenu;
        private System.Windows.Forms.ToolStripMenuItem SideMenu;
        private System.Windows.Forms.ToolStripMenuItem Beverage;
        private System.Windows.Forms.Panel MMPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel MenuInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel SMPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Panel BPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listView3;
    }
}