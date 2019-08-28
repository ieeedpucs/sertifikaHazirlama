namespace SertifikaHazırlama
{
    partial class formAcc
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
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.gonder = new System.Windows.Forms.Button();
            this.mailLbl = new System.Windows.Forms.Label();
            this.sifreLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mailTxt
            // 
            this.mailTxt.Location = new System.Drawing.Point(99, 14);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(191, 22);
            this.mailTxt.TabIndex = 0;
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(99, 57);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.PasswordChar = '*';
            this.sifreTxt.Size = new System.Drawing.Size(191, 22);
            this.sifreTxt.TabIndex = 1;
            // 
            // gonder
            // 
            this.gonder.Location = new System.Drawing.Point(99, 85);
            this.gonder.Name = "gonder";
            this.gonder.Size = new System.Drawing.Size(108, 39);
            this.gonder.TabIndex = 2;
            this.gonder.Text = "Hesap Ekle";
            this.gonder.UseVisualStyleBackColor = true;
            this.gonder.Click += new System.EventHandler(this.Gonder_Click);
            // 
            // mailLbl
            // 
            this.mailLbl.AutoSize = true;
            this.mailLbl.Location = new System.Drawing.Point(12, 15);
            this.mailLbl.Name = "mailLbl";
            this.mailLbl.Size = new System.Drawing.Size(84, 17);
            this.mailLbl.TabIndex = 3;
            this.mailLbl.Text = "Kullanıcı Adı";
            // 
            // sifreLbl
            // 
            this.sifreLbl.AutoSize = true;
            this.sifreLbl.Location = new System.Drawing.Point(10, 60);
            this.sifreLbl.Name = "sifreLbl";
            this.sifreLbl.Size = new System.Drawing.Size(37, 17);
            this.sifreLbl.TabIndex = 4;
            this.sifreLbl.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(44, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 77);
            this.label1.TabIndex = 5;
            this.label1.Text = "adresinden Daha az güvenli uygulama erişimini AÇIN\r\n\r\n";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(44, 135);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(303, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://myaccount.google.com/lesssecureapps ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(213, 85);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(77, 39);
            this.cikis.TabIndex = 7;
            this.cikis.Text = "Çık";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // formAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 223);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifreLbl);
            this.Controls.Add(this.mailLbl);
            this.Controls.Add(this.gonder);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.mailTxt);
            this.Name = "formAcc";
            this.Text = "formAcc";
            this.Load += new System.EventHandler(this.FormAcc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mailTxt;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.Button gonder;
        private System.Windows.Forms.Label mailLbl;
        private System.Windows.Forms.Label sifreLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button cikis;
    }
}