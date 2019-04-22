using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKTX.Support
{
    public class SupportSendEmail
    {
        public void email_send()
        {
            SmtpClient mailServer = new SmtpClient("smtp.gmail.com", 587);
            mailServer.EnableSsl = true;

            mailServer.Credentials = new System.Net.NetworkCredential("hethongqlktxdhhh@gmail.com", "hethongZ1");

            string from = "hethongqlktxdhhh@gmail.com";
            string to = "xuanhoang.ks6@gmail.com";
            MailMessage msg = new MailMessage(from, to);
            msg.Subject = "Enter the subject here";
            msg.Body = "The message goes here.";
            msg.Attachments.Add(new Attachment("D:\\Trang bìa báo cáo nghiên cứu.pdf"));
            mailServer.Send(msg);
        }


        public void Send(string from, string password, string to, string Message, string subject, string host, int port, string file)
        {

            MailMessage email = new MailMessage();
            email.From = new MailAddress(from);
            email.To.Add(to);
            email.Subject = subject;
            email.Body = Message;
            SmtpClient smtp = new SmtpClient(host, port);
            smtp.UseDefaultCredentials = false;
            NetworkCredential nc = new NetworkCredential(from, password);
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
            email.BodyEncoding = Encoding.UTF8;

            if (file.Length > 0)
            {
                Attachment attachment;
                attachment = new Attachment(file);
                email.Attachments.Add(attachment);
            }

   
            smtp.SendCompleted += new SendCompletedEventHandler(SendCompletedCallBack);
            string userstate = "sending ...";
            smtp.SendAsync(email, userstate);
        }

        private static void SendCompletedCallBack(object sender, AsyncCompletedEventArgs e)
        {
            
            if (e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thư của bạn đã được gửi đi!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        public void SendAll()
        {
            using (OpenFileDialog attachement = new OpenFileDialog()
            {
                Filter = "All files (*.*)|*.*|Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|Word 97-2003 Documents (*.doc)|*.doc|Word 2007 Documents (*.docx)|*.docx",
                ValidateNames = true
            })
            {
                if (attachement.ShowDialog() == DialogResult.OK)
                {
                    Send("hethongqlktxdhhh@gmail.com", "hethongZ1",
                         "xuanhoang.ks6@gmail.com", "Test hệ thống", "Test thử gửi tệp(Sub)",
                         "smtp.gmail.com", 587, attachement.FileName);

                }
            }
        }
      
    }
}
