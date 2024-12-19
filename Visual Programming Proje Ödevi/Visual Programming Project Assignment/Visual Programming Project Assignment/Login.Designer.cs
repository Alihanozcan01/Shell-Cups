namespace Visual_Programming_Project_Assignment
{
    partial class GirisEkrani
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
            this.textBoxKullaniciadi = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.parola = new System.Windows.Forms.Label();
            this.kullaniciadi = new System.Windows.Forms.Label();
            this.bardakoyunu = new System.Windows.Forms.Label();
            this.SingUp = new System.Windows.Forms.Button();
            this.Logİn = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Exit = new System.Windows.Forms.Button();
            this.dünyaSiralamasi = new System.Windows.Forms.Button();
            this.istatistikler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxKullaniciadi
            // 
            this.textBoxKullaniciadi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxKullaniciadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxKullaniciadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKullaniciadi.Location = new System.Drawing.Point(204, 90);
            this.textBoxKullaniciadi.Multiline = true;
            this.textBoxKullaniciadi.Name = "textBoxKullaniciadi";
            this.textBoxKullaniciadi.Size = new System.Drawing.Size(174, 27);
            this.textBoxKullaniciadi.TabIndex = 0;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxParola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxParola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxParola.Location = new System.Drawing.Point(204, 146);
            this.textBoxParola.Multiline = true;
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.PasswordChar = '*';
            this.textBoxParola.Size = new System.Drawing.Size(174, 27);
            this.textBoxParola.TabIndex = 1;
            // 
            // parola
            // 
            this.parola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.parola.AutoSize = true;
            this.parola.BackColor = System.Drawing.Color.Transparent;
            this.parola.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parola.Location = new System.Drawing.Point(36, 146);
            this.parola.Name = "parola";
            this.parola.Size = new System.Drawing.Size(82, 22);
            this.parola.TabIndex = 2;
            this.parola.Text = "Parola :\r\n";
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kullaniciadi.AutoSize = true;
            this.kullaniciadi.BackColor = System.Drawing.Color.Transparent;
            this.kullaniciadi.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciadi.Location = new System.Drawing.Point(36, 90);
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.Size = new System.Drawing.Size(147, 22);
            this.kullaniciadi.TabIndex = 3;
            this.kullaniciadi.Text = "Kullanıcı Adı :\r\n";
            // 
            // bardakoyunu
            // 
            this.bardakoyunu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bardakoyunu.AutoSize = true;
            this.bardakoyunu.BackColor = System.Drawing.Color.Transparent;
            this.bardakoyunu.Font = new System.Drawing.Font("Modern No. 20", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bardakoyunu.Location = new System.Drawing.Point(547, 213);
            this.bardakoyunu.Name = "bardakoyunu";
            this.bardakoyunu.Size = new System.Drawing.Size(386, 83);
            this.bardakoyunu.TabIndex = 4;
            this.bardakoyunu.Text = "Shell Cups";
            // 
            // SingUp
            // 
            this.SingUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SingUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SingUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingUp.Location = new System.Drawing.Point(41, 269);
            this.SingUp.Name = "SingUp";
            this.SingUp.Size = new System.Drawing.Size(150, 50);
            this.SingUp.TabIndex = 6;
            this.SingUp.Text = "Kayıt Ol";
            this.SingUp.UseVisualStyleBackColor = false;
            this.SingUp.Click += new System.EventHandler(this.SingUp_Click);
            // 
            // Logİn
            // 
            this.Logİn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logİn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Logİn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logİn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Logİn.Location = new System.Drawing.Point(41, 213);
            this.Logİn.Name = "Logİn";
            this.Logİn.Size = new System.Drawing.Size(150, 50);
            this.Logİn.TabIndex = 5;
            this.Logİn.Text = "Giriş Yap";
            this.Logİn.UseVisualStyleBackColor = false;
            this.Logİn.Click += new System.EventHandler(this.Logİn_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Exit.Location = new System.Drawing.Point(41, 381);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(150, 50);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Çıkış ";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // dünyaSiralamasi
            // 
            this.dünyaSiralamasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dünyaSiralamasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dünyaSiralamasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dünyaSiralamasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dünyaSiralamasi.Location = new System.Drawing.Point(41, 325);
            this.dünyaSiralamasi.Name = "dünyaSiralamasi";
            this.dünyaSiralamasi.Size = new System.Drawing.Size(150, 50);
            this.dünyaSiralamasi.TabIndex = 7;
            this.dünyaSiralamasi.Text = "Puan Tablosu";
            this.dünyaSiralamasi.UseVisualStyleBackColor = false;
            this.dünyaSiralamasi.Click += new System.EventHandler(this.dünyaSiralamasi_Click);
            // 
            // istatistikler
            // 
            this.istatistikler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.istatistikler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.istatistikler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.istatistikler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.istatistikler.Location = new System.Drawing.Point(41, 437);
            this.istatistikler.Name = "istatistikler";
            this.istatistikler.Size = new System.Drawing.Size(150, 35);
            this.istatistikler.TabIndex = 9;
            this.istatistikler.Text = "İstatistikler";
            this.istatistikler.UseVisualStyleBackColor = false;
            this.istatistikler.Click += new System.EventHandler(this.istatistikler_Click);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Visual_Programming_Project_Assignment.Properties.Resources.Adsız_tasarım;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(987, 503);
            this.Controls.Add(this.istatistikler);
            this.Controls.Add(this.dünyaSiralamasi);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Logİn);
            this.Controls.Add(this.SingUp);
            this.Controls.Add(this.bardakoyunu);
            this.Controls.Add(this.kullaniciadi);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxKullaniciadi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shell Cups";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKullaniciadi;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Label parola;
        private System.Windows.Forms.Label kullaniciadi;
        private System.Windows.Forms.Label bardakoyunu;
        private System.Windows.Forms.Button SingUp;
        private System.Windows.Forms.Button Logİn;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button dünyaSiralamasi;
        private System.Windows.Forms.Button istatistikler;
    }
}

