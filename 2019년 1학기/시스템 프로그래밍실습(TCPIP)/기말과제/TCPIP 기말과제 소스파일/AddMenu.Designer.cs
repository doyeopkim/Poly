namespace BonResto
{
    partial class AddMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgPath = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bRB = new System.Windows.Forms.RadioButton();
            this.sideRB = new System.Windows.Forms.RadioButton();
            this.mainRB = new System.Windows.Forms.RadioButton();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.AddMemu = new System.Windows.Forms.Button();
            this.FindImg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.imgPath);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bRB);
            this.panel1.Controls.Add(this.sideRB);
            this.panel1.Controls.Add(this.mainRB);
            this.panel1.Controls.Add(this.priceBox);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.AddMemu);
            this.panel1.Controls.Add(this.FindImg);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 296);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // imgPath
            // 
            this.imgPath.AutoSize = true;
            this.imgPath.Location = new System.Drawing.Point(312, 230);
            this.imgPath.Name = "imgPath";
            this.imgPath.Size = new System.Drawing.Size(0, 12);
            this.imgPath.TabIndex = 8;
            this.imgPath.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(308, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "메뉴정보";
            // 
            // bRB
            // 
            this.bRB.AutoSize = true;
            this.bRB.Location = new System.Drawing.Point(355, 140);
            this.bRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bRB.Name = "bRB";
            this.bRB.Size = new System.Drawing.Size(47, 16);
            this.bRB.TabIndex = 6;
            this.bRB.TabStop = true;
            this.bRB.Text = "음료";
            this.bRB.UseVisualStyleBackColor = true;
            this.bRB.CheckedChanged += new System.EventHandler(this.bRB_CheckedChanged);
            // 
            // sideRB
            // 
            this.sideRB.AutoSize = true;
            this.sideRB.Location = new System.Drawing.Point(353, 95);
            this.sideRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sideRB.Name = "sideRB";
            this.sideRB.Size = new System.Drawing.Size(83, 16);
            this.sideRB.TabIndex = 6;
            this.sideRB.TabStop = true;
            this.sideRB.Text = "사이드메뉴";
            this.sideRB.UseVisualStyleBackColor = true;
            this.sideRB.CheckedChanged += new System.EventHandler(this.sideRB_CheckedChanged);
            // 
            // mainRB
            // 
            this.mainRB.AutoSize = true;
            this.mainRB.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mainRB.Location = new System.Drawing.Point(353, 53);
            this.mainRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainRB.Name = "mainRB";
            this.mainRB.Size = new System.Drawing.Size(64, 17);
            this.mainRB.TabIndex = 6;
            this.mainRB.TabStop = true;
            this.mainRB.Text = "주메뉴";
            this.mainRB.UseVisualStyleBackColor = true;
            this.mainRB.CheckedChanged += new System.EventHandler(this.mainRB_CheckedChanged);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(372, 203);
            this.priceBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(123, 21);
            this.priceBox.TabIndex = 5;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(373, 169);
            this.nameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(123, 21);
            this.nameBox.TabIndex = 4;
            // 
            // AddMemu
            // 
            this.AddMemu.BackColor = System.Drawing.Color.White;
            this.AddMemu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddMemu.Location = new System.Drawing.Point(424, 246);
            this.AddMemu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddMemu.Name = "AddMemu";
            this.AddMemu.Size = new System.Drawing.Size(84, 38);
            this.AddMemu.TabIndex = 3;
            this.AddMemu.Text = "추가하기";
            this.AddMemu.UseVisualStyleBackColor = false;
            this.AddMemu.Click += new System.EventHandler(this.AddMemu_Click);
            // 
            // FindImg
            // 
            this.FindImg.BackColor = System.Drawing.Color.White;
            this.FindImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FindImg.Location = new System.Drawing.Point(315, 246);
            this.FindImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindImg.Name = "FindImg";
            this.FindImg.Size = new System.Drawing.Size(81, 38);
            this.FindImg.TabIndex = 3;
            this.FindImg.Text = "사진 선택";
            this.FindImg.UseVisualStyleBackColor = false;
            this.FindImg.Click += new System.EventHandler(this.FindImg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "가 격    : ";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "제품명  : ";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 245);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "등록할 사진";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(312, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(312, 86);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(312, 126);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // AddMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 315);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddMenu";
            this.Text = "AddMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton bRB;
        private System.Windows.Forms.RadioButton sideRB;
        private System.Windows.Forms.RadioButton mainRB;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button AddMemu;
        private System.Windows.Forms.Button FindImg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label imgPath;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}