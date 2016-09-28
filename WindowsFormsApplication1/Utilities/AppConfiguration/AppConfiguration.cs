using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Windows.Forms;

namespace MP.Utilities.AppConfiguration
{
    public static class AppConfiguration
    {
        public static string ReadKey()
        {
            return ConfigurationManager.AppSettings["NasaApiKey"].ToString();
        }

        public static void WriteKey(string key)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings.Remove("NasaApiKey");
            config.AppSettings.Settings.Add("NasaApiKey", key);

            config.AppSettings.SectionInformation.ForceSave = true;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
