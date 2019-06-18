using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace escola_digital
{
    public partial class user_control_email : UserControl
    {
        private static user_control_email _instance;

        public static user_control_email Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user_control_email();
                return _instance;
            }
        }

        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        
        public user_control_email()
        {
            InitializeComponent();
        }

        private void Btn_enviar_Click(object sender, EventArgs e)
        {
            login = new NetworkCredential(ttb_username.Text, ttb_password.Text);
            client = new SmtpClient(ttb_smtp.Text);
            client.Port = Convert.ToInt32(ttb_port.Text);
            client.EnableSsl = ckb_ssl.Checked;
            client.Credentials = login;
            msg = new MailMessage
            {
                From = new MailAddress(ttb_username.Text + ttb_smtp.Text.Replace("smtp.", "@"),"John", Encoding.UTF8)
            };
            msg.To.Add(new MailAddress(ttb_para.Text));
            if(!string.IsNullOrEmpty(ttb_cc.Text))
                msg.To.Add(new MailAddress(ttb_cc.Text));
            msg.Subject = ttb_assunto.Text;
            msg.Body = ttb_assunto.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            string userstate = "Sending...";
            client.SendAsync(msg, userstate);
        }

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(e.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1} send canceled.", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your message has been sucessfuly sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
