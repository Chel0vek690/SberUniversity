using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text.Json;
using System.Windows.Shapes;

namespace SberQ
{
    

    public class Email: ISendMessage
    {
        public void SendEmail(string toEmail, string body, ReadJson fileJson)
        {
            var smtp1 = fileJson.Smtp;
            string port = fileJson.Port;
            string email1 = fileJson.Email1;
            string password = fileJson.Password;
            string subject = "Ваш результат";
            string name = fileJson.Name;

            var fromAddress = new MailAddress(email1, name);
            var toAddress = new MailAddress(toEmail);

            using var smtp = new SmtpClient(smtp1, Convert.ToInt32(port));
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(fromAddress.Address, password);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            using var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };
            smtp.Send(message);

        }
    }
}