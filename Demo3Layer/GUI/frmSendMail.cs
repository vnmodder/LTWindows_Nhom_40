using Demo3Layer.BUS.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo3Layer.GUI
{
    public partial class frmSendMail : Form
    {
        public frmSendMail()
        {
            InitializeComponent();
            txtFrom.Text = "squirrel.io.vn@gmail.com";
            txtFrom.ReadOnly = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress(txtFrom.Text);
            message.Subject = txtSubject.Text;
            var mails = txtTo.Text?.Split(';');
            if (mails== null || mails.Count() < 0)
            {
                return;
            }
            foreach (var item in mails)
            {
                message.To.Add(new MailAddress(item));
            }

            message.Body = rTxtBody.Text;
            message.IsBodyHtml = true;

            MailHelper mailHelper = new MailHelper();
            mailHelper.SendMail(message);
        }
    }
}
