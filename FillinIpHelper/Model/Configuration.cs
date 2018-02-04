using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Newtonsoft.Json;
namespace IPconfigHelper.Model
{
    [Serializable]
    public class Configuration
    {

        public List<InternetSetting> configs;
        public int index;//指示当前是哪一个配置

        public bool isDefault;
        private static string CONFIG_FILE = "gui-config.json";
        public InternetSetting GetCurrentInternetSetting()
        {
            if (index >= 0 && index < configs.Count)
                return configs[index];
            else
                return GetDefaultInternetSetting();
        }

        public static InternetSetting GetDefaultInternetSetting()
        {
            return new InternetSetting();
        }
        public static Configuration Load()//载入配置
        {
            try
            {
                string configContent = File.ReadAllText(CONFIG_FILE);//读取配置文件内容
                Configuration config = JsonConvert.DeserializeObject<Configuration>(configContent);//将json字符串反序列化为Json对象
                config.isDefault = false;

                if (config.configs == null)
                    config.configs = new List<InternetSetting>();
                if (config.configs.Count == 0)
                    config.configs.Add(GetDefaultInternetSetting());
              
                return config;
            }
            catch (Exception e)
            {
                
                return new Configuration
                {
                    index = 0,
                    isDefault = true,
                    configs = new List<InternetSetting>()
                    {
                        GetDefaultInternetSetting()
                    },

                };
            }
        }

        public static void Save(Configuration config)//保存配置
        {
            if (config.index >= config.configs.Count)
                config.index = config.configs.Count - 1;
            if (config.index < -1)
                config.index = -1;

            config.isDefault = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(File.Open(CONFIG_FILE, FileMode.Create)))
                {
                    string jsonString = JsonConvert.SerializeObject(config, Formatting.Indented);
                    sw.Write(jsonString);
                    sw.Flush();
                }
            }
            catch (IOException e)
            {
                                                                     
            }
        }
    }
}
