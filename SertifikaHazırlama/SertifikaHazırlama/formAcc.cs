using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SertifikaHazırlama
{
    public partial class formAcc : Form
    {
        public formMain frm;
        public formAcc()
        {
            InitializeComponent();
        }

        private void FormAcc_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://myaccount.google.com/lesssecureapps ");
            linkLabel1.LinkVisited = true;
        }

        private void Gonder_Click(object sender, EventArgs e)
        {
            
            if (mailTxt.Text == "" || sifreTxt.Text == "")
            {
                MessageBox.Show("Boş Alan Bıraktınız");
            }
            else
            {
               
                if (IsValidEmail(mailTxt.Text))
                {
                    frm.mailAdresiAl(mailTxt.Text, sifreTxt.Text);
                    this.Close();
                }
                else
                    MessageBox.Show("Geçerli Bir Mail Adresi Gir");

                
                
            }
        }
        
        private void Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            } 
        }
    }
}
