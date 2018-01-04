using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shcoolnetchange
{
    public partial class AddIpConfigPage : Form
    {
        public AddIpConfigPage()
        {
            InitializeComponent();
        }

        public static string conName="aaa";

        public string ConName { get => conName; set => conName = value; }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {



            //将所填写信息
        }

        private void AddIpConfigPage_Load(object sender, EventArgs e)
        {
            label3.Text = this.ConName;
        }
    }
}
