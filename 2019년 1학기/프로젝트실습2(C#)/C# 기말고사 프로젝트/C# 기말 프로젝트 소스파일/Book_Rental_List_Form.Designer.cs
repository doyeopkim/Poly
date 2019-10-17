namespace Jugal
{
    partial class Book_Rental_List_Form
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
            this.Book_Rental_List_Panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.User_Book_List_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.Rental_book_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.User_Search_book_button = new System.Windows.Forms.Button();
            this.Book_Search_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Book_info_label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Computer_radioButton = new System.Windows.Forms.RadioButton();
            this.ForeignB_radioButton = new System.Windows.Forms.RadioButton();
            this.ForeignL_radioButton = new System.Windows.Forms.RadioButton();
            this.Comic_radioButton = new System.Windows.Forms.RadioButton();
            this.Novel_radioButton = new System.Windows.Forms.RadioButton();
            this.Art_radioButton = new System.Windows.Forms.RadioButton();
            this.Science_radioButton = new System.Windows.Forms.RadioButton();
            this.Society_radioButton = new System.Windows.Forms.RadioButton();
            this.All_radioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.나의대출내역ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그아웃ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.회원정보변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그아웃ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Book_Rental_List_Panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Book_Rental_List_Panel
            // 
            this.Book_Rental_List_Panel.BackColor = System.Drawing.Color.White;
            this.Book_Rental_List_Panel.Controls.Add(this.panel1);
            this.Book_Rental_List_Panel.Controls.Add(this.menuStrip1);
            this.Book_Rental_List_Panel.Location = new System.Drawing.Point(1, 1);
            this.Book_Rental_List_Panel.Name = "Book_Rental_List_Panel";
            this.Book_Rental_List_Panel.Size = new System.Drawing.Size(1260, 670);
            this.Book_Rental_List_Panel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.User_Book_List_listView);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.Rental_book_button);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.User_Search_book_button);
            this.panel1.Controls.Add(this.Book_Search_textBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Book_info_label);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(40, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 623);
            this.panel1.TabIndex = 38;
            // 
            // User_Book_List_listView
            // 
            this.User_Book_List_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.User_Book_List_listView.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.User_Book_List_listView.FullRowSelect = true;
            this.User_Book_List_listView.Location = new System.Drawing.Point(18, 233);
            this.User_Book_List_listView.Name = "User_Book_List_listView";
            this.User_Book_List_listView.Size = new System.Drawing.Size(1142, 198);
            this.User_Book_List_listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.User_Book_List_listView.TabIndex = 58;
            this.User_Book_List_listView.UseCompatibleStateImageBehavior = false;
            this.User_Book_List_listView.View = System.Windows.Forms.View.Details;
            this.User_Book_List_listView.SelectedIndexChanged += new System.EventHandler(this.User_Book_List_listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "도서명";
            this.columnHeader1.Width = 280;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "작가";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "출판사";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "도서코드";
            this.columnHeader4.Width = 104;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "분류";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "현재 수량";
            this.columnHeader6.Width = 112;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "반납 예정";
            this.columnHeader7.Width = 112;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(828, 447);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 36);
            this.button3.TabIndex = 49;
            this.button3.Text = "대여 예약 신청";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Rental_book_button
            // 
            this.Rental_book_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rental_book_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Rental_book_button.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Rental_book_button.Location = new System.Drawing.Point(997, 447);
            this.Rental_book_button.Name = "Rental_book_button";
            this.Rental_book_button.Size = new System.Drawing.Size(163, 36);
            this.Rental_book_button.TabIndex = 48;
            this.Rental_book_button.Text = "대여하기";
            this.Rental_book_button.UseVisualStyleBackColor = true;
            this.Rental_book_button.Click += new System.EventHandler(this.Rental_book_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(9, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 32);
            this.label5.TabIndex = 47;
            this.label5.Text = "도서 목록";
            // 
            // User_Search_book_button
            // 
            this.User_Search_book_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.User_Search_book_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.User_Search_book_button.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.User_Search_book_button.Location = new System.Drawing.Point(512, 143);
            this.User_Search_book_button.Name = "User_Search_book_button";
            this.User_Search_book_button.Size = new System.Drawing.Size(82, 32);
            this.User_Search_book_button.TabIndex = 46;
            this.User_Search_book_button.Text = "확인";
            this.User_Search_book_button.UseVisualStyleBackColor = true;
            this.User_Search_book_button.Click += new System.EventHandler(this.Search_book_button_Click);
            // 
            // Book_Search_textBox
            // 
            this.Book_Search_textBox.Location = new System.Drawing.Point(137, 143);
            this.Book_Search_textBox.Multiline = true;
            this.Book_Search_textBox.Name = "Book_Search_textBox";
            this.Book_Search_textBox.Size = new System.Drawing.Size(345, 32);
            this.Book_Search_textBox.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 32);
            this.label4.TabIndex = 44;
            this.label4.Text = "도서 검색";
            // 
            // Book_info_label
            // 
            this.Book_info_label.BackColor = System.Drawing.Color.White;
            this.Book_info_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Book_info_label.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Book_info_label.Location = new System.Drawing.Point(15, 521);
            this.Book_info_label.Name = "Book_info_label";
            this.Book_info_label.Size = new System.Drawing.Size(1145, 89);
            this.Book_info_label.TabIndex = 43;
            this.Book_info_label.Text = "선택 된 도서의 내용이 여기에 표시됩니다.";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Computer_radioButton);
            this.panel4.Controls.Add(this.ForeignB_radioButton);
            this.panel4.Controls.Add(this.ForeignL_radioButton);
            this.panel4.Controls.Add(this.Comic_radioButton);
            this.panel4.Controls.Add(this.Novel_radioButton);
            this.panel4.Controls.Add(this.Art_radioButton);
            this.panel4.Controls.Add(this.Science_radioButton);
            this.panel4.Controls.Add(this.Society_radioButton);
            this.panel4.Controls.Add(this.All_radioButton);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(18, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1142, 107);
            this.panel4.TabIndex = 42;
            // 
            // Computer_radioButton
            // 
            this.Computer_radioButton.AutoSize = true;
            this.Computer_radioButton.Location = new System.Drawing.Point(280, 62);
            this.Computer_radioButton.Name = "Computer_radioButton";
            this.Computer_radioButton.Size = new System.Drawing.Size(73, 19);
            this.Computer_radioButton.TabIndex = 33;
            this.Computer_radioButton.Text = "컴퓨터";
            this.Computer_radioButton.UseVisualStyleBackColor = true;
            this.Computer_radioButton.CheckedChanged += new System.EventHandler(this.Computer_radioButton_CheckedChanged);
            // 
            // ForeignB_radioButton
            // 
            this.ForeignB_radioButton.AutoSize = true;
            this.ForeignB_radioButton.Location = new System.Drawing.Point(374, 62);
            this.ForeignB_radioButton.Name = "ForeignB_radioButton";
            this.ForeignB_radioButton.Size = new System.Drawing.Size(88, 19);
            this.ForeignB_radioButton.TabIndex = 32;
            this.ForeignB_radioButton.Text = "외국서적";
            this.ForeignB_radioButton.UseVisualStyleBackColor = true;
            this.ForeignB_radioButton.CheckedChanged += new System.EventHandler(this.ForeignB_radioButton_CheckedChanged);
            // 
            // ForeignL_radioButton
            // 
            this.ForeignL_radioButton.AutoSize = true;
            this.ForeignL_radioButton.Location = new System.Drawing.Point(450, 26);
            this.ForeignL_radioButton.Name = "ForeignL_radioButton";
            this.ForeignL_radioButton.Size = new System.Drawing.Size(73, 19);
            this.ForeignL_radioButton.TabIndex = 31;
            this.ForeignL_radioButton.Text = "외국어";
            this.ForeignL_radioButton.UseVisualStyleBackColor = true;
            this.ForeignL_radioButton.CheckedChanged += new System.EventHandler(this.ForeignL_radioButton_CheckedChanged);
            // 
            // Comic_radioButton
            // 
            this.Comic_radioButton.AutoSize = true;
            this.Comic_radioButton.Location = new System.Drawing.Point(182, 62);
            this.Comic_radioButton.Name = "Comic_radioButton";
            this.Comic_radioButton.Size = new System.Drawing.Size(58, 19);
            this.Comic_radioButton.TabIndex = 29;
            this.Comic_radioButton.Text = "만화";
            this.Comic_radioButton.UseVisualStyleBackColor = true;
            this.Comic_radioButton.CheckedChanged += new System.EventHandler(this.Comic_radioButton_CheckedChanged);
            // 
            // Novel_radioButton
            // 
            this.Novel_radioButton.AutoSize = true;
            this.Novel_radioButton.Location = new System.Drawing.Point(103, 62);
            this.Novel_radioButton.Name = "Novel_radioButton";
            this.Novel_radioButton.Size = new System.Drawing.Size(58, 19);
            this.Novel_radioButton.TabIndex = 26;
            this.Novel_radioButton.Text = "소설";
            this.Novel_radioButton.UseVisualStyleBackColor = true;
            this.Novel_radioButton.CheckedChanged += new System.EventHandler(this.Novel_radioButton_CheckedChanged);
            // 
            // Art_radioButton
            // 
            this.Art_radioButton.AutoSize = true;
            this.Art_radioButton.Location = new System.Drawing.Point(374, 26);
            this.Art_radioButton.Name = "Art_radioButton";
            this.Art_radioButton.Size = new System.Drawing.Size(58, 19);
            this.Art_radioButton.TabIndex = 23;
            this.Art_radioButton.Text = "예술";
            this.Art_radioButton.UseVisualStyleBackColor = true;
            this.Art_radioButton.CheckedChanged += new System.EventHandler(this.Art_radioButton_CheckedChanged);
            // 
            // Science_radioButton
            // 
            this.Science_radioButton.AutoSize = true;
            this.Science_radioButton.Location = new System.Drawing.Point(280, 26);
            this.Science_radioButton.Name = "Science_radioButton";
            this.Science_radioButton.Size = new System.Drawing.Size(58, 19);
            this.Science_radioButton.TabIndex = 21;
            this.Science_radioButton.Text = "과학";
            this.Science_radioButton.UseVisualStyleBackColor = true;
            this.Science_radioButton.CheckedChanged += new System.EventHandler(this.Science_radioButton_CheckedChanged);
            // 
            // Society_radioButton
            // 
            this.Society_radioButton.AutoSize = true;
            this.Society_radioButton.Location = new System.Drawing.Point(182, 26);
            this.Society_radioButton.Name = "Society_radioButton";
            this.Society_radioButton.Size = new System.Drawing.Size(73, 19);
            this.Society_radioButton.TabIndex = 20;
            this.Society_radioButton.Text = "사회학";
            this.Society_radioButton.UseVisualStyleBackColor = true;
            this.Society_radioButton.CheckedChanged += new System.EventHandler(this.Society_radioButton_CheckedChanged);
            // 
            // All_radioButton
            // 
            this.All_radioButton.AutoSize = true;
            this.All_radioButton.Checked = true;
            this.All_radioButton.Location = new System.Drawing.Point(103, 26);
            this.All_radioButton.Name = "All_radioButton";
            this.All_radioButton.Size = new System.Drawing.Size(58, 19);
            this.All_radioButton.TabIndex = 18;
            this.All_radioButton.TabStop = true;
            this.All_radioButton.Text = "전체";
            this.All_radioButton.UseVisualStyleBackColor = true;
            this.All_radioButton.CheckedChanged += new System.EventHandler(this.All_radioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 38);
            this.label2.TabIndex = 17;
            this.label2.Text = "분류";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "도서 소개";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.나의대출내역ToolStripMenuItem,
            this.로그아웃ToolStripMenuItem,
            this.로그아웃ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1260, 28);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 나의대출내역ToolStripMenuItem
            // 
            this.나의대출내역ToolStripMenuItem.Name = "나의대출내역ToolStripMenuItem";
            this.나의대출내역ToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.나의대출내역ToolStripMenuItem.Text = "인기 도서 5";
            // 
            // 로그아웃ToolStripMenuItem
            // 
            this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.로그아웃ToolStripMenuItem.Text = "도서 반납";
            // 
            // 로그아웃ToolStripMenuItem1
            // 
            this.로그아웃ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회원정보변경ToolStripMenuItem,
            this.로그아웃ToolStripMenuItem2});
            this.로그아웃ToolStripMenuItem1.Name = "로그아웃ToolStripMenuItem1";
            this.로그아웃ToolStripMenuItem1.Size = new System.Drawing.Size(71, 24);
            this.로그아웃ToolStripMenuItem1.Text = "내 정보";
            // 
            // 회원정보변경ToolStripMenuItem
            // 
            this.회원정보변경ToolStripMenuItem.Name = "회원정보변경ToolStripMenuItem";
            this.회원정보변경ToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.회원정보변경ToolStripMenuItem.Text = "회원정보 변경";
            // 
            // 로그아웃ToolStripMenuItem2
            // 
            this.로그아웃ToolStripMenuItem2.Name = "로그아웃ToolStripMenuItem2";
            this.로그아웃ToolStripMenuItem2.Size = new System.Drawing.Size(179, 26);
            this.로그아웃ToolStripMenuItem2.Text = "로그아웃";
            // 
            // Book_Rental_List_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.Book_Rental_List_Panel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Book_Rental_List_Form";
            this.Text = "무인도서관";
            this.Book_Rental_List_Panel.ResumeLayout(false);
            this.Book_Rental_List_Panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Book_Rental_List_Panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton Novel_radioButton;
        private System.Windows.Forms.RadioButton Art_radioButton;
        private System.Windows.Forms.RadioButton Science_radioButton;
        private System.Windows.Forms.RadioButton Society_radioButton;
        private System.Windows.Forms.RadioButton All_radioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Book_info_label;
        private System.Windows.Forms.RadioButton Computer_radioButton;
        private System.Windows.Forms.RadioButton ForeignB_radioButton;
        private System.Windows.Forms.RadioButton ForeignL_radioButton;
        private System.Windows.Forms.RadioButton Comic_radioButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 나의대출내역ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button User_Search_book_button;
        private System.Windows.Forms.TextBox Book_Search_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem1;
        private System.Windows.Forms.Button Rental_book_button;
        private System.Windows.Forms.ToolStripMenuItem 회원정보변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView User_Book_List_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}