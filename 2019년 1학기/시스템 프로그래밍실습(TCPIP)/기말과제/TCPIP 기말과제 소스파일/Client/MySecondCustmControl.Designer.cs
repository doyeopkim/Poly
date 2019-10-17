namespace FastFoodDemo
{
    partial class MySecondCustmControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.price_label = new System.Windows.Forms.Label();
            this.amount_label = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Delete_menu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Order_button = new System.Windows.Forms.Button();
            this.Add_menu = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.price_label.Location = new System.Drawing.Point(598, 270);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(54, 17);
            this.price_label.TabIndex = 27;
            this.price_label.Text = "가격 : 0";
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Location = new System.Drawing.Point(668, 305);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(11, 12);
            this.amount_label.TabIndex = 26;
            this.amount_label.Text = "0";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView2.Location = new System.Drawing.Point(600, 65);
            this.listView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(149, 192);
            this.listView2.TabIndex = 25;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "메뉴";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "수량";
            // 
            // Delete_menu
            // 
            this.Delete_menu.Location = new System.Drawing.Point(600, 299);
            this.Delete_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete_menu.Name = "Delete_menu";
            this.Delete_menu.Size = new System.Drawing.Size(27, 25);
            this.Delete_menu.TabIndex = 24;
            this.Delete_menu.Text = "-";
            this.Delete_menu.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(782, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 192);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(809, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "요청 사항";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(635, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "주문목록";
            // 
            // Order_button
            // 
            this.Order_button.Location = new System.Drawing.Point(782, 270);
            this.Order_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Order_button.Name = "Order_button";
            this.Order_button.Size = new System.Drawing.Size(136, 77);
            this.Order_button.TabIndex = 20;
            this.Order_button.Text = "주문하기";
            this.Order_button.UseVisualStyleBackColor = true;
            this.Order_button.Click += new System.EventHandler(this.Order_button_Click);
            // 
            // Add_menu
            // 
            this.Add_menu.Location = new System.Drawing.Point(721, 299);
            this.Add_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_menu.Name = "Add_menu";
            this.Add_menu.Size = new System.Drawing.Size(28, 25);
            this.Add_menu.TabIndex = 19;
            this.Add_menu.Text = "+";
            this.Add_menu.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(34, 27);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(537, 321);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MySecondCustmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.amount_label);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.Delete_menu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Order_button);
            this.Controls.Add(this.Add_menu);
            this.Controls.Add(this.listView1);
            this.Name = "MySecondCustmControl";
            this.Size = new System.Drawing.Size(953, 375);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button Delete_menu;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Order_button;
        private System.Windows.Forms.Button Add_menu;
        public System.Windows.Forms.ListView listView1;
    }
}
