namespace shcoolnetchange
{
    partial class iPchange
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iPchange));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iP配置信息重置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iP配置信息重置ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.配置信息重置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于小助手ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小助手介绍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于开发者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开发者简介ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开发者寄语ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ipAddressTextBox5 = new FVD.Common.IPAddressTextBox();
            this.ipAddressTextBox4 = new FVD.Common.IPAddressTextBox();
            this.ipAddressTextBox3 = new FVD.Common.IPAddressTextBox();
            this.ipAddressTextBox2 = new FVD.Common.IPAddressTextBox();
            this.ipAddressTextBox1 = new FVD.Common.IPAddressTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("幼圆", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(12, 430);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "手动设置IP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("幼圆", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(285, 430);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "自动获取IP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP 地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "子网掩码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "默认网关：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "首选DNS服务器：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "备用DNS服务器：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "配置信息：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(48, 80);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 23);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "选择网络连接：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iP配置信息重置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(54, 25);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iP配置信息重置ToolStripMenuItem
            // 
            this.iP配置信息重置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iP配置信息重置ToolStripMenuItem1,
            this.关于小助手ToolStripMenuItem,
            this.关于开发者ToolStripMenuItem,
            this.版本说明ToolStripMenuItem});
            this.iP配置信息重置ToolStripMenuItem.Name = "iP配置信息重置ToolStripMenuItem";
            this.iP配置信息重置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.iP配置信息重置ToolStripMenuItem.Text = "更多";
            // 
            // iP配置信息重置ToolStripMenuItem1
            // 
            this.iP配置信息重置ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置信息重置ToolStripMenuItem});
            this.iP配置信息重置ToolStripMenuItem1.Name = "iP配置信息重置ToolStripMenuItem1";
            this.iP配置信息重置ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.iP配置信息重置ToolStripMenuItem1.Text = "IP配置";
            // 
            // 配置信息重置ToolStripMenuItem
            // 
            this.配置信息重置ToolStripMenuItem.Name = "配置信息重置ToolStripMenuItem";
            this.配置信息重置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.配置信息重置ToolStripMenuItem.Text = "配置信息重置";
            this.配置信息重置ToolStripMenuItem.Click += new System.EventHandler(this.配置信息重置ToolStripMenuItem_Click);
            // 
            // 关于小助手ToolStripMenuItem
            // 
            this.关于小助手ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用说明ToolStripMenuItem,
            this.小助手介绍ToolStripMenuItem});
            this.关于小助手ToolStripMenuItem.Name = "关于小助手ToolStripMenuItem";
            this.关于小助手ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于小助手ToolStripMenuItem.Text = "关于小助手";
            // 
            // 使用说明ToolStripMenuItem
            // 
            this.使用说明ToolStripMenuItem.Name = "使用说明ToolStripMenuItem";
            this.使用说明ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.使用说明ToolStripMenuItem.Text = "使用说明";
            this.使用说明ToolStripMenuItem.Click += new System.EventHandler(this.使用说明ToolStripMenuItem_Click);
            // 
            // 小助手介绍ToolStripMenuItem
            // 
            this.小助手介绍ToolStripMenuItem.Name = "小助手介绍ToolStripMenuItem";
            this.小助手介绍ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.小助手介绍ToolStripMenuItem.Text = "小助手介绍";
            this.小助手介绍ToolStripMenuItem.Click += new System.EventHandler(this.小助手介绍ToolStripMenuItem_Click);
            // 
            // 关于开发者ToolStripMenuItem
            // 
            this.关于开发者ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开发者简介ToolStripMenuItem,
            this.开发者寄语ToolStripMenuItem});
            this.关于开发者ToolStripMenuItem.Name = "关于开发者ToolStripMenuItem";
            this.关于开发者ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于开发者ToolStripMenuItem.Text = "关于开发者";
            // 
            // 开发者简介ToolStripMenuItem
            // 
            this.开发者简介ToolStripMenuItem.Name = "开发者简介ToolStripMenuItem";
            this.开发者简介ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.开发者简介ToolStripMenuItem.Text = "开发者简介";
            this.开发者简介ToolStripMenuItem.Click += new System.EventHandler(this.开发者简介ToolStripMenuItem_Click);
            // 
            // 开发者寄语ToolStripMenuItem
            // 
            this.开发者寄语ToolStripMenuItem.Name = "开发者寄语ToolStripMenuItem";
            this.开发者寄语ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.开发者寄语ToolStripMenuItem.Text = "开发者寄语";
            this.开发者寄语ToolStripMenuItem.Click += new System.EventHandler(this.开发者寄语ToolStripMenuItem_Click);
            // 
            // 版本说明ToolStripMenuItem
            // 
            this.版本说明ToolStripMenuItem.Name = "版本说明ToolStripMenuItem";
            this.版本说明ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.版本说明ToolStripMenuItem.Text = "版本说明";
            this.版本说明ToolStripMenuItem.Click += new System.EventHandler(this.版本说明ToolStripMenuItem_Click);
            // 
            // ipAddressTextBox5
            // 
            this.ipAddressTextBox5.BackColor = System.Drawing.SystemColors.Control;
            this.ipAddressTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressTextBox5.Location = new System.Drawing.Point(191, 352);
            this.ipAddressTextBox5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ipAddressTextBox5.Name = "ipAddressTextBox5";
            this.ipAddressTextBox5.Size = new System.Drawing.Size(167, 35);
            this.ipAddressTextBox5.TabIndex = 19;
            this.ipAddressTextBox5.Value = ((System.Net.IPAddress)(resources.GetObject("ipAddressTextBox5.Value")));
            // 
            // ipAddressTextBox4
            // 
            this.ipAddressTextBox4.BackColor = System.Drawing.SystemColors.Control;
            this.ipAddressTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressTextBox4.Location = new System.Drawing.Point(191, 310);
            this.ipAddressTextBox4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ipAddressTextBox4.Name = "ipAddressTextBox4";
            this.ipAddressTextBox4.Size = new System.Drawing.Size(167, 35);
            this.ipAddressTextBox4.TabIndex = 18;
            this.ipAddressTextBox4.Value = ((System.Net.IPAddress)(resources.GetObject("ipAddressTextBox4.Value")));
            // 
            // ipAddressTextBox3
            // 
            this.ipAddressTextBox3.BackColor = System.Drawing.SystemColors.Control;
            this.ipAddressTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressTextBox3.Location = new System.Drawing.Point(191, 268);
            this.ipAddressTextBox3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ipAddressTextBox3.Name = "ipAddressTextBox3";
            this.ipAddressTextBox3.Size = new System.Drawing.Size(167, 35);
            this.ipAddressTextBox3.TabIndex = 17;
            this.ipAddressTextBox3.Value = ((System.Net.IPAddress)(resources.GetObject("ipAddressTextBox3.Value")));
            // 
            // ipAddressTextBox2
            // 
            this.ipAddressTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.ipAddressTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressTextBox2.Location = new System.Drawing.Point(191, 224);
            this.ipAddressTextBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ipAddressTextBox2.Name = "ipAddressTextBox2";
            this.ipAddressTextBox2.Size = new System.Drawing.Size(167, 35);
            this.ipAddressTextBox2.TabIndex = 16;
            this.ipAddressTextBox2.Value = ((System.Net.IPAddress)(resources.GetObject("ipAddressTextBox2.Value")));
            // 
            // ipAddressTextBox1
            // 
            this.ipAddressTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.ipAddressTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressTextBox1.Location = new System.Drawing.Point(191, 181);
            this.ipAddressTextBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ipAddressTextBox1.Name = "ipAddressTextBox1";
            this.ipAddressTextBox1.Size = new System.Drawing.Size(167, 35);
            this.ipAddressTextBox1.TabIndex = 15;
            this.ipAddressTextBox1.Value = ((System.Net.IPAddress)(resources.GetObject("ipAddressTextBox1.Value")));
            // 
            // iPchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(419, 501);
            this.Controls.Add(this.ipAddressTextBox5);
            this.Controls.Add(this.ipAddressTextBox4);
            this.Controls.Add(this.ipAddressTextBox3);
            this.Controls.Add(this.ipAddressTextBox2);
            this.Controls.Add(this.ipAddressTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "iPchange";
            this.Text = "IP地址小助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private FVD.Common.IPAddressTextBox ipAddressTextBox1;
        private FVD.Common.IPAddressTextBox ipAddressTextBox2;
        private FVD.Common.IPAddressTextBox ipAddressTextBox3;
        private FVD.Common.IPAddressTextBox ipAddressTextBox4;
        private FVD.Common.IPAddressTextBox ipAddressTextBox5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iP配置信息重置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iP配置信息重置ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 关于小助手ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于开发者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置信息重置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使用说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小助手介绍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开发者简介ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开发者寄语ToolStripMenuItem;
    }
}

