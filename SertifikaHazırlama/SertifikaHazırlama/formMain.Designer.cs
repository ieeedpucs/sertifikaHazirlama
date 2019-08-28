namespace SertifikaHazırlama
{
    partial class formMain
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
            this.sertifikaPb = new System.Windows.Forms.PictureBox();
            this.adSoyad = new System.Windows.Forms.Label();
            this.yaziAyarlari = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.kaydet = new System.Windows.Forms.Button();
            this.sertifikaYukle = new System.Windows.Forms.Button();
            this.excel = new System.Windows.Forms.Button();
            this.mail = new System.Windows.Forms.Button();
            this.sertifikaGoster = new System.Windows.Forms.Button();
            this.mailProgressBar = new System.Windows.Forms.ProgressBar();
            this.Account = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sertifikaPb)).BeginInit();
            this.SuspendLayout();
            // 
            // sertifikaPb
            // 
            this.sertifikaPb.BackColor = System.Drawing.SystemColors.Control;
            this.sertifikaPb.Location = new System.Drawing.Point(4, 3);
            this.sertifikaPb.Margin = new System.Windows.Forms.Padding(4);
            this.sertifikaPb.Name = "sertifikaPb";
            this.sertifikaPb.Size = new System.Drawing.Size(1348, 710);
            this.sertifikaPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sertifikaPb.TabIndex = 0;
            this.sertifikaPb.TabStop = false;
            // 
            // adSoyad
            // 
            this.adSoyad.AutoSize = true;
            this.adSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adSoyad.Location = new System.Drawing.Point(519, 158);
            this.adSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Size = new System.Drawing.Size(93, 17);
            this.adSoyad.TabIndex = 1;
            this.adSoyad.Text = "İSİM SOYİSİM";
            this.adSoyad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.adSoyad_MouseDown);
            this.adSoyad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.adSoyad_MouseMove);
            this.adSoyad.MouseUp += new System.Windows.Forms.MouseEventHandler(this.adSoyad_MouseUp);
            // 
            // yaziAyarlari
            // 
            this.yaziAyarlari.Enabled = false;
            this.yaziAyarlari.Location = new System.Drawing.Point(13, 119);
            this.yaziAyarlari.Margin = new System.Windows.Forms.Padding(4);
            this.yaziAyarlari.Name = "yaziAyarlari";
            this.yaziAyarlari.Size = new System.Drawing.Size(100, 28);
            this.yaziAyarlari.TabIndex = 2;
            this.yaziAyarlari.Text = "Yazı Ayarları";
            this.yaziAyarlari.UseVisualStyleBackColor = true;
            this.yaziAyarlari.Click += new System.EventHandler(this.adSoyadFont_Click);
            // 
            // kaydet
            // 
            this.kaydet.Enabled = false;
            this.kaydet.Location = new System.Drawing.Point(121, 119);
            this.kaydet.Margin = new System.Windows.Forms.Padding(4);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(100, 28);
            this.kaydet.TabIndex = 3;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // sertifikaYukle
            // 
            this.sertifikaYukle.Enabled = false;
            this.sertifikaYukle.Location = new System.Drawing.Point(13, 49);
            this.sertifikaYukle.Margin = new System.Windows.Forms.Padding(4);
            this.sertifikaYukle.Name = "sertifikaYukle";
            this.sertifikaYukle.Size = new System.Drawing.Size(208, 63);
            this.sertifikaYukle.TabIndex = 6;
            this.sertifikaYukle.Text = "Sertifika Yükle";
            this.sertifikaYukle.UseVisualStyleBackColor = true;
            this.sertifikaYukle.Click += new System.EventHandler(this.sertifikaYukle_Click);
            // 
            // excel
            // 
            this.excel.Enabled = false;
            this.excel.Location = new System.Drawing.Point(13, 155);
            this.excel.Margin = new System.Windows.Forms.Padding(4);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(100, 28);
            this.excel.TabIndex = 7;
            this.excel.Text = "Excel";
            this.excel.UseVisualStyleBackColor = true;
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(31, 265);
            this.mail.Margin = new System.Windows.Forms.Padding(4);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(147, 28);
            this.mail.TabIndex = 8;
            this.mail.Text = "MAİL GÖNDER";
            this.mail.UseVisualStyleBackColor = true;
            this.mail.Visible = false;
            this.mail.Click += new System.EventHandler(this.mail_Click);
            // 
            // sertifikaGoster
            // 
            this.sertifikaGoster.Location = new System.Drawing.Point(53, 229);
            this.sertifikaGoster.Margin = new System.Windows.Forms.Padding(4);
            this.sertifikaGoster.Name = "sertifikaGoster";
            this.sertifikaGoster.Size = new System.Drawing.Size(100, 28);
            this.sertifikaGoster.TabIndex = 10;
            this.sertifikaGoster.Text = "Sertifikalar";
            this.sertifikaGoster.UseVisualStyleBackColor = true;
            this.sertifikaGoster.Visible = false;
            this.sertifikaGoster.Click += new System.EventHandler(this.Button1_Click);
            // 
            // mailProgressBar
            // 
            this.mailProgressBar.Location = new System.Drawing.Point(-5, 301);
            this.mailProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.mailProgressBar.Name = "mailProgressBar";
            this.mailProgressBar.Size = new System.Drawing.Size(208, 28);
            this.mailProgressBar.TabIndex = 11;
            this.mailProgressBar.Visible = false;
            // 
            // Account
            // 
            this.Account.Location = new System.Drawing.Point(13, 13);
            this.Account.Margin = new System.Windows.Forms.Padding(4);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(208, 28);
            this.Account.TabIndex = 12;
            this.Account.Text = "HESAP";
            this.Account.UseVisualStyleBackColor = true;
            this.Account.Click += new System.EventHandler(this.Account_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1357, 718);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.mailProgressBar);
            this.Controls.Add(this.sertifikaGoster);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.excel);
            this.Controls.Add(this.sertifikaYukle);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.yaziAyarlari);
            this.Controls.Add(this.adSoyad);
            this.Controls.Add(this.sertifikaPb);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sertifikaPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sertifikaPb;
        private System.Windows.Forms.Label adSoyad;
        private System.Windows.Forms.Button yaziAyarlari;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Button sertifikaYukle;
        private System.Windows.Forms.Button excel;
        private System.Windows.Forms.Button mail;
        private System.Windows.Forms.Button sertifikaGoster;
        private System.Windows.Forms.ProgressBar mailProgressBar;
        private System.Windows.Forms.Button Account;
    }
}

