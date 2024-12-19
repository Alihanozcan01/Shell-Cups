namespace Visual_Programming_Project_Assignment
{
    partial class OyunEkrani
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyunEkrani));
            this.bardak1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bardak2 = new System.Windows.Forms.Button();
            this.bardak3 = new System.Windows.Forms.Button();
            this.Ball1 = new System.Windows.Forms.Button();
            this.Ball2 = new System.Windows.Forms.Button();
            this.Ball3 = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.Button();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.labelPuan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bardak1
            // 
            this.bardak1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bardak1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bardak1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bardak1.ImageKey = "a.png";
            this.bardak1.ImageList = this.imageList1;
            this.bardak1.Location = new System.Drawing.Point(155, 150);
            this.bardak1.Name = "bardak1";
            this.bardak1.Size = new System.Drawing.Size(150, 200);
            this.bardak1.TabIndex = 0;
            this.bardak1.UseVisualStyleBackColor = true;
            this.bardak1.Click += new System.EventHandler(this.bardak1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "beyaz bardak asıl.png");
            this.imageList1.Images.SetKeyName(1, "top.png");
            this.imageList1.Images.SetKeyName(2, "a.png");
            // 
            // bardak2
            // 
            this.bardak2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bardak2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bardak2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bardak2.ImageIndex = 2;
            this.bardak2.ImageList = this.imageList1;
            this.bardak2.Location = new System.Drawing.Point(325, 150);
            this.bardak2.Name = "bardak2";
            this.bardak2.Size = new System.Drawing.Size(150, 200);
            this.bardak2.TabIndex = 1;
            this.bardak2.UseVisualStyleBackColor = true;
            this.bardak2.Click += new System.EventHandler(this.bardak2_Click);
            // 
            // bardak3
            // 
            this.bardak3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bardak3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bardak3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bardak3.ImageIndex = 2;
            this.bardak3.ImageList = this.imageList1;
            this.bardak3.Location = new System.Drawing.Point(495, 150);
            this.bardak3.Name = "bardak3";
            this.bardak3.Size = new System.Drawing.Size(150, 200);
            this.bardak3.TabIndex = 2;
            this.bardak3.UseVisualStyleBackColor = true;
            this.bardak3.Click += new System.EventHandler(this.bardak3_Click);
            // 
            // Ball1
            // 
            this.Ball1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ball1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Ball1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ball1.Image = global::Visual_Programming_Project_Assignment.Properties.Resources.top3;
            this.Ball1.Location = new System.Drawing.Point(205, 214);
            this.Ball1.Name = "Ball1";
            this.Ball1.Size = new System.Drawing.Size(50, 50);
            this.Ball1.TabIndex = 3;
            this.Ball1.UseVisualStyleBackColor = true;
            // 
            // Ball2
            // 
            this.Ball2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ball2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Ball2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ball2.Image = global::Visual_Programming_Project_Assignment.Properties.Resources.top3;
            this.Ball2.Location = new System.Drawing.Point(375, 214);
            this.Ball2.Name = "Ball2";
            this.Ball2.Size = new System.Drawing.Size(50, 50);
            this.Ball2.TabIndex = 4;
            this.Ball2.UseVisualStyleBackColor = true;
            // 
            // Ball3
            // 
            this.Ball3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ball3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Ball3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ball3.Image = global::Visual_Programming_Project_Assignment.Properties.Resources.top3;
            this.Ball3.Location = new System.Drawing.Point(545, 214);
            this.Ball3.Name = "Ball3";
            this.Ball3.Size = new System.Drawing.Size(50, 50);
            this.Ball3.TabIndex = 5;
            this.Ball3.UseVisualStyleBackColor = true;
            // 
            // messageBox
            // 
            this.messageBox.AutoSize = true;
            this.messageBox.Location = new System.Drawing.Point(355, 363);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(0, 16);
            this.messageBox.TabIndex = 6;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPanel.Enabled = false;
            this.buttonPanel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPanel.FlatAppearance.BorderSize = 5;
            this.buttonPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPanel.Location = new System.Drawing.Point(135, 130);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(530, 240);
            this.buttonPanel.TabIndex = 7;
            this.buttonPanel.UseVisualStyleBackColor = true;
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelPuan
            // 
            this.labelPuan.AutoSize = true;
            this.labelPuan.BackColor = System.Drawing.Color.Transparent;
            this.labelPuan.Font = new System.Drawing.Font("Modern No. 20", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuan.ForeColor = System.Drawing.Color.Red;
            this.labelPuan.Location = new System.Drawing.Point(127, 61);
            this.labelPuan.Name = "labelPuan";
            this.labelPuan.Size = new System.Drawing.Size(225, 45);
            this.labelPuan.TabIndex = 8;
            this.labelPuan.Text = "Puanınız : ";
            // 
            // OyunEkrani
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Visual_Programming_Project_Assignment.Properties.Resources.Adsız_tasarım;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.labelPuan);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.Ball3);
            this.Controls.Add(this.Ball2);
            this.Controls.Add(this.Ball1);
            this.Controls.Add(this.bardak3);
            this.Controls.Add(this.bardak2);
            this.Controls.Add(this.bardak1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OyunEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shell Cups";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button bardak1;
        private System.Windows.Forms.Button bardak2;
        private System.Windows.Forms.Button bardak3;
        private System.Windows.Forms.Button Ball1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Ball2;
        private System.Windows.Forms.Button Ball3;
        private System.Windows.Forms.Label messageBox;
        private System.Windows.Forms.Button buttonPanel;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label labelPuan;
    }
}