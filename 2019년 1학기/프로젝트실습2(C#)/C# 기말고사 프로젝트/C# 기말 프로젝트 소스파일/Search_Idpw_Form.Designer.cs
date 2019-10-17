namespace Jugal
{
    partial class Search_Idpw_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Idpw_Form));
            this.search_idpw_button = new System.Windows.Forms.Button();
            this.search_idpw_hp_label = new System.Windows.Forms.Label();
            this.search_idpw_name_label = new System.Windows.Forms.Label();
            this.user_hp_textBox = new System.Windows.Forms.TextBox();
            this.user_name_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // search_idpw_button
            // 
            this.search_idpw_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_idpw_button.BackgroundImage")));
            this.search_idpw_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_idpw_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_idpw_button.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.search_idpw_button.Location = new System.Drawing.Point(197, 184);
            this.search_idpw_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_idpw_button.Name = "search_idpw_button";
            this.search_idpw_button.Size = new System.Drawing.Size(131, 48);
            this.search_idpw_button.TabIndex = 30;
            this.search_idpw_button.Text = "확인";
            this.search_idpw_button.UseVisualStyleBackColor = true;
            this.search_idpw_button.Click += new System.EventHandler(this.search_idpw_button_Click);
            // 
            // search_idpw_hp_label
            // 
            this.search_idpw_hp_label.AutoSize = true;
            this.search_idpw_hp_label.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.search_idpw_hp_label.Location = new System.Drawing.Point(120, 120);
            this.search_idpw_hp_label.Name = "search_idpw_hp_label";
            this.search_idpw_hp_label.Size = new System.Drawing.Size(58, 21);
            this.search_idpw_hp_label.TabIndex = 23;
            this.search_idpw_hp_label.Text = "연락처";
            // 
            // search_idpw_name_label
            // 
            this.search_idpw_name_label.AutoSize = true;
            this.search_idpw_name_label.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.search_idpw_name_label.Location = new System.Drawing.Point(137, 72);
            this.search_idpw_name_label.Name = "search_idpw_name_label";
            this.search_idpw_name_label.Size = new System.Drawing.Size(42, 21);
            this.search_idpw_name_label.TabIndex = 22;
            this.search_idpw_name_label.Text = "이름";
            // 
            // user_hp_textBox
            // 
            this.user_hp_textBox.Location = new System.Drawing.Point(197, 120);
            this.user_hp_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_hp_textBox.Name = "user_hp_textBox";
            this.user_hp_textBox.Size = new System.Drawing.Size(132, 21);
            this.user_hp_textBox.TabIndex = 21;
            // 
            // user_name_textBox
            // 
            this.user_name_textBox.Location = new System.Drawing.Point(197, 72);
            this.user_name_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_name_textBox.Name = "user_name_textBox";
            this.user_name_textBox.Size = new System.Drawing.Size(132, 21);
            this.user_name_textBox.TabIndex = 20;
            // 
            // Search_Idpw_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 282);
            this.Controls.Add(this.search_idpw_button);
            this.Controls.Add(this.search_idpw_hp_label);
            this.Controls.Add(this.search_idpw_name_label);
            this.Controls.Add(this.user_hp_textBox);
            this.Controls.Add(this.user_name_textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Search_Idpw_Form";
            this.Text = "아이디, 비밀번호 찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_idpw_button;
        private System.Windows.Forms.Label search_idpw_hp_label;
        private System.Windows.Forms.Label search_idpw_name_label;
        private System.Windows.Forms.TextBox user_hp_textBox;
        private System.Windows.Forms.TextBox user_name_textBox;
    }
}