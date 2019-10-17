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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SideMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Beverage = new System.Windows.Forms.ToolStripMenuItem();
            this.MMPanel = new System.Windows.Forms.Panel();
            this.mType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MenuInfo = new System.Windows.Forms.Panel();
            this.imgPath = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.FindImg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.MMPanel.SuspendLayout();
            this.MenuInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(620, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainMenu
            // 
            this.MainMenu.ForeColor = System.Drawing.Color.Black;
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(55, 20);
            this.MainMenu.Text = "주메뉴";
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // SideMenu
            // 
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(79, 20);
            this.SideMenu.Text = "사이드메뉴";
            this.SideMenu.Click += new System.EventHandler(this.SideMenu_Click);
            // 
            // Beverage
            // 
            this.Beverage.Name = "Beverage";
            this.Beverage.Size = new System.Drawing.Size(43, 20);
            this.Beverage.Text = "음료";
            this.Beverage.Click += new System.EventHandler(this.Beverage_Click);
            // 
            // MMPanel
            // 
            this.MMPanel.BackColor = System.Drawing.Color.White;
            this.MMPanel.Controls.Add(this.mType);
            this.MMPanel.Controls.Add(this.label1);
            this.MMPanel.Controls.Add(this.listView1);
            this.MMPanel.Location = new System.Drawing.Point(10, 25);
            this.MMPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MMPanel.Name = "MMPanel";
            this.MMPanel.Size = new System.Drawing.Size(316, 352);
            this.MMPanel.TabIndex = 4;
            // 
            // mType
            // 
            this.mType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mType.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mType.Location = new System.Drawing.Point(94, 15);
            this.mType.Name = "mType";
            this.mType.Size = new System.Drawing.Size(51, 18);
            this.mType.TabIndex = 2;
            this.mType.Text = "주메뉴";
            this.mType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mType.Click += new System.EventHandler(this.MType_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "메뉴목록 :";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // listView1
            // 
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(27, 48);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(267, 276);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            this.MenuInfo.BackColor = System.Drawing.Color.White;
            this.MenuInfo.Controls.Add(this.imgPath);
            this.MenuInfo.Controls.Add(this.pictureBox1);
            this.MenuInfo.Controls.Add(this.label4);
            this.MenuInfo.Controls.Add(this.priceBox);
            this.MenuInfo.Controls.Add(this.nameBox);
            this.MenuInfo.Controls.Add(this.delete);
            this.MenuInfo.Controls.Add(this.edit);
            this.MenuInfo.Controls.Add(this.FindImg);
            this.MenuInfo.Controls.Add(this.label3);
            this.MenuInfo.Controls.Add(this.label2);
            this.MenuInfo.Location = new System.Drawing.Point(332, 25);
            this.MenuInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuInfo.Name = "MenuInfo";
            this.MenuInfo.Size = new System.Drawing.Size(277, 352);
            this.MenuInfo.TabIndex = 5;
            // 
            // imgPath
            // 
            this.imgPath.AutoSize = true;
            this.imgPath.Location = new System.Drawing.Point(14, 270);
            this.imgPath.Name = "imgPath";
            this.imgPath.Size = new System.Drawing.Size(0, 12);
            this.imgPath.TabIndex = 9;
            this.imgPath.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(18, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 146);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "메뉴정보";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(86, 246);
            this.priceBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(166, 21);
            this.priceBox.TabIndex = 5;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(87, 206);
            this.nameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(166, 21);
            this.nameBox.TabIndex = 4;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(185, 293);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(70, 36);
            this.delete.TabIndex = 3;
            this.delete.Text = "삭제";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(102, 293);
            this.edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(70, 36);
            this.edit.TabIndex = 3;
            this.edit.Text = "수정";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // FindImg
            // 
            this.FindImg.BackColor = System.Drawing.Color.White;
            this.FindImg.Location = new System.Drawing.Point(18, 293);
            this.FindImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindImg.Name = "FindImg";
            this.FindImg.Size = new System.Drawing.Size(70, 36);
            this.FindImg.TabIndex = 3;
            this.FindImg.Text = "사진 선택";
            this.FindImg.UseVisualStyleBackColor = false;
            this.FindImg.Click += new System.EventHandler(this.FindImg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "가  격 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "제품명 : ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 388);
            this.Controls.Add(this.MenuInfo);
            this.Controls.Add(this.MMPanel);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainMenu;
        private System.Windows.Forms.ToolStripMenuItem SideMenu;
        private System.Windows.Forms.ToolStripMenuItem Beverage;
        private System.Windows.Forms.Panel MMPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel MenuInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button FindImg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label mType;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label imgPath;
    }
}