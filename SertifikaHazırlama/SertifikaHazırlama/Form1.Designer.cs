namespace SertifikaHazırlama
{
    partial class Form1
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
            this.adSoyadFont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.kaydet = new System.Windows.Forms.Button();
            this.sertifikaYukle = new System.Windows.Forms.Button();
            this.excel = new System.Windows.Forms.Button();
            this.mail = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sertifikaPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sertifikaPb
            // 
            this.sertifikaPb.Location = new System.Drawing.Point(0, 0);
            this.sertifikaPb.Name = "sertifikaPb";
            this.sertifikaPb.Size = new System.Drawing.Size(842, 595);
            this.sertifikaPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sertifikaPb.TabIndex = 0;
            this.sertifikaPb.TabStop = false;
            // 
            // adSoyad
            // 
            this.adSoyad.AutoSize = true;
            this.adSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adSoyad.Location = new System.Drawing.Point(386, 126);
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Size = new System.Drawing.Size(142, 25);
            this.adSoyad.TabIndex = 1;
            this.adSoyad.Text = "İSİM SOYİSİM";
            this.adSoyad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.adSoyad_MouseDown);
            this.adSoyad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.adSoyad_MouseMove);
            this.adSoyad.MouseUp += new System.Windows.Forms.MouseEventHandler(this.adSoyad_MouseUp);
            // 
            // adSoyadFont
            // 
            this.adSoyadFont.Location = new System.Drawing.Point(848, 69);
            this.adSoyadFont.Name = "adSoyadFont";
            this.adSoyadFont.Size = new System.Drawing.Size(75, 23);
            this.adSoyadFont.TabIndex = 2;
            this.adSoyadFont.Text = "Yazı Ayarları";
            this.adSoyadFont.UseVisualStyleBackColor = true;
            this.adSoyadFont.Click += new System.EventHandler(this.adSoyadFont_Click);
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(929, 69);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(75, 23);
            this.kaydet.TabIndex = 3;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // sertifikaYukle
            // 
            this.sertifikaYukle.Location = new System.Drawing.Point(848, 12);
            this.sertifikaYukle.Name = "sertifikaYukle";
            this.sertifikaYukle.Size = new System.Drawing.Size(156, 51);
            this.sertifikaYukle.TabIndex = 6;
            this.sertifikaYukle.Text = "Sertifika Yükle";
            this.sertifikaYukle.UseVisualStyleBackColor = true;
            this.sertifikaYukle.Click += new System.EventHandler(this.sertifikaYukle_Click);
            // 
            // excel
            // 
            this.excel.Location = new System.Drawing.Point(848, 106);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(75, 23);
            this.excel.TabIndex = 7;
            this.excel.Text = "Excel";
            this.excel.UseVisualStyleBackColor = true;
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(929, 386);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(75, 23);
            this.mail.TabIndex = 8;
            this.mail.Text = "button1";
            this.mail.UseVisualStyleBackColor = true;
            this.mail.Click += new System.EventHandler(this.mail_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 601);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(989, 99);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 712);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.excel);
            this.Controls.Add(this.sertifikaYukle);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.adSoyadFont);
            this.Controls.Add(this.adSoyad);
            this.Controls.Add(this.sertifikaPb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sertifikaPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sertifikaPb;
        private System.Windows.Forms.Label adSoyad;
        private System.Windows.Forms.Button adSoyadFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Button sertifikaYukle;
        private System.Windows.Forms.Button excel;
        private System.Windows.Forms.Button mail;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

