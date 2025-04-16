using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http.Headers;
using static modul8_103022300052.BankTransferConvig;

namespace modul8_103022300052
{

   public class BankTransferConvig
    {
        public string lang { get; set;}
        public Transfer transfer { get; set; }
        public confirmation cf { get; set; }
        public class Transfer
        {
            public string thresholds { get; set; }
            public string low_fee { get; set; }
            public string high_feee { get; set; }
        }

        public string  methods { get; set;}
        public class confirmation
        {
            public string en { get; set; }
            public string id { get; set; }
        }
         
    }
    public class UIConfig
    {
        public BankTransferConvig config;
        public const String filePath = @"config.json";
        public UIConfig() {
            try
            {
                ReadConfigFile();
            }
            catch (Exception)
            {
                SetDefault();
                WriteNewConfigFile();
            }
        }
        private BankTransferConvig ReadConfigFile() {
            String configJsonData = File.ReadAllText(filePath);
            config = JsonSerializer.Deserialize<BankTransferConvig>(configJsonData);
            return config;
        }
        private void SetDefault() {
           
            BankTransferConvig config = new BankTransferConvig();
            config.lang = "en";
            Transfer transfer = new Transfer();
            transfer.thresholds = "25000000";
            transfer.low_fee = "6500";
            transfer.high_feee = "15000";
            List<string> isi = new List<string>();
            isi.Add("RTO");
            isi.Add("(real-time)");
            isi.Add("SKN");
            isi.Add("RTGS");
            isi.Add("BI");
            isi.Add("FAST");
            confirmation cf = new confirmation();
            cf.en = "yes";
            cf.id = "ya";
        }
        private void WriteNewConfigFile() {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            String jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filePath, jsonString);
        }

       
    }
}
