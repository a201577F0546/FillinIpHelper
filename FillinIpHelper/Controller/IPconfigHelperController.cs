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

        public void SaveConfig(Configuration newConfig)//保存配置
        {
            Configuration.Save(newConfig);
            Reload();
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


        protected void Reload()//配置保存之后需要重新读取
           
        {

            _config = Configuration.Load();

        }
    }
}
