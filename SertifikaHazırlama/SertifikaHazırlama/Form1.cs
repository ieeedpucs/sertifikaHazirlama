using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.Mail;
using System.Net;
using System.IO;


namespace SertifikaHazırlama
{
    public partial class Form1 : Form
    {
        bool surukleme = false;
        Point ilkKonum;
        Bitmap bm;
        OleDbConnection con;
        OpenFileDialog fileDialog = new OpenFileDialog();
        OpenFileDialog fileDialog2 = new OpenFileDialog();
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            adSoyad.Parent = sertifikaPb;
            adSoyad.BackColor = Color.Transparent; 
            System.IO.Directory.CreateDirectory(desktopPath + "\\Sertifikalar");
            

        }

        private void adSoyad_MouseDown(object sender, MouseEventArgs e)
        {
            surukleme = true;
            ilkKonum = e.Location;

        }

        private void adSoyad_MouseMove(object sender, MouseEventArgs e)
        {
            if (surukleme == true)
            {
                Point yeniKonum = adSoyad.Location;
                yeniKonum.X += e.X - ilkKonum.X;
                yeniKonum.Y += e.Y - ilkKonum.Y;
                adSoyad.Location = yeniKonum;
            }

        }

        private void adSoyad_MouseUp(object sender, MouseEventArgs e)
        {
            surukleme = false;
        }

        private void adSoyadFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowDialog();
            adSoyad.Font = fontDialog1.Font;
            adSoyad.ForeColor = fontDialog1.Color;
        }
        private void yazdir() {
            try
            {
                Point p = new Point(adSoyad.Location.X, adSoyad.Location.Y);
                Graphics g = Graphics.FromImage(sertifikaPb.Image);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                Brush b = new LinearGradientBrush(new Point(1, 1), new Point(100, 100), Color.FromArgb(255, adSoyad.ForeColor), Color.FromArgb(255, adSoyad.ForeColor));
                g.DrawString(adSoyad.Text, fontDialog1.Font, b, p);
            }
            catch (ArgumentNullException e) {
                MessageBox.Show("Lütfen Sertifika Ekle");
            }
        }
        private void kaydet_Click(object sender, EventArgs e)
        { 
            try{
            SaveFileDialog sf=new SaveFileDialog();
	        sf.Filter = "(*.jpg)|*.jpg";
	        sf.ShowDialog();
            yazdir();
            bm.Save(sf.FileName,ImageFormat.Jpeg);
            test();
            }
            catch{
                test();
            }                   
            
        }

        private void sertifikaYukle_Click(object sender, EventArgs e)
        {
            test();
            
	            
        }
        private void test()
        {
            try
            {
                if (!String.IsNullOrEmpty(fileDialog.FileName))
                {
                    bm = new Bitmap(fileDialog.FileName);
                    sertifikaPb.Image = bm;
                }
                else
                {
                    fileDialog.Filter = "Resim (*.jpg)|*.jpg";
                    fileDialog.ShowDialog();
                    bm = new Bitmap(fileDialog.FileName);
                    sertifikaPb.Image = bm;
                }
            }
            catch { }
        }

        private void excel_Click(object sender, EventArgs e)
        {
            excelFotoOlustur();
            mail.Visible = true;
            sertifikaGoster.Visible = true;
            mailProgressBar.Visible = true;
        }
        private void excelFotoOlustur()
        {
            fileDialog2.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            fileDialog2.ShowDialog();
            if (!String.IsNullOrEmpty(fileDialog2.FileName))
            {
                int row = 0;
                string sql;
                con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileDialog2.FileName.ToString() + "; Extended Properties='Excel 12.0 xml;HDR=YES;'");
                con.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;

                sql = "select * from [Sayfa1$]";
                cmd.CommandText = sql;
                OleDbDataReader dr = cmd.ExecuteReader();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Sayfa1$]", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                dataGridView1.Columns.Add("sertifikaYolu", "Sertifika Yolu");
                dataGridView1.Columns.Add("mailStatu", "Mail Durumu");
                MessageBox.Show("Kaydetme İşlemi Başladı");
                while (dr.Read())
                {
                    adSoyad.Text = dr[0].ToString();
                    yazdir();
                    bm.Save(desktopPath+"\\Sertifikalar\\" + dr[0] + ".jpg", ImageFormat.Jpeg);
                    dataGridView1.Rows[row++].Cells[3].Value = desktopPath + "\\Sertifikalar\\" + dr[0] + ".jpg";
                    test();
                }

                dr.Close();
                con.Close();
            }
        }

        private void mail_Click(object sender, EventArgs e)
        { 

            
            if (!String.IsNullOrEmpty(fileDialog2.FileName))
            {
               string sql;
                int row=0;
                con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileDialog2.FileName.ToString() + "; Extended Properties='Excel 12.0 xml;HDR=YES;'");
                con.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;

                sql = "select * from [Sayfa1$]";
                cmd.CommandText = sql;
                OleDbDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Gönderme İşlemi Başladı");
                while (dr.Read())
                {
                    string isimDeger = dataGridView1.Rows[row].Cells[0].Value.ToString();
                    string mailDeger = dataGridView1.Rows[row].Cells[1].Value.ToString();
                    string pathDeger = dataGridView1.Rows[row].Cells[3].Value.ToString();
                    gonder(isimDeger,mailDeger,pathDeger,row);
                    row++;
                }
                MessageBox.Show("Gönderme İşlemi Bitti");
                con.Close();
            }
        }
        private void gonder(string adsoyad, string email,string path,int row)
        {
            try {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("ieeedpucs@gmail.com");
                mail.To.Add(email);
                mail.Subject = "TEST-Katılım Sertifikası";
                mail.Body = adsoyad + " Etkinliğimize katıldığın için teşekkür ederiz";

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(path);
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("ieeedpucs@gmail.com", "DPU43ieeE");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                dataGridView1.Rows[row].Cells[4].Value = "Başarılı";
                dataGridView1.Rows[row].Cells[4].Style.BackColor = Color.Green;
                progressBar();
            }
            catch(Exception e)
            {
                dataGridView1.Rows[row].Cells[4].Value = "Başarısız";
                dataGridView1.Rows[row].Cells[4].Style.BackColor = Color.Orange;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string myPath = desktopPath+"/Sertifikalar";
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = myPath;
            prc.Start();
        }
        private void progressBar() {
            int a = dataGridView1.Rows.Count;
            mailProgressBar.Maximum = a - 1;
            mailProgressBar.Increment(1);
        }
    }
}
