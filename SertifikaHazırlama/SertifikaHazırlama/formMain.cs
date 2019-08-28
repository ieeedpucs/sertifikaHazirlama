using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.Mail;

namespace SertifikaHazırlama
{
    public partial class formMain : Form
    {
        static string de;
        string mailAdresi, mailSifre;
        formDGV frm2 = new formDGV();
        bool surukleme = false;
        Point ilkKonum;
        Bitmap bitmap;
        OleDbConnection con;
        OpenFileDialog fileDialog = new OpenFileDialog();
        OpenFileDialog fileDialog2 = new OpenFileDialog();
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        public formMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            adSoyad.Parent = sertifikaPb;
            adSoyad.BackColor = Color.Transparent; 
            System.IO.Directory.CreateDirectory(desktopPath + "\\Sertifikalar");

            this.AutoScroll = true;
            this.HorizontalScroll.Enabled = true;
            this.HorizontalScroll.Visible = true;
            this.VerticalScroll.Enabled = true;
            this.VerticalScroll.Visible = true;
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
            catch{
                MessageBox.Show("yazdir.Error");
            }
        }
        private void kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                    SaveFileDialog sf = new SaveFileDialog();
                    sf.Filter = "(*.jpg)|*.jpg";
                    sf.ShowDialog();
                    yazdir();
                    bitmap.Save(sf.FileName, ImageFormat.Jpeg);
                    sertifikaVarMi();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }                   
            
        }

        private void sertifikaYukle_Click(object sender, EventArgs e)
        {
            sertifikaVarMi();

        }
        private void sertifikaVarMi()
        {
            try
            {
                if (!String.IsNullOrEmpty(fileDialog.FileName))
                {
                    bitmap = new Bitmap(fileDialog.FileName);
                    sertifikaPb.Image = bitmap;
                }
                else
                {
                    
                    fileDialog.Filter = "Resim (*.jpg)|*.jpg";
                    fileDialog.ShowDialog();
                    bitmap = new Bitmap(fileDialog.FileName);
                    sertifikaPb.Image = bitmap;
                    kaydet.Enabled = true;
                    yaziAyarlari.Enabled = true;
                    excel.Enabled = true;
                }
            }
            catch {
            }
        }

        private void excel_Click(object sender, EventArgs e)
        {
            if (excelFotoOlustur())
            {
                mail.Visible = true;
                sertifikaGoster.Visible = true;
                mailProgressBar.Visible = true;
            }
        }
        private Boolean excelFotoOlustur()
        {
            try
            {
                frm2.Show();
                fileDialog2.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
                fileDialog2.ShowDialog();
                if (String.IsNullOrEmpty(fileDialog.FileName)) {
                    return false;
                }
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
                    frm2.dataGridView1.DataSource = dt.DefaultView;
                    frm2.dataGridView1.Columns.Add("mailStatus", "Mail Durumu");
                    frm2.dataGridView1.Columns.Add("sertifikaPath", "Sertifika Yolu");
                    while (dr.Read())
                    {
                        adSoyad.Text = dr[0].ToString();
                        yazdir();
                        bitmap.Save(desktopPath + "\\Sertifikalar\\" + dr[0] + ".jpg", ImageFormat.Jpeg);
                        frm2.dataGridView1.Rows[row++].Cells[4].Value = desktopPath + "\\Sertifikalar\\" + dr[0] + ".jpg";
                        sertifikaVarMi();
                    }

                    dr.Close();
                    con.Close();
                    //MessageBox.Show("Kişiler Sertifikaya Yazıldı");
                    return true;
                }
                return false;
            }catch
            {
                MessageBox.Show("excelFotoOlustur.Error");
                return false;
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
                    string isimDeger = frm2.dataGridView1.Rows[row].Cells[0].Value.ToString();
                    string mailDeger = frm2.dataGridView1.Rows[row].Cells[1].Value.ToString();
                    string pathDeger = frm2.dataGridView1.Rows[row].Cells[4].Value.ToString();
                    mailGonder(isimDeger,mailDeger,pathDeger,row);
                    row++;
                }
                MessageBox.Show("Gönderme İşlemi Bitti");
                con.Close();
            }
        }
        private void mailGonder(string adsoyad, string email,string path,int row)
        {
            try {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(mailAdresi);
                mail.To.Add(email);
                mail.Subject = "TEST-Katılım Sertifikası";
                mail.Body = adsoyad + " Etkinliğimize katıldığın için teşekkür ederiz";

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(path);
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(mailAdresi, mailSifre);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                frm2.dataGridView1.Rows[row].Cells[3].Value = "Başarılı";
                frm2.dataGridView1.Rows[row].Cells[3].Style.BackColor = Color.Green;
                progressBar();
            }
            catch(Exception e)
            {
                frm2.dataGridView1.Rows[row].Cells[3].Value = "Başarısız";
                frm2.dataGridView1.Rows[row].Cells[3].Style.BackColor = Color.Orange;
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
            int a = frm2.dataGridView1.Rows.Count;
            mailProgressBar.Maximum = a - 1;
            mailProgressBar.Increment(1);
        }

        private void Account_Click(object sender, EventArgs e)
        {
            formAcc frmAcc = new formAcc();
            frmAcc.frm = this;
            frmAcc.ShowDialog();
                sertifikaYukle.Enabled = true;
            
            
        }

        public void mailAdresiAl(string mail, string sifre) {
            this.mailAdresi = mail;
            this.mailSifre = sifre;
        }
    }
}
