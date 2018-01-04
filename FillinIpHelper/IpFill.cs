using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Configuration;
using System.Runtime.InteropServices;//操作INI文件需要引入的命名空间
using System.IO;//检查配置文件是否存在需要引入的名字空间
namespace shcoolnetchange
{
    public partial class IpFill : Form
    {
        public IpFill()
        {
            InitializeComponent();


        }
        private int adapternumber;
       // private string adaptername;
        private string strFilePath;
        string[] name;//一个字符串数组用来存放所有网络连接的名字
        string[] IPInformation= new string [5]{"IP地址", "subnet_mask", "Defaultgateway","PreferredDNS", "ReserveDNS" };
        string[] IPnum = new string[5];
        NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();//获取本地计算机上网络接口的对象

        private void Form1_Load(object sender, EventArgs e)
        {
            adapternumber = adapters.Length;//作为数组的长度
            name = new string[adapternumber];
            for (int i = 0; i < adapternumber - 3; i++)//之所以减去3是因为有三个不明功能的网络连接。
            {
                name[i] =adapters[i].Name;//将适配器名字赋予name数组
            }
            comboBox1.DataSource = name;//将name绑定到comboBox1
            //判断配置文件是否存在
            this.strFilePath = Application.StartupPath + @"\IPconfig.ini";//我把这行代码放到了if语句里面，导致如果IPconfig文件存在，那么路径就为空置
            if (File.Exists(@"IPconfig.ini")==false)//如果不存在那么初始化
            {
                //定义一个ini文件路径 
                MessageBox.Show("首次运行！IP配置文件（IPconfig.ini）已创建并且初始化，勿删！");             
                for (int i = 0; i < adapternumber - 3; i++)
                {
                    for(int j=0;j<5;j++)
                    OperIni.WriteIni(name[i], IPInformation[j], "0.0.0.0", strFilePath);//初始化配置文件
                }
            }
            else
            {
                
            //    ipAddressTextBox1.Text= OperIni.ReadIni(name[comboBox1.SelectedIndex], "IP地址", "", strFilePath);
            //    ipAddressTextBox2.Text = OperIni.ReadIni(name[comboBox1.SelectedIndex], "subnet_mask", "", strFilePath).ToString();
            //    ipAddressTextBox3.Text = OperIni.ReadIni(name[comboBox1.SelectedIndex], "Defaultgateway", "", strFilePath).ToString();
            //    ipAddressTextBox4.Text = OperIni.ReadIni(name[comboBox1.SelectedIndex], "PreferredDNS", "", strFilePath).ToString();
            //    ipAddressTextBox5.Text = OperIni.ReadIni(name[comboBox1.SelectedIndex], "ReserveDNS", "", strFilePath).ToString();
            }

        }
        public void Fun()
        {
            ipAddressTextBox1.Text = OperIni.ReadIni(name[comboBox1.SelectedIndex], "IP地址", "", strFilePath);
            ipAddressTextBox2.Text = OperIni.ReadIni(name[comboBox1.SelectedIndex], "subnet_mask", "", strFilePath).ToString();
            ipAddressTextBox3.Text = OperIni.ReadIni(name[comboBox1.SelectedIndex], "Defaultgateway", "", strFilePath).ToString();
            ipAddressTextBox4.Text = OperIni.ReadIni(name[comboBox1.SelectedIndex], "PreferredDNS", "", strFilePath).ToString();
            ipAddressTextBox5.Text = OperIni.ReadIni(name[comboBox1.SelectedIndex], "ReserveDNS", "", strFilePath).ToString();
        }
        //dosCommand Dos命令语句
        public string Execute(string dosCommand)
        {
            return Execute(dosCommand, 10);
        }
        /// <summary>
        /// 执行DOS命令，返回DOS命令的输出
        /// </summary>
        /// <param name="dosCommand">dos命令</param>
        /// <param name="milliseconds">等待命令执行的时间（单位：毫秒），
        /// 如果设定为0，则无限等待</param>
        /// <returns>返回DOS命令的输出</returns>
        public static string Execute(string command, int seconds)
        {
            string output = ""; //输出字符串
            if (command != null && !command.Equals(""))
            {
                Process process = new Process();//创建进程对象
                ProcessStartInfo startInfo = new ProcessStartInfo();
                
                startInfo.FileName = "cmd.exe";//设定需要执行的命令
                startInfo.Arguments = "/C"+command;//“/C”表示执行完命令后马上退出
                startInfo.UseShellExecute = false;//不使用系统外壳程序启动 
                startInfo.RedirectStandardInput = false;//不重定向输入
                startInfo.RedirectStandardOutput = true; //重定向输出
                startInfo.CreateNoWindow = true;//不创建窗口
                process.StartInfo = startInfo;
                try
                {
                    if (process.Start())//开始进程
                    {
                        if (seconds == 0)
                        {
                            process.WaitForExit();//这里无限等待进程结束
                        }
                        else
                        {
                            process.WaitForExit(seconds); //等待进程结束，等待时间为指定的毫秒
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
        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                OperIni.WriteIni(name[comboBox1.SelectedIndex], IPInformation[0], ipAddressTextBox1.Text, strFilePath);
                OperIni.WriteIni(name[comboBox1.SelectedIndex], IPInformation[1], ipAddressTextBox2.Text, strFilePath);
                OperIni.WriteIni(name[comboBox1.SelectedIndex], IPInformation[2], ipAddressTextBox3.Text, strFilePath);
                OperIni.WriteIni(name[comboBox1.SelectedIndex], IPInformation[3], ipAddressTextBox4.Text, strFilePath);
                OperIni.WriteIni(name[comboBox1.SelectedIndex], IPInformation[4], ipAddressTextBox5.Text, strFilePath);
                //MessageBox.Show("IP信息写入完成");
                Execute("netsh interface ip set address \"" + name[comboBox1.SelectedIndex] + "\" static" + " " + OperIni.ReadIni(name[comboBox1.SelectedIndex], "IP地址", "", strFilePath).ToString() + " " + OperIni.ReadIni(name[comboBox1.SelectedIndex], "subnet_mask", "", strFilePath).ToString() + " " + OperIni.ReadIni(name[comboBox1.SelectedIndex], "Defaultgateway", "", strFilePath).ToString());
                Execute("netsh interface ip set dns \"" + name[comboBox1.SelectedIndex] + "\" static" + " " + OperIni.ReadIni(name[comboBox1.SelectedIndex], "PreferredDNS", "", strFilePath).ToString());
                MessageBox.Show("IP地址以及DNS获取方式：用户指定");
            }
            else
                MessageBox.Show("先别乱点，选择一个网络连接先");
            
           
       
        }

        private void button2_Click(object sender, EventArgs e)//ini文件操作成功
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                Execute("netsh interface ip set address \"" + name[comboBox1.SelectedIndex] + "\" source=dhcp");
            Execute("netsh interface ip set dns \"" + name[comboBox1.SelectedIndex] + "\" source=dhcp");
            MessageBox.Show("IP地址以及DNS获取方式：DHCP");

            }
            else
                MessageBox.Show("先别乱点，选择一个网络连接先");
        }
     
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //读取所选择网络连接的配置信息
            //textBox1.Text= OperIni.ReadIni(name[comboBox1.SelectedIndex],"IP地址","",strFilePath).ToString();//读取
            Fun();
           
        }

     

        private void 版本说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0");
        }

        private void 配置信息重置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //消息框中需要显示哪些按钮，此处显示“确定”和“取消”
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            //"确定要退出吗？"是对话框的显示信息，"退出系统"是对话框的标题
            //默认情况下，如MessageBox.Show("确定要退出吗？")只显示一个“确定”按钮。
            DialogResult dr = MessageBox.Show("确定要重置么?", "配置信息重置", messButton);
            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {
                for (int i = 0; i < adapternumber - 3; i++)
                {
                    for (int j = 0; j < 5; j++)
                        OperIni.WriteIni(name[i], IPInformation[j], "0.0.0.0", strFilePath);//初始化配置文件
                }
                MessageBox.Show("配置信息已经重置，请重新填写~");
            }
            else//如果点击“取消”按钮
            {
                MessageBox.Show("取消重置");
            }
            
        
    }

        private void 使用说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("有点智商的应该都懂把···，tips:支持按空格跳转到下一个输入框哦，但是不能直接复制粘贴IP地址/(ㄒoㄒ)/~~");
        }

        private void 小助手介绍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("旨在方便在学校，公司中使用静态IP的用户。可以令其免于频繁的手动配置IP等信息！很方便有木有！O(∩_∩)O");
        }

        private void 开发者简介ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("开发人员：郑州大学软件学院 软件开发与测试 圆葱 ；联系方式：15713660311 没错就我一个(￣▽￣)呵呵");
        }

        private void 开发者寄语ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("完成时间 2016年12月30日01:51:12 ；为了这个小东西我已经用尽洪荒之力，有BUG不要找我，我什么都不知道...什么都不知道~/(ㄒoㄒ)/~~");
        }
    }
}
