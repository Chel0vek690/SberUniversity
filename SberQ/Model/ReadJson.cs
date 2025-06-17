using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SberQ.Email;
using System.Text.Json;
using System.IO;

namespace SberQ
{
    public class ReadJson: IData
    {
        public string Smtp { get; set; }
        public string Port { get; set; }
        public string Email1 { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public ReadJson Load(string path = "Email.json")
        {
            var jsonSettings = File.ReadAllText(path);
            return JsonSerializer.Deserialize<ReadJson>(jsonSettings);
        }
    }
}