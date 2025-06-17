using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SberQ
{
    public interface IData
    {
        public string Smtp { get; set; }
        public string Port { get; set; }
        public string Email1 { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public ReadJson Load(string path = "Email.json");
    }
    public interface ISendMessage
    {
        public void SendEmail(string toEmail, string body, ReadJson jsonData);
    }


}
