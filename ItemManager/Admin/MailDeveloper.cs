using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace ItemManager.Admin
{
    public partial class MailDeveloper : MetroFramework.Forms.MetroForm
    {
        public MailDeveloper()
        {
            InitializeComponent();
        }

        private void MailDeveloper_Load(object sender, EventArgs e)
        {

        }

        private void BtnMailSend_Click(object sender, EventArgs e)
        {
            
            try
            {

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("devsunnysanyal@gmail.com");
                msg.To.Add("devsunnysanyal@gmail.com");
                msg.Subject ="From Inventory Management ERP "+ textBox3.Text;
                msg.Body = textBox2.Text;

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "devsunnysanyal@gmail.com";
                ntcd.Password = "9697299673";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);

                MessageBox.Show("Your Mail is sended");
                this.Hide();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;


        }
    }
    }


