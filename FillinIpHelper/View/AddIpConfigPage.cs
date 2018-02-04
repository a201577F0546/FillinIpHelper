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

            if (textBox1.Text != "")
            {
                AddNewInternetSetting();
                MessageBox.Show("添加成功");
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("请填写备注名");
            }
        }

        private void AddIpConfigPage_Load(object sender, EventArgs e)
        {
            LoadCurrentConfiguration();
        }

        private void AddNewInternetSetting()
        {
            InternetSetting internetSetting = new InternetSetting
            {
                name = textBox1.Text,
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
