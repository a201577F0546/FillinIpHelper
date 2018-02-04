using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;//检查配置文件是否存在需要引入的名字空间
using IPconfigHelper.Controller;
using IPconfigHelper.Model;
namespace IPconfigHelper
{
    public partial class MainForm : Form
    {
        AddIpConfigPage addIpConfigPage;
        IPconfigHelperController Controller;
        private int adapternumber;
        string[] name;//一个字符串数组用来存放所有网络连接的名字
        string[] IPnum = new string[5];
        NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();//获取本地计算机上网络接口的对象
        private Configuration _modifiedConfiguration;//暂存更改后的配置
        private int _lastSelectedIndex = -1;
        private bool configUpdateFlag = false;//未更改
        public MainForm()
        {
            InitializeComponent();
            adapternumber = adapters.Length;//作为数组的长度
            name = new string[adapternumber];
            for (int i = 0; i < adapternumber; i++)//之所以减去3是因为有三个不明功能的网络连接。
            {
                name[i] = adapters[i].Name;//将适配器名字赋予name数组
            }
            AdapterComboBox.DataSource = name;//将name绑定到comboBox1

            Controller = new IPconfigHelperController();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AdapterComboBox.SelectedIndex = 0;
            LoadCurrentConfiguration();//加载当前配置
            InternetSettingComboBox.Items.Clear();
            for (int i=0; i< _modifiedConfiguration.configs.Count; i++)
            {
                InternetSettingComboBox.Items.Add(_modifiedConfiguration.configs[i].name);
            }
            InternetSettingComboBox.SelectedIndex = 0;
            LoadSelectedInternetSetting();
            EditorUnable();

        }
        //dosCommand Dos命令语句
        public Task<string> Execute(string dosCommand)
        {
            return Execute(dosCommand, 1000);
        }
        /// <summary>
        /// 执行DOS命令，返回DOS命令的输出
        /// </summary>
        /// <param name="dosCommand">dos命令</param>
        /// <param name="milliseconds">等待命令执行的时间（单位：毫秒），
        /// 如果设定为0，则无限等待</param>
        /// <returns>返回DOS命令的输出</returns>
        public static Task<string> Execute(string command, int milliSeconds)
        {
            return Task.Run(() =>
            {
                string output = ""; //输出字符串
                if (command != null && !command.Equals(""))
                {
                    Process process = new Process();//创建进程对象
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",//设定需要执行的命令
                        Arguments = "/C" + command,//“/C”表示执行完命令后马上退出
                        UseShellExecute = false,//不使用系统外壳程序启动 
                        RedirectStandardInput = false,//不重定向输入
                        RedirectStandardOutput = true, //重定向输出
                        CreateNoWindow = true//不创建窗口
                    };
                    process.StartInfo = startInfo;
                    try
                    {
                        if (process.Start())//开始进程
                        {
                            if (milliSeconds == 0)
                            {
                                process.WaitForExit();//这里无限等待进程结束
                            }
                            else
                            {
                                process.WaitForExit(milliSeconds); //等待进程结束，等待时间为指定的毫秒
                            }
                            output = process.StandardOutput.ReadToEnd();//读取进程的输出
                        }
                    }
                    catch
                    {
                    }
                    finally
                    {
                        if (process != null)
                            process.Close();
                    }
                }
                return output;
            }
            );
        } 
        private void Button1_Click(object sender, EventArgs e)//执行配置
        {
            if (AdapterComboBox.SelectedIndex >= 0)
            {
                string a = IPTextBox.Text;
                string b = name[AdapterComboBox.SelectedIndex];
                //MessageBox.Show("IP信息写入完成");
                Execute("netsh interface ip set address \"" + name[AdapterComboBox.SelectedIndex] + "\" static" + " " + IPTextBox.Text + " " + SubnetMaskTextBox.Text + " " + DefaultGatewayTextBox.Text);
                Execute("netsh interface ip set dns \"" + name[AdapterComboBox.SelectedIndex] + "\" static" + " " + PreferredDNSTextBox.Text);

                OKButton.Enabled = false;
                MessageBox.Show("IP地址以及DNS获取方式：用户指定");
                OKButton.Enabled = true;
            }
            else
                OKButton.Enabled = false;
        }
        private void Button2_Click(object sender, EventArgs e)//DHCP模式
        {
            if (AdapterComboBox.SelectedIndex >= 0)
            {

                Execute("netsh interface ip set address \"" + name[AdapterComboBox.SelectedIndex] + "\" source=dhcp");
                Execute("netsh interface ip set dns \"" + name[AdapterComboBox.SelectedIndex] + "\" source=dhcp");
                MessageBox.Show("IP地址以及DNS获取方式：DHCP");
            }
            else
                MessageBox.Show("先别乱点，选择一个网络连接先");
        }
        private void NewIpconfig_Click(object sender, EventArgs e)
        {
            addIpConfigPage = new AddIpConfigPage
            {
            Visible = false
            };
            addIpConfigPage.ShowDialog();


            OnLoad(null);
        }
        private void AboutForm_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm
            {
                Visible = false
            };
            aboutForm.ShowDialog();
        }
        private void ConfigLockButton_Click(object sender, EventArgs e)
        {
           
           configUpdateFlag= !configUpdateFlag;

            if (configUpdateFlag)
            {
                ConfigLockButton.BackgroundImage = Properties.Resources.unlock37;
                OKButton.Enabled = false;
                DHCPButton.Enabled = false;
                EditorEnable();

            }
            else//保存配置
            {
              
                ConfigLockButton.BackgroundImage = Properties.Resources.locked56;//切换为锁定图标
                SaveOldSelectedInternetSetting();
                int a = InternetSettingComboBox.SelectedIndex;
                OnLoad(null);
                InternetSettingComboBox.SelectedIndex = a;//这样可以确保窗体重载以后选择的是正在编辑的这个配置
                OKButton.Enabled = true;
                DHCPButton.Enabled = true;
                EditorUnable();
            }

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //删除配置文件
            FileInfo file = new FileInfo(Application.StartupPath + "\\IPconfig.ini");
            if (file.Exists)
            {
                file.Delete();
            }

        }
        private void LoadCurrentConfiguration()
        {
            _modifiedConfiguration = Controller.GetConfigurationCopy();
        }
        private void LoadSelectedInternetSetting()
        {
            InternetSetting internetSetting = _modifiedConfiguration.configs[InternetSettingComboBox.SelectedIndex];
            NameTextBox.Text = internetSetting.name;
            IPTextBox.Text = internetSetting.ipAddress;
            SubnetMaskTextBox.Text = internetSetting.subnetMask;
            DefaultGatewayTextBox.Text = internetSetting.defaultGateway;
            PreferredDNSTextBox.Text = internetSetting.preferredDNSserver;
            AlternateDNSTextBox.Text = internetSetting.AlternateDNSserver;
              
        }
        private void InternetSettingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedInternetSetting();
            _lastSelectedIndex = InternetSettingComboBox.SelectedIndex;

        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //删除之后 首先文件在文件里移除此项
            //然后从下拉列表里移除此项
            //问题是，下拉列表的顺序必然与文件里的顺序一致么？
            //是否需要重载窗体
            //我觉得重载窗体比较保险
            //消息框中需要显示哪些按钮，此处显示“确定”和“取消”
            MessageBoxButtons messButton = MessageBoxButtons.YesNo;
            //"确定要退出吗？"是对话框的显示信息，"退出系统"是对话框的标题
            //默认情况下，如MessageBox.Show("确定要退出吗？")只显示一个“确定”按钮。
            DialogResult dr = MessageBox.Show("确定删除？", "配置信息删除", messButton);
            if (dr == DialogResult.Yes)//如果点击“确定”按钮
            {
                int index = InternetSettingComboBox.SelectedIndex;
                int count = InternetSettingComboBox.Items.Count;
                LoadCurrentConfiguration();
                Controller.DeleteInternetSetting(_modifiedConfiguration.configs, _modifiedConfiguration.configs[index]);
                InternetSettingComboBox.Items.Remove(index);
                count--;
                index = count - 1;
                OnLoad(null);


                if (count == 0)
                {
                    MessageBox.Show("已恢复默认");
                }
                else
                {
                    InternetSettingComboBox.SelectedIndex = index;
                }

            }
        }
        private void EditorEnable()
        {
            NameTextBox.Enabled = true;
            IPTextBox.Enabled = true;
            SubnetMaskTextBox.Enabled = true;
            DefaultGatewayTextBox.Enabled = true;
            PreferredDNSTextBox.Enabled = true;
            AlternateDNSTextBox.Enabled = true;

            InternetSettingComboBox.Enabled = false;
        }
        private void EditorUnable()
        {
            NameTextBox.Enabled = false;
            IPTextBox.Enabled = false;
            SubnetMaskTextBox.Enabled = false;
            DefaultGatewayTextBox.Enabled = false;
            PreferredDNSTextBox.Enabled = false;
            AlternateDNSTextBox.Enabled = false;
            InternetSettingComboBox.Enabled = true;

        }
        private void SaveOldSelectedInternetSetting()
        {
            InternetSetting internetSetting = new InternetSetting
            {
                name = NameTextBox.Text,
                ipAddress = IPTextBox.Text,
                subnetMask = SubnetMaskTextBox.Text,
                defaultGateway = DefaultGatewayTextBox.Text,
                preferredDNSserver = PreferredDNSTextBox.Text,
                AlternateDNSserver = AlternateDNSTextBox.Text
            };
            _modifiedConfiguration.configs[InternetSettingComboBox.SelectedIndex] = internetSetting;//将信息保存到 选择的那个
            Controller.SaveInternetSetting(_modifiedConfiguration.configs);//保存配置
        }
        private void AdapterComboBox_MouseHover(object sender, EventArgs e)
        {
            NoteLableText("网络适配器列表");
        }
        private void AdapterComboBox_MouseLeave(object sender, EventArgs e)
        {
            NoteLableText("");
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        #region 提示信息
        private void NoteLableText(string text)
        {
            NoteLabel.Text = text;
        }
        private void DeleteButton_MouseHover(object sender, EventArgs e)
        {
            NoteLableText("删除配置");
        }

        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            NoteLableText("");
            //以后考虑让其进行一些信息的滚动展示
        }

        private void ConfigLockButton_MouseHover(object sender, EventArgs e)
        {
            if (configUpdateFlag)
                NoteLableText("保存更改");
            else
                NoteLableText("编辑配置");

        }

        private void ConfigLockButton_MouseLeave(object sender, EventArgs e)
        {
            NoteLableText("");
        }

        private void OKButton_MouseHover(object sender, EventArgs e)
        {
            NoteLableText("更改所选择的网络适配器IP配置");
        }

        private void OKButton_MouseLeave(object sender, EventArgs e)
        {
            NoteLableText("");
        }
        private void DHCPButton_MouseHover(object sender, EventArgs e)
        {
            NoteLableText("切换到DHCP模式（自动获取IP）");
        }

        private void DHCPButton_MouseLeave(object sender, EventArgs e)
        {
            NoteLableText("");
        }
        private void InternetSettingComboBox_MouseHover(object sender, EventArgs e)
        {
            NoteLableText("用户配置列表");
        }

        private void InternetSettingComboBox_MouseLeave(object sender, EventArgs e)
        {
            NoteLableText("");
        }

        private void NameTextBox_MouseHover(object sender, EventArgs e)
        {
            NoteLableText("为不同的配置起不同的备注名以便于区分");
        }

        private void NameTextBox_MouseLeave(object sender, EventArgs e)
        {
            NoteLableText("");
        }
        #endregion
    }
}
