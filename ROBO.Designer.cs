﻿
namespace ROBOClicker
{
    partial class ROBO
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ROBO));
            this.browser = new CefSharp.WinForms.ChromiumWebBrowser();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.arpce = new System.Windows.Forms.RadioButton();
            this.systemkaran = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSeoText2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prgs = new System.Windows.Forms.ProgressBar();
            this.txtWaiteTime2 = new System.Windows.Forms.TextBox();
            this.txtDestinationSite3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblVpnName = new System.Windows.Forms.Label();
            this.lblVPNMess = new System.Windows.Forms.Label();
            this.btnConnectVpn = new System.Windows.Forms.Button();
            this.btnCreatVpn = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpSeoSite = new System.Windows.Forms.GroupBox();
            this.lblSiteMess = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSeoText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWaiteTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDestinationSite = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpSeoSite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10000;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // browser
            // 
            this.browser.ActivateBrowserOnCreation = false;
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.browser.Location = new System.Drawing.Point(6, 19);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(436, 210);
            this.browser.TabIndex = 0;
            this.browser.LoadingStateChanged += new System.EventHandler<CefSharp.LoadingStateChangedEventArgs>(this.chromiumWebBrowser1_LoadingStateChanged);
            this.browser.IsBrowserInitializedChanged += new System.EventHandler(this.browser_IsBrowserInitializedChanged);
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(414, 29);
            this.txtSite.Multiline = true;
            this.txtSite.Name = "txtSite";
            this.txtSite.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSite.Size = new System.Drawing.Size(350, 229);
            this.txtSite.TabIndex = 1;
            this.txtSite.Text = resources.GetString("txtSite.Text");
            this.txtSite.TextChanged += new System.EventHandler(this.txtSite_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.txtSite);
            this.groupBox1.Controls.Add(this.arpce);
            this.groupBox1.Controls.Add(this.systemkaran);
            this.groupBox1.Controls.Add(this.browser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSeoText2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.prgs);
            this.groupBox1.Controls.Add(this.txtWaiteTime2);
            this.groupBox1.Controls.Add(this.txtDestinationSite3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(8, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 394);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // arpce
            // 
            this.arpce.AutoSize = true;
            this.arpce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.arpce.ForeColor = System.Drawing.Color.Red;
            this.arpce.Location = new System.Drawing.Point(176, 297);
            this.arpce.Name = "arpce";
            this.arpce.Size = new System.Drawing.Size(70, 17);
            this.arpce.TabIndex = 12;
            this.arpce.Text = "Arpce.net";
            this.arpce.UseVisualStyleBackColor = true;
            // 
            // systemkaran
            // 
            this.systemkaran.AutoSize = true;
            this.systemkaran.Checked = true;
            this.systemkaran.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.systemkaran.ForeColor = System.Drawing.Color.Red;
            this.systemkaran.Location = new System.Drawing.Point(176, 274);
            this.systemkaran.Name = "systemkaran";
            this.systemkaran.Size = new System.Drawing.Size(85, 17);
            this.systemkaran.TabIndex = 11;
            this.systemkaran.TabStop = true;
            this.systemkaran.Text = "Systemkaran";
            this.systemkaran.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(624, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seo Text";
            // 
            // txtSeoText2
            // 
            this.txtSeoText2.Location = new System.Drawing.Point(448, 317);
            this.txtSeoText2.Name = "txtSeoText2";
            this.txtSeoText2.Size = new System.Drawing.Size(169, 20);
            this.txtSeoText2.TabIndex = 9;
            this.txtSeoText2.Text = "گواهینامه ایزو";
            this.txtSeoText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSeoText2.TextChanged += new System.EventHandler(this.txtSeoText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(624, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Wait time in your site (miliiseccond)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(624, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Your site url";
            // 
            // prgs
            // 
            this.prgs.Location = new System.Drawing.Point(0, 393);
            this.prgs.Name = "prgs";
            this.prgs.Size = new System.Drawing.Size(807, 23);
            this.prgs.TabIndex = 6;
            // 
            // txtWaiteTime2
            // 
            this.txtWaiteTime2.Location = new System.Drawing.Point(448, 289);
            this.txtWaiteTime2.Name = "txtWaiteTime2";
            this.txtWaiteTime2.Size = new System.Drawing.Size(169, 20);
            this.txtWaiteTime2.TabIndex = 5;
            this.txtWaiteTime2.Text = "120000";
            this.txtWaiteTime2.TextChanged += new System.EventHandler(this.txtWaiteTime_TextChanged);
            // 
            // txtDestinationSite3
            // 
            this.txtDestinationSite3.Location = new System.Drawing.Point(448, 261);
            this.txtDestinationSite3.Name = "txtDestinationSite3";
            this.txtDestinationSite3.Size = new System.Drawing.Size(169, 20);
            this.txtDestinationSite3.TabIndex = 4;
            this.txtDestinationSite3.Text = "https://sistemkaran.ir/%da%af%d9%88%d8%a7%d9%87%db%8c%d9%86%d8%a7%d9%85%d9%87-%d8" +
    "%a7%db%8c%d8%b2%d9%88/";
            this.txtDestinationSite3.TextChanged += new System.EventHandler(this.txtDestinationSite_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 120);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblVpnName);
            this.groupBox2.Controls.Add(this.lblVPNMess);
            this.groupBox2.Controls.Add(this.btnConnectVpn);
            this.groupBox2.Controls.Add(this.btnCreatVpn);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtServerIP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(8, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(805, 111);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "L2TP VPN Configuration";
            // 
            // lblVpnName
            // 
            this.lblVpnName.AutoSize = true;
            this.lblVpnName.Location = new System.Drawing.Point(578, 18);
            this.lblVpnName.Name = "lblVpnName";
            this.lblVpnName.Size = new System.Drawing.Size(0, 13);
            this.lblVpnName.TabIndex = 10;
            this.lblVpnName.Visible = false;
            // 
            // lblVPNMess
            // 
            this.lblVPNMess.AutoSize = true;
            this.lblVPNMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVPNMess.ForeColor = System.Drawing.Color.Green;
            this.lblVPNMess.Location = new System.Drawing.Point(421, 77);
            this.lblVPNMess.Name = "lblVPNMess";
            this.lblVPNMess.Size = new System.Drawing.Size(0, 16);
            this.lblVPNMess.TabIndex = 9;
            // 
            // btnConnectVpn
            // 
            this.btnConnectVpn.Enabled = false;
            this.btnConnectVpn.Location = new System.Drawing.Point(354, 47);
            this.btnConnectVpn.Name = "btnConnectVpn";
            this.btnConnectVpn.Size = new System.Drawing.Size(181, 23);
            this.btnConnectVpn.TabIndex = 7;
            this.btnConnectVpn.Text = "Connect To Vpn";
            this.btnConnectVpn.UseVisualStyleBackColor = true;
            this.btnConnectVpn.Click += new System.EventHandler(this.btnConnectVpn_Click);
            // 
            // btnCreatVpn
            // 
            this.btnCreatVpn.Location = new System.Drawing.Point(354, 21);
            this.btnCreatVpn.Name = "btnCreatVpn";
            this.btnCreatVpn.Size = new System.Drawing.Size(181, 23);
            this.btnCreatVpn.TabIndex = 6;
            this.btnCreatVpn.Text = "Create Vpn Connection";
            this.btnCreatVpn.UseVisualStyleBackColor = true;
            this.btnCreatVpn.Click += new System.EventHandler(this.btnCreatVpn_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(99, 77);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(181, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Password :";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Location = new System.Drawing.Point(99, 50);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(181, 20);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "UserName :";
            // 
            // txtServerIP
            // 
            this.txtServerIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServerIP.Location = new System.Drawing.Point(98, 24);
            this.txtServerIP.Multiline = true;
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(181, 20);
            this.txtServerIP.TabIndex = 1;
            this.txtServerIP.TextChanged += new System.EventHandler(this.txtServerIP_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Server IP :";
            // 
            // grpSeoSite
            // 
            this.grpSeoSite.Controls.Add(this.lblSiteMess);
            this.grpSeoSite.Controls.Add(this.label10);
            this.grpSeoSite.Controls.Add(this.button2);
            this.grpSeoSite.Controls.Add(this.txtSeoText);
            this.grpSeoSite.Controls.Add(this.label9);
            this.grpSeoSite.Controls.Add(this.txtWaiteTime);
            this.grpSeoSite.Controls.Add(this.label8);
            this.grpSeoSite.Controls.Add(this.txtDestinationSite);
            this.grpSeoSite.Controls.Add(this.label7);
            this.grpSeoSite.Location = new System.Drawing.Point(8, 140);
            this.grpSeoSite.Name = "grpSeoSite";
            this.grpSeoSite.Size = new System.Drawing.Size(805, 149);
            this.grpSeoSite.TabIndex = 7;
            this.grpSeoSite.TabStop = false;
            this.grpSeoSite.Text = "Your Site Configuration";
            // 
            // lblSiteMess
            // 
            this.lblSiteMess.AutoSize = true;
            this.lblSiteMess.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSiteMess.Location = new System.Drawing.Point(437, 125);
            this.lblSiteMess.Name = "lblSiteMess";
            this.lblSiteMess.Size = new System.Drawing.Size(0, 13);
            this.lblSiteMess.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(284, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Second";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Create Vpn Connection";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSeoText
            // 
            this.txtSeoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeoText.Location = new System.Drawing.Point(98, 114);
            this.txtSeoText.Multiline = true;
            this.txtSeoText.Name = "txtSeoText";
            this.txtSeoText.Size = new System.Drawing.Size(181, 20);
            this.txtSeoText.TabIndex = 15;
            this.txtSeoText.TextChanged += new System.EventHandler(this.txtSeoText_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Seo Text  :";
            // 
            // txtWaiteTime
            // 
            this.txtWaiteTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWaiteTime.Location = new System.Drawing.Point(98, 88);
            this.txtWaiteTime.Multiline = true;
            this.txtWaiteTime.Name = "txtWaiteTime";
            this.txtWaiteTime.Size = new System.Drawing.Size(181, 20);
            this.txtWaiteTime.TabIndex = 9;
            this.txtWaiteTime.Text = "5";
            this.txtWaiteTime.TextChanged += new System.EventHandler(this.txtWaiteTime_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Wait Time  :";
            // 
            // txtDestinationSite
            // 
            this.txtDestinationSite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDestinationSite.Location = new System.Drawing.Point(98, 18);
            this.txtDestinationSite.Multiline = true;
            this.txtDestinationSite.Name = "txtDestinationSite";
            this.txtDestinationSite.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDestinationSite.Size = new System.Drawing.Size(437, 62);
            this.txtDestinationSite.TabIndex = 13;
            this.txtDestinationSite.TextChanged += new System.EventHandler(this.txtDestinationSite_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Your Site Urls :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(798, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ROBO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(824, 785);
            this.Controls.Add(this.grpSeoSite);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ROBO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROBO";
            this.Load += new System.EventHandler(this.ROBO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpSeoSite.ResumeLayout(false);
            this.grpSeoSite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CefSharp.WinForms.ChromiumWebBrowser browser;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWaiteTime2;
        private System.Windows.Forms.TextBox txtDestinationSite3;
        private System.Windows.Forms.ProgressBar prgs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSeoText2;
        private System.Windows.Forms.RadioButton arpce;
        private System.Windows.Forms.RadioButton systemkaran;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConnectVpn;
        private System.Windows.Forms.Button btnCreatVpn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVPNMess;
        private System.Windows.Forms.Label lblVpnName;
        private System.Windows.Forms.GroupBox grpSeoSite;
        private System.Windows.Forms.TextBox txtDestinationSite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWaiteTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSeoText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSiteMess;
    }
}