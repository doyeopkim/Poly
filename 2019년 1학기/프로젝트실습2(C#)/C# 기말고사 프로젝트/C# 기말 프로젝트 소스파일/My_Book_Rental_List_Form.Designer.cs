namespace Jugal
{
    partial class My_Book_Rental_List_Form
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
            this.My_Book_Rental_List_Panel = new System.Windows.Forms.Panel();
            this.My_Book_Rental_List_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Renewal_book_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Return_book_buutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.My_Book_Rental_List_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // My_Book_Rental_List_Panel
            // 
            this.My_Book_Rental_List_Panel.BackColor = System.Drawing.Color.White;
            this.My_Book_Rental_List_Panel.Controls.Add(this.My_Book_Rental_List_listView);
            this.My_Book_Rental_List_Panel.Controls.Add(this.Renewal_book_button);
            this.My_Book_Rental_List_Panel.Controls.Add(this.button1);
            this.My_Book_Rental_List_Panel.Controls.Add(this.Return_book_buutton);
            this.My_Book_Rental_List_Panel.Controls.Add(this.label5);
            this.My_Book_Rental_List_Panel.Location = new System.Drawing.Point(1, 1);
            this.My_Book_Rental_List_Panel.Name = "My_Book_Rental_List_Panel";
            this.My_Book_Rental_List_Panel.Size = new System.Drawing.Size(1260, 670);
            this.My_Book_Rental_List_Panel.TabIndex = 36;
            // 
            // My_Book_Rental_List_listView
            // 
            this.My_Book_Rental_List_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.My_Book_Rental_List_listView.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.My_Book_Rental_List_listView.FullRowSelect = true;
            this.My_Book_Rental_List_listView.Location = new System.Drawing.Point(66, 110);
            this.My_Book_Rental_List_listView.Name = "My_Book_Rental_List_listView";
            this.My_Book_Rental_List_listView.Size = new System.Drawing.Size(1128, 479);
            this.My_Book_Rental_List_listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.My_Book_Rental_List_listView.TabIndex = 58;
            this.My_Book_Rental_List_listView.UseCompatibleStateImageBehavior = false;
            this.My_Book_Rental_List_listView.View = System.Windows.Forms.View.Details;
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
            this.columnHeader5.Text = "반납 기한";
            this.columnHeader5.Width = 320;
            // 
            // Renewal_book_button
            // 
            this.Renewal_book_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Renewal_book_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Renewal_book_button.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Renewal_book_button.Location = new System.Drawing.Point(860, 614);
            this.Renewal_book_button.Name = "Renewal_book_button";
            this.Renewal_book_button.Size = new System.Drawing.Size(163, 36);
            this.Renewal_book_button.TabIndex = 51;
            this.Renewal_book_button.Text = "연장 신청";
            this.Renewal_book_button.UseVisualStyleBackColor = true;
            this.Renewal_book_button.Click += new System.EventHandler(this.Renewal_book_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(64, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 36);
            this.button1.TabIndex = 50;
            this.button1.Text = "돌아가기";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Return_book_buutton
            // 
            this.Return_book_buutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Return_book_buutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Return_book_buutton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Return_book_buutton.Location = new System.Drawing.Point(1029, 614);
            this.Return_book_buutton.Name = "Return_book_buutton";
            this.Return_book_buutton.Size = new System.Drawing.Size(163, 36);
            this.Return_book_buutton.TabIndex = 49;
            this.Return_book_buutton.Text = "반납";
            this.Return_book_buutton.UseVisualStyleBackColor = true;
            this.Return_book_buutton.Click += new System.EventHandler(this.Return_book_buutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(57, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 38);
            this.label5.TabIndex = 48;
            this.label5.Text = "나의 도서 대여 목록";
            // 
            // My_Book_Rental_List_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.My_Book_Rental_List_Panel);
            this.Name = "My_Book_Rental_List_Form";
            this.Text = "무인도서관";
            this.My_Book_Rental_List_Panel.ResumeLayout(false);
            this.My_Book_Rental_List_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel My_Book_Rental_List_Panel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Return_book_buutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Renewal_book_button;
        private System.Windows.Forms.ListView My_Book_Rental_List_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}