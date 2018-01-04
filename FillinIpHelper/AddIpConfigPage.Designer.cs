namespace shcoolnetchange
{
    partial class AddIpConfigPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIpConfigPage));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ipAddressTextBox1 = new FVD.Common.IPAddressTextBox();
            this.ipAddressTextBox2 = new FVD.Common.IPAddressTextBox();
            this.ipAddressTextBox3 = new FVD.Common.IPAddressTextBox();
            this.ipAddressTextBox4 = new FVD.Common.IPAddressTextBox();
            this.ipAddressTextBox5 = new FVD.Common.IPAddressTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP 地址";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ipAddressTextBox1
            // 
            this.ipAddressTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressTextBox1.Location = new System.Drawing.Point(119, 12);
            this.ipAddressTextBox1.Name = "ipAddressTextBox1";
            this.ipAddressTextBox1.Size = new System.Drawing.Size(125, 28);
            this.ipAddressTextBox1.TabIndex = 2;
            this.ipAddressTextBox1.Value = ((System.Net.IPAddress)(resources.GetObject("ipAddressTextBox1.Value")));
            // 
            // ipAddressTextBox2
            // 
            this.ipAddressTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressTextBox2.Location = new System.Drawing.Point(119, 46);
            this.ipAddressTextBox2.Name = "ipAddressTextBox2";
            this.ipAddressTextBox2.Size = new System.Drawing.Size(125, 28);
            this.ipAddressTextBox2.TabIndex = 3;
            this.ipAddressTextBox2.Value = ((System.Net.IPAddress)(resources.GetObject("ipAddressTextBox2.Value")));
            // 
            // ipAddressTextBox3
            // 
            this.ipAddressTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressTextBox3.Location = new System.Drawing.Point(119, 80);
            this.ipAddressTextBox3.Name = "ipAddressTextBox3";
            this.ipAddressTextBox3.Size = new System.Drawing.Size(125, 28);
            this.ipAddressTextBox3.TabIndex = 4;
            this.ipAddressTextBox3.Value = ((System.Net.IPAddress)(resources.GetObject("ipAddressTextBox3.Value")));
            // 
            // ipAddressTextBox4
            // 
            this.ipAddressTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressTextBox4.Location = new System.Drawing.Point(119, 114);
            this.ipAddressTextBox4.Name = "ipAddressTextBox4";
            this.ipAddressTextBox4.Size = new System.Drawing.Size(125, 28);
            this.ipAddressTextBox4.TabIndex = 5;
            this.ipAddressTextBox4.Value = ((System.Net.IPAddress)(resources.GetObject("ipAddressTextBox4.Value")));
            // 
            // ipAddressTextBox5
            // 
            this.ipAddressTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressTextBox5.Location = new System.Drawing.Point(119, 148);
            this.ipAddressTextBox5.Name = "ipAddressTextBox5";
            this.ipAddressTextBox5.Size = new System.Drawing.Size(125, 28);
            this.ipAddressTextBox5.TabIndex = 6;
            this.ipAddressTextBox5.Value = ((System.Net.IPAddress)(resources.GetObject("ipAddressTextBox5.Value")));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "子网掩码";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "默认网关";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "首选DNS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "备用DNS";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 21);
            this.textBox1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "备注名";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ipAddressTextBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ipAddressTextBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ipAddressTextBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ipAddressTextBox4);
            this.panel1.Controls.Add(this.ipAddressTextBox5);
            this.panel1.Location = new System.Drawing.Point(3, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 186);
            this.panel1.TabIndex = 13;
            // 
            // AddIpConfigPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddIpConfigPage";
            this.Text = "AddIpConfigPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private FVD.Common.IPAddressTextBox ipAddressTextBox1;
        private FVD.Common.IPAddressTextBox ipAddressTextBox2;
        private FVD.Common.IPAddressTextBox ipAddressTextBox3;
        private FVD.Common.IPAddressTextBox ipAddressTextBox4;
        private FVD.Common.IPAddressTextBox ipAddressTextBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}