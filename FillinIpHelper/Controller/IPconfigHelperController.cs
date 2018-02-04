using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPconfigHelper.Model;
namespace IPconfigHelper.Controller
{
    public class IPconfigHelperController
    {
        private Configuration _config;
        public IPconfigHelperController()
        {
            _config = Configuration.Load();
        }
        public Configuration GetConfigurationCopy()
        {
            return Configuration.Load();
        }
        public void SaveInternetSetting(List<InternetSetting>internetSettings)
        {
            _config.configs=internetSettings;
            Configuration.Save(_config);
        }
        public void DeleteInternetSetting(List<InternetSetting> internetSettings,InternetSetting internetSetting)
        {
            _config.configs = internetSettings;
            _config.configs.Remove(internetSetting);
            Configuration.Save(_config);
        }
    }
}
