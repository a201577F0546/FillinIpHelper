using IPconfigHelper.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IPconfigHelper.Controller;
namespace IPconfigHelper
{
    public partial class AddIpConfigPage : Form
    {
        private IPconfigHelperController Controller;
        private Configuration NewConfiguration;
        public AddIpConfigPage()
        {
            InitializeComponent();
            Controller = new IPconfigHelperController();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddNewInternetSetting();
        }

        private void AddIpConfigPage_Load(object sender, EventArgs e)
        {
            LoadCurrentConfiguration();
        }

        private void AddNewInternetSetting()
        {
            InternetSetting internetSetting = new InternetSetting
            {
                ipAddress = IPTextBox.Text,
                subnetMask = SubnetMaskTextBox.Text,
                defaultGateway = DefaultGatewayTextBox.Text,
                preferredDNSserver = PreferredDNSTextBox.Text,
                AlternateDNSserver = AlternateDNSTextBox.Text
            };
            NewConfiguration.configs.Add(internetSetting);
            Controller.SaveInternetSetting(NewConfiguration.configs);//写入配置文件
        }

        private void LoadCurrentConfiguration()
        {
            NewConfiguration = Controller.GetConfigurationCopy();
        }
    }
}
