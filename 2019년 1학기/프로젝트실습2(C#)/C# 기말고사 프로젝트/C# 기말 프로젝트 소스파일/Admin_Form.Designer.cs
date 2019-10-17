namespace Jugal
{
    partial class Admin_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            this.Admin_Panel = new System.Windows.Forms.Panel();
            this.Admin_Book_Rental_List_listView = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Admin_Book_List_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Admin_Search_book_button = new System.Windows.Forms.Button();
            this.Admin_Search_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Register_Book_button = new System.Windows.Forms.Button();
            this.Delete_Book_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Admin_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Admin_Panel
            // 
            this.Admin_Panel.BackColor = System.Drawing.Color.White;
            this.Admin_Panel.Controls.Add(this.Admin_Book_Rental_List_listView);
            this.Admin_Panel.Controls.Add(this.Admin_Book_List_listView);
            this.Admin_Panel.Controls.Add(this.Admin_Search_book_button);
            this.Admin_Panel.Controls.Add(this.Admin_Search_textBox);
            this.Admin_Panel.Controls.Add(this.label4);
            this.Admin_Panel.Controls.Add(this.label1);
            this.Admin_Panel.Controls.Add(this.Register_Book_button);
            this.Admin_Panel.Controls.Add(this.Delete_Book_button);
            this.Admin_Panel.Controls.Add(this.label5);
            this.Admin_Panel.Location = new System.Drawing.Point(1, 1);
            this.Admin_Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Admin_Panel.Name = "Admin_Panel";
            this.Admin_Panel.Size = new System.Drawing.Size(1102, 536);
            this.Admin_Panel.TabIndex = 44;
            // 
            // Admin_Book_Rental_List_listView
            // 
            this.Admin_Book_Rental_List_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.Admin_Book_Rental_List_listView.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Admin_Book_Rental_List_listView.FullRowSelect = true;
            this.Admin_Book_Rental_List_listView.Location = new System.Drawing.Point(61, 362);
            this.Admin_Book_Rental_List_listView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Admin_Book_Rental_List_listView.Name = "Admin_Book_Rental_List_listView";
            this.Admin_Book_Rental_List_listView.Size = new System.Drawing.Size(980, 159);
            this.Admin_Book_Rental_List_listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.Admin_Book_Rental_List_listView.TabIndex = 58;
            this.Admin_Book_Rental_List_listView.UseCompatibleStateImageBehavior = false;
            this.Admin_Book_Rental_List_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "도서명";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "작가";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "출판사";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "도서코드";
            this.columnHeader10.Width = 104;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "빌린고객";
            this.columnHeader11.Width = 104;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "연락처";
            this.columnHeader12.Width = 200;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "반납기한";
            this.columnHeader13.Width = 200;
            // 
            // Admin_Book_List_listView
            // 
            this.Admin_Book_List_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.Admin_Book_List_listView.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Admin_Book_List_listView.FullRowSelect = true;
            this.Admin_Book_List_listView.Location = new System.Drawing.Point(61, 129);
            this.Admin_Book_List_listView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Admin_Book_List_listView.Name = "Admin_Book_List_listView";
            this.Admin_Book_List_listView.Size = new System.Drawing.Size(980, 159);
            this.Admin_Book_List_listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.Admin_Book_List_listView.TabIndex = 57;
            this.Admin_Book_List_listView.UseCompatibleStateImageBehavior = false;
            this.Admin_Book_List_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "도서명";
            this.columnHeader1.Width = 350;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "작가";
            this.columnHeader2.Width = 200;
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
            this.columnHeader6.Width = 262;
            // 
            // Admin_Search_book_button
            // 
            this.Admin_Search_book_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Admin_Search_book_button.BackgroundImage")));
            this.Admin_Search_book_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Admin_Search_book_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Admin_Search_book_button.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Admin_Search_book_button.Location = new System.Drawing.Point(490, 46);
            this.Admin_Search_book_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Admin_Search_book_button.Name = "Admin_Search_book_button";
            this.Admin_Search_book_button.Size = new System.Drawing.Size(72, 26);
            this.Admin_Search_book_button.TabIndex = 56;
            this.Admin_Search_book_button.Text = "검색";
            this.Admin_Search_book_button.UseVisualStyleBackColor = true;
            this.Admin_Search_book_button.Click += new System.EventHandler(this.Admin_Search_button_Click);
            // 
            // Admin_Search_textBox
            // 
            this.Admin_Search_textBox.Location = new System.Drawing.Point(165, 46);
            this.Admin_Search_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Admin_Search_textBox.Multiline = true;
            this.Admin_Search_textBox.Name = "Admin_Search_textBox";
            this.Admin_Search_textBox.Size = new System.Drawing.Size(302, 26);
            this.Admin_Search_textBox.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(56, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 54;
            this.label4.Text = "도서 검색";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(56, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "대여중인 도서 목록";
            // 
            // Register_Book_button
            // 
            this.Register_Book_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Register_Book_button.BackgroundImage")));
            this.Register_Book_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Register_Book_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Register_Book_button.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Register_Book_button.Location = new System.Drawing.Point(731, 302);
            this.Register_Book_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Register_Book_button.Name = "Register_Book_button";
            this.Register_Book_button.Size = new System.Drawing.Size(143, 29);
            this.Register_Book_button.TabIndex = 51;
            this.Register_Book_button.Text = "도서 추가";
            this.Register_Book_button.UseVisualStyleBackColor = true;
            // 
            // Delete_Book_button
            // 
            this.Delete_Book_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete_Book_button.BackgroundImage")));
            this.Delete_Book_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delete_Book_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete_Book_button.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Delete_Book_button.Location = new System.Drawing.Point(899, 302);
            this.Delete_Book_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete_Book_button.Name = "Delete_Book_button";
            this.Delete_Book_button.Size = new System.Drawing.Size(143, 29);
            this.Delete_Book_button.TabIndex = 50;
            this.Delete_Book_button.Text = "도서 삭제";
            this.Delete_Book_button.UseVisualStyleBackColor = true;
            this.Delete_Book_button.Click += new System.EventHandler(this.Delete_Book_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(56, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "보유중인 도서 목록";
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 538);
            this.Controls.Add(this.Admin_Panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin_Form";
            this.Text = "관리자 모드";
            this.Admin_Panel.ResumeLayout(false);
            this.Admin_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Admin_Panel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Register_Book_button;
        private System.Windows.Forms.Button Delete_Book_button;
        private System.Windows.Forms.Button Admin_Search_book_button;
        private System.Windows.Forms.TextBox Admin_Search_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView Admin_Book_List_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView Admin_Book_Rental_List_listView;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
    }
}