namespace IPconfigHelper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OKButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iP配置信息重置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iP配置信息重置ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewIpconfig = new System.Windows.Forms.ToolStripMenuItem();
            this.配置信息重置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.InternetSettingComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ConfigLockButton = new System.Windows.Forms.Button();
            this.PreferredDNSTextBox = new FVD.Common.IPAddressTextBox();
            this.AlternateDNSTextBox = new FVD.Common.IPAddressTextBox();
            this.DefaultGatewayTextBox = new FVD.Common.IPAddressTextBox();
            this.SubnetMaskTextBox = new FVD.Common.IPAddressTextBox();
            this.IPTextBox = new FVD.Common.IPAddressTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.SystemColors.Control;
            this.OKButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OKButton.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OKButton.Location = new System.Drawing.Point(29, 344);
            this.OKButton.Margin = new System.Windows.Forms.Padding(2);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(89, 46);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(192, 344);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "自动";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iP配置信息重置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(53, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iP配置信息重置ToolStripMenuItem
            // 
            this.iP配置信息重置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iP配置信息重置ToolStripMenuItem1,
            this.关于ToolStripMenuItem});
            this.iP配置信息重置ToolStripMenuItem.Name = "iP配置信息重置ToolStripMenuItem";
            this.iP配置信息重置ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.iP配置信息重置ToolStripMenuItem.Text = "更多";
            // 
            // iP配置信息重置ToolStripMenuItem1
            // 
            this.iP配置信息重置ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewIpconfig,
            this.配置信息重置ToolStripMenuItem});
            this.iP配置信息重置ToolStripMenuItem1.Name = "iP配置信息重置ToolStripMenuItem1";
            this.iP配置信息重置ToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.iP配置信息重置ToolStripMenuItem1.Text = "IP配置";
            // 
            // NewIpconfig
            // 
            this.NewIpconfig.Name = "NewIpconfig";
            this.NewIpconfig.Size = new System.Drawing.Size(152, 22);
            this.NewIpconfig.Text = "新建";
            this.NewIpconfig.Click += new System.EventHandler(this.NewIpconfig_Click);
            // 
            // 配置信息重置ToolStripMenuItem
            // 
            this.配置信息重置ToolStripMenuItem.Name = "配置信息重置ToolStripMenuItem";
            this.配置信息重置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.配置信息重置ToolStripMenuItem.Text = "配置信息重置";
            this.配置信息重置ToolStripMenuItem.Click += new System.EventHandler(this.配置信息重置ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.AboutForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP 地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "子网掩码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(8, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "默认网关：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(8, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "首选DNS：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(8, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "备用DNS：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(8, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 61);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 20);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "选择网络连接：";
            // 
            // InternetSettingComboBox
            // 
            this.InternetSettingComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InternetSettingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InternetSettingComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InternetSettingComboBox.FormattingEnabled = true;
            this.InternetSettingComboBox.Location = new System.Drawing.Point(143, 61);
            this.InternetSettingComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.InternetSettingComboBox.Name = "InternetSettingComboBox";
            this.InternetSettingComboBox.Size = new System.Drawing.Size(138, 20);
            this.InternetSettingComboBox.TabIndex = 26;
            this.InternetSettingComboBox.SelectedIndexChanged += new System.EventHandler(this.InternetSettingComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 27;
            this.label8.Text = "所有配置";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.ConfigLockButton);
            this.groupBox1.Controls.Add(this.PreferredDNSTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AlternateDNSTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DefaultGatewayTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SubnetMaskTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.IPTextBox);
            this.groupBox1.Location = new System.Drawing.Point(31, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 236);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置信息";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteButton.BackgroundImage = global::IPconfigHelper.Properties.Resources.trash39;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Enabled = false;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(226, 15);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(15, 15);
            this.DeleteButton.TabIndex = 27;
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ConfigLockButton
            // 
            this.ConfigLockButton.BackColor = System.Drawing.SystemColors.Control;
            this.ConfigLockButton.BackgroundImage = global::IPconfigHelper.Properties.Resources.locked56;
            this.ConfigLockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConfigLockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfigLockButton.FlatAppearance.BorderSize = 0;
            this.ConfigLockButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.ConfigLockButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.ConfigLockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigLockButton.Location = new System.Drawing.Point(11, 15);
            this.ConfigLockButton.Name = "ConfigLockButton";
            this.ConfigLockButton.Size = new System.Drawing.Size(15, 15);
            this.ConfigLockButton.TabIndex = 26;
            this.ConfigLockButton.UseVisualStyleBackColor = false;
            this.ConfigLockButton.Click += new System.EventHandler(this.ConfigLockButton_Click);
            // 
            // PreferredDNSTextBox
            // 
            this.PreferredDNSTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PreferredDNSTextBox.Location = new System.Drawing.Point(112, 159);
            this.PreferredDNSTextBox.Name = "PreferredDNSTextBox";
            this.PreferredDNSTextBox.Size = new System.Drawing.Size(129, 23);
            this.PreferredDNSTextBox.TabIndex = 24;
            this.PreferredDNSTextBox.Value = ((System.Net.IPAddress)(resources.GetObject("PreferredDNSTextBox.Value")));
            // 
            // AlternateDNSTextBox
            // 
            this.AlternateDNSTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AlternateDNSTextBox.Location = new System.Drawing.Point(112, 193);
            this.AlternateDNSTextBox.Name = "AlternateDNSTextBox";
            this.AlternateDNSTextBox.Size = new System.Drawing.Size(129, 23);
            this.AlternateDNSTextBox.TabIndex = 25;
            this.AlternateDNSTextBox.Value = ((System.Net.IPAddress)(resources.GetObject("AlternateDNSTextBox.Value")));
            // 
            // DefaultGatewayTextBox
            // 
            this.DefaultGatewayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DefaultGatewayTextBox.Location = new System.Drawing.Point(112, 125);
            this.DefaultGatewayTextBox.Name = "DefaultGatewayTextBox";
            this.DefaultGatewayTextBox.Size = new System.Drawing.Size(129, 23);
            this.DefaultGatewayTextBox.TabIndex = 23;
            this.DefaultGatewayTextBox.Value = ((System.Net.IPAddress)(resources.GetObject("DefaultGatewayTextBox.Value")));
            // 
            // SubnetMaskTextBox
            // 
            this.SubnetMaskTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SubnetMaskTextBox.Location = new System.Drawing.Point(112, 90);
            this.SubnetMaskTextBox.Name = "SubnetMaskTextBox";
            this.SubnetMaskTextBox.Size = new System.Drawing.Size(129, 23);
            this.SubnetMaskTextBox.TabIndex = 22;
            this.SubnetMaskTextBox.Value = ((System.Net.IPAddress)(resources.GetObject("SubnetMaskTextBox.Value")));
            // 
            // IPTextBox
            // 
            this.IPTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IPTextBox.Location = new System.Drawing.Point(112, 51);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(129, 33);
            this.IPTextBox.TabIndex = 21;
            this.IPTextBox.Value = ((System.Net.IPAddress)(resources.GetObject("IPTextBox.Value")));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(314, 401);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.InternetSettingComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP地址小助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iP配置信息重置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iP配置信息重置ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 配置信息重置ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private FVD.Common.IPAddressTextBox IPTextBox;
        private FVD.Common.IPAddressTextBox SubnetMaskTextBox;
        private FVD.Common.IPAddressTextBox DefaultGatewayTextBox;
        private FVD.Common.IPAddressTextBox PreferredDNSTextBox;
        private FVD.Common.IPAddressTextBox AlternateDNSTextBox;
        private System.Windows.Forms.ComboBox InternetSettingComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem NewIpconfig;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ConfigLockButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

