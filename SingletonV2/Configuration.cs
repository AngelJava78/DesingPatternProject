using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonV2
{
    public class Configuration
    {
        private static Configuration instance;
        public string AppName { get; set; }
        public  string AppVersion { get; set; }
        public  string DateFormat { get; set; }
        public  string CurrencyFormat { get; set; }
        private Configuration()
        {
            AppName = ConfigurationManager.AppSettings["appName"];
            AppVersion = ConfigurationManager.AppSettings["appVersion"];
            DateFormat = ConfigurationManager.AppSettings["dateFormat"];
            CurrencyFormat = ConfigurationManager.AppSettings["currencyFormat"];
        }
        public static Configuration GetInstance()
        {
            if(instance == null)
            {
                instance = new Configuration();
            }
            return instance;
        }

        
    }
}
