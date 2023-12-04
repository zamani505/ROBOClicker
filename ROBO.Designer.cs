
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ROBO));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.browser = new CefSharp.WinForms.ChromiumWebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.prgs = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblVpnName = new System.Windows.Forms.Label();
            this.lblVPNMess = new System.Windows.Forms.Label();
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
            this.grpReportage = new System.Windows.Forms.GroupBox();
            this.lblReportageMess = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtServerIP = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtUsername = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.chkWithoutVpn = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnCreatVpn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnConnectVpn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.grpSeoSite.SuspendLayout();
            this.grpReportage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.browser.Location = new System.Drawing.Point(537, 19);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(261, 242);
            this.browser.TabIndex = 0;
            this.browser.LoadingStateChanged += new System.EventHandler<CefSharp.LoadingStateChangedEventArgs>(this.chromiumWebBrowser1_LoadingStateChanged);
            this.browser.IsBrowserInitializedChanged += new System.EventHandler(this.browser_IsBrowserInitializedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prgs
            // 
            this.prgs.Location = new System.Drawing.Point(13, 684);
            this.prgs.Name = "prgs";
            this.prgs.Size = new System.Drawing.Size(800, 23);
            this.prgs.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConnectVpn);
            this.groupBox2.Controls.Add(this.btnCreatVpn);
            this.groupBox2.Controls.Add(this.bunifuLabel1);
            this.groupBox2.Controls.Add(this.chkWithoutVpn);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.txtServerIP);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.lblVpnName);
            this.groupBox2.Controls.Add(this.lblVPNMess);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(8, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(805, 148);
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
            // grpSeoSite
            // 
            this.grpSeoSite.Controls.Add(this.pictureBox1);
            this.grpSeoSite.Controls.Add(this.lblSiteMess);
            this.grpSeoSite.Controls.Add(this.label10);
            this.grpSeoSite.Controls.Add(this.button2);
            this.grpSeoSite.Controls.Add(this.txtSeoText);
            this.grpSeoSite.Controls.Add(this.label9);
            this.grpSeoSite.Controls.Add(this.txtWaiteTime);
            this.grpSeoSite.Controls.Add(this.label8);
            this.grpSeoSite.Controls.Add(this.txtDestinationSite);
            this.grpSeoSite.Controls.Add(this.label7);
            this.grpSeoSite.Enabled = false;
            this.grpSeoSite.Location = new System.Drawing.Point(8, 188);
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
            this.button2.Text = "Save YorSite Configuration";
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
            this.label9.Location = new System.Drawing.Point(34, 118);
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
            this.label8.Location = new System.Drawing.Point(28, 92);
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
            // grpReportage
            // 
            this.grpReportage.Controls.Add(this.lblReportageMess);
            this.grpReportage.Controls.Add(this.button3);
            this.grpReportage.Controls.Add(this.txtSite);
            this.grpReportage.Controls.Add(this.label1);
            this.grpReportage.Controls.Add(this.browser);
            this.grpReportage.Controls.Add(this.button1);
            this.grpReportage.Enabled = false;
            this.grpReportage.Location = new System.Drawing.Point(9, 379);
            this.grpReportage.Name = "grpReportage";
            this.grpReportage.Size = new System.Drawing.Size(804, 296);
            this.grpReportage.TabIndex = 8;
            this.grpReportage.TabStop = false;
            // 
            // lblReportageMess
            // 
            this.lblReportageMess.AutoSize = true;
            this.lblReportageMess.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblReportageMess.Location = new System.Drawing.Point(436, 271);
            this.lblReportageMess.Name = "lblReportageMess";
            this.lblReportageMess.Size = new System.Drawing.Size(0, 13);
            this.lblReportageMess.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(353, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Save RepostageSite";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSite
            // 
            this.txtSite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSite.Location = new System.Drawing.Point(94, 17);
            this.txtSite.Multiline = true;
            this.txtSite.Name = "txtSite";
            this.txtSite.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSite.Size = new System.Drawing.Size(437, 174);
            this.txtSite.TabIndex = 15;
            this.txtSite.Text = resources.GetString("txtSite.Text");
            this.txtSite.TextChanged += new System.EventHandler(this.txtSite_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Reportage Site :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ROBOClicker.Properties.Resources.yourWebSite;
            this.pictureBox1.Location = new System.Drawing.Point(628, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::ROBOClicker.Properties.Resources.close_window_32_;
            this.pictureBox2.Location = new System.Drawing.Point(798, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ROBOClicker.Properties.Resources.vpn;
            this.pictureBox3.Location = new System.Drawing.Point(628, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 99);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // txtServerIP
            // 
            this.txtServerIP.AcceptsReturn = false;
            this.txtServerIP.AcceptsTab = false;
            this.txtServerIP.AnimationSpeed = 200;
            this.txtServerIP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtServerIP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtServerIP.AutoSizeHeight = true;
            this.txtServerIP.BackColor = System.Drawing.Color.Transparent;
            this.txtServerIP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtServerIP.BackgroundImage")));
            this.txtServerIP.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtServerIP.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtServerIP.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtServerIP.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtServerIP.BorderRadius = 1;
            this.txtServerIP.BorderThickness = 1;
            this.txtServerIP.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtServerIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtServerIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServerIP.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtServerIP.DefaultText = "";
            this.txtServerIP.FillColor = System.Drawing.Color.White;
            this.txtServerIP.HideSelection = true;
            this.txtServerIP.IconLeft = null;
            this.txtServerIP.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServerIP.IconPadding = 10;
            this.txtServerIP.IconRight = null;
            this.txtServerIP.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServerIP.Lines = new string[0];
            this.txtServerIP.Location = new System.Drawing.Point(44, 23);
            this.txtServerIP.MaxLength = 32767;
            this.txtServerIP.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtServerIP.Modified = false;
            this.txtServerIP.Multiline = true;
            this.txtServerIP.Name = "txtServerIP";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtServerIP.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtServerIP.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtServerIP.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtServerIP.OnIdleState = stateProperties12;
            this.txtServerIP.Padding = new System.Windows.Forms.Padding(3);
            this.txtServerIP.PasswordChar = '\0';
            this.txtServerIP.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtServerIP.PlaceholderText = "Server IP";
            this.txtServerIP.ReadOnly = false;
            this.txtServerIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServerIP.SelectedText = "";
            this.txtServerIP.SelectionLength = 0;
            this.txtServerIP.SelectionStart = 0;
            this.txtServerIP.ShortcutsEnabled = true;
            this.txtServerIP.Size = new System.Drawing.Size(214, 31);
            this.txtServerIP.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtServerIP.TabIndex = 21;
            this.txtServerIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtServerIP.TextMarginBottom = 0;
            this.txtServerIP.TextMarginLeft = 3;
            this.txtServerIP.TextMarginTop = 1;
            this.txtServerIP.TextPlaceholder = "Server IP";
            this.txtServerIP.UseSystemPasswordChar = false;
            this.txtServerIP.WordWrap = true;
            // 
            // txtUsername
            // 
            this.txtUsername.AcceptsReturn = false;
            this.txtUsername.AcceptsTab = false;
            this.txtUsername.AnimationSpeed = 200;
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsername.AutoSizeHeight = true;
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUsername.BackgroundImage")));
            this.txtUsername.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtUsername.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUsername.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtUsername.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtUsername.BorderRadius = 1;
            this.txtUsername.BorderThickness = 1;
            this.txtUsername.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtUsername.DefaultText = "";
            this.txtUsername.FillColor = System.Drawing.Color.White;
            this.txtUsername.HideSelection = true;
            this.txtUsername.IconLeft = null;
            this.txtUsername.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.IconPadding = 10;
            this.txtUsername.IconRight = null;
            this.txtUsername.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(44, 57);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUsername.Modified = false;
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsername.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUsername.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsername.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsername.OnIdleState = stateProperties8;
            this.txtUsername.Padding = new System.Windows.Forms.Padding(3);
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtUsername.PlaceholderText = "UserName";
            this.txtUsername.ReadOnly = false;
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(214, 31);
            this.txtUsername.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtUsername.TabIndex = 22;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.TextMarginBottom = 0;
            this.txtUsername.TextMarginLeft = 3;
            this.txtUsername.TextMarginTop = 1;
            this.txtUsername.TextPlaceholder = "UserName";
            this.txtUsername.UseSystemPasswordChar = false;
            this.txtUsername.WordWrap = true;
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.AnimationSpeed = 200;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.AutoSizeHeight = true;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPassword.BorderRadius = 1;
            this.txtPassword.BorderThickness = 1;
            this.txtPassword.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.White;
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = null;
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.IconPadding = 10;
            this.txtPassword.IconRight = null;
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(44, 92);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPassword.Modified = false;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnIdleState = stateProperties4;
            this.txtPassword.Padding = new System.Windows.Forms.Padding(3);
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(214, 31);
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPassword.TabIndex = 23;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMarginBottom = 0;
            this.txtPassword.TextMarginLeft = 3;
            this.txtPassword.TextMarginTop = 1;
            this.txtPassword.TextPlaceholder = "Password";
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.WordWrap = true;
            // 
            // chkWithoutVpn
            // 
            this.chkWithoutVpn.AllowBindingControlAnimation = true;
            this.chkWithoutVpn.AllowBindingControlColorChanges = false;
            this.chkWithoutVpn.AllowBindingControlLocation = true;
            this.chkWithoutVpn.AllowCheckBoxAnimation = true;
            this.chkWithoutVpn.AllowCheckmarkAnimation = true;
            this.chkWithoutVpn.AllowOnHoverStates = true;
            this.chkWithoutVpn.AutoCheck = true;
            this.chkWithoutVpn.BackColor = System.Drawing.Color.Transparent;
            this.chkWithoutVpn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkWithoutVpn.BackgroundImage")));
            this.chkWithoutVpn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkWithoutVpn.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.chkWithoutVpn.BorderRadius = 12;
            this.chkWithoutVpn.Checked = false;
            this.chkWithoutVpn.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.chkWithoutVpn.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkWithoutVpn.CustomCheckmarkImage = null;
            this.chkWithoutVpn.Location = new System.Drawing.Point(276, 95);
            this.chkWithoutVpn.MinimumSize = new System.Drawing.Size(17, 17);
            this.chkWithoutVpn.Name = "chkWithoutVpn";
            this.chkWithoutVpn.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.chkWithoutVpn.OnCheck.BorderRadius = 12;
            this.chkWithoutVpn.OnCheck.BorderThickness = 2;
            this.chkWithoutVpn.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.chkWithoutVpn.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.chkWithoutVpn.OnCheck.CheckmarkThickness = 2;
            this.chkWithoutVpn.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.chkWithoutVpn.OnDisable.BorderRadius = 12;
            this.chkWithoutVpn.OnDisable.BorderThickness = 2;
            this.chkWithoutVpn.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkWithoutVpn.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.chkWithoutVpn.OnDisable.CheckmarkThickness = 2;
            this.chkWithoutVpn.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.chkWithoutVpn.OnHoverChecked.BorderRadius = 12;
            this.chkWithoutVpn.OnHoverChecked.BorderThickness = 2;
            this.chkWithoutVpn.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.chkWithoutVpn.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.chkWithoutVpn.OnHoverChecked.CheckmarkThickness = 2;
            this.chkWithoutVpn.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.chkWithoutVpn.OnHoverUnchecked.BorderRadius = 12;
            this.chkWithoutVpn.OnHoverUnchecked.BorderThickness = 1;
            this.chkWithoutVpn.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkWithoutVpn.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.chkWithoutVpn.OnUncheck.BorderRadius = 12;
            this.chkWithoutVpn.OnUncheck.BorderThickness = 1;
            this.chkWithoutVpn.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkWithoutVpn.Size = new System.Drawing.Size(21, 21);
            this.chkWithoutVpn.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.chkWithoutVpn.TabIndex = 24;
            this.chkWithoutVpn.ThreeState = false;
            this.chkWithoutVpn.ToolTipText = "No Vpn";
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel1.Location = new System.Drawing.Point(304, 100);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(56, 15);
            this.bunifuLabel1.TabIndex = 25;
            this.bunifuLabel1.Text = "UseNoVpn";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnCreatVpn
            // 
            this.btnCreatVpn.AllowAnimations = true;
            this.btnCreatVpn.AllowMouseEffects = true;
            this.btnCreatVpn.AllowToggling = false;
            this.btnCreatVpn.AnimationSpeed = 200;
            this.btnCreatVpn.AutoGenerateColors = false;
            this.btnCreatVpn.AutoRoundBorders = false;
            this.btnCreatVpn.AutoSizeLeftIcon = true;
            this.btnCreatVpn.AutoSizeRightIcon = true;
            this.btnCreatVpn.BackColor = System.Drawing.Color.Transparent;
            this.btnCreatVpn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnCreatVpn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreatVpn.BackgroundImage")));
            this.btnCreatVpn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreatVpn.ButtonText = "Create Vpn Connection";
            this.btnCreatVpn.ButtonTextMarginLeft = 0;
            this.btnCreatVpn.ColorContrastOnClick = 45;
            this.btnCreatVpn.ColorContrastOnHover = 45;
            this.btnCreatVpn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnCreatVpn.CustomizableEdges = borderEdges2;
            this.btnCreatVpn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCreatVpn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCreatVpn.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnCreatVpn.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnCreatVpn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCreatVpn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreatVpn.ForeColor = System.Drawing.Color.White;
            this.btnCreatVpn.IconLeft = null;
            this.btnCreatVpn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreatVpn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCreatVpn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCreatVpn.IconMarginLeft = 11;
            this.btnCreatVpn.IconPadding = 10;
            this.btnCreatVpn.IconRight = null;
            this.btnCreatVpn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreatVpn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCreatVpn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCreatVpn.IconSize = 25;
            this.btnCreatVpn.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnCreatVpn.IdleBorderRadius = 0;
            this.btnCreatVpn.IdleBorderThickness = 0;
            this.btnCreatVpn.IdleFillColor = System.Drawing.Color.Empty;
            this.btnCreatVpn.IdleIconLeftImage = null;
            this.btnCreatVpn.IdleIconRightImage = null;
            this.btnCreatVpn.IndicateFocus = false;
            this.btnCreatVpn.Location = new System.Drawing.Point(427, 22);
            this.btnCreatVpn.Name = "btnCreatVpn";
            this.btnCreatVpn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCreatVpn.OnDisabledState.BorderRadius = 1;
            this.btnCreatVpn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreatVpn.OnDisabledState.BorderThickness = 1;
            this.btnCreatVpn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCreatVpn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCreatVpn.OnDisabledState.IconLeftImage = null;
            this.btnCreatVpn.OnDisabledState.IconRightImage = null;
            this.btnCreatVpn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnCreatVpn.onHoverState.BorderRadius = 1;
            this.btnCreatVpn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreatVpn.onHoverState.BorderThickness = 1;
            this.btnCreatVpn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnCreatVpn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCreatVpn.onHoverState.IconLeftImage = null;
            this.btnCreatVpn.onHoverState.IconRightImage = null;
            this.btnCreatVpn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCreatVpn.OnIdleState.BorderRadius = 1;
            this.btnCreatVpn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreatVpn.OnIdleState.BorderThickness = 1;
            this.btnCreatVpn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnCreatVpn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCreatVpn.OnIdleState.IconLeftImage = null;
            this.btnCreatVpn.OnIdleState.IconRightImage = null;
            this.btnCreatVpn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCreatVpn.OnPressedState.BorderRadius = 1;
            this.btnCreatVpn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreatVpn.OnPressedState.BorderThickness = 1;
            this.btnCreatVpn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCreatVpn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCreatVpn.OnPressedState.IconLeftImage = null;
            this.btnCreatVpn.OnPressedState.IconRightImage = null;
            this.btnCreatVpn.Size = new System.Drawing.Size(178, 36);
            this.btnCreatVpn.TabIndex = 27;
            this.btnCreatVpn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreatVpn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCreatVpn.TextMarginLeft = 0;
            this.btnCreatVpn.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCreatVpn.UseDefaultRadiusAndThickness = true;
            // 
            // btnConnectVpn
            // 
            this.btnConnectVpn.AllowAnimations = true;
            this.btnConnectVpn.AllowMouseEffects = true;
            this.btnConnectVpn.AllowToggling = false;
            this.btnConnectVpn.AnimationSpeed = 200;
            this.btnConnectVpn.AutoGenerateColors = false;
            this.btnConnectVpn.AutoRoundBorders = false;
            this.btnConnectVpn.AutoSizeLeftIcon = true;
            this.btnConnectVpn.AutoSizeRightIcon = true;
            this.btnConnectVpn.BackColor = System.Drawing.Color.Transparent;
            this.btnConnectVpn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnConnectVpn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnectVpn.BackgroundImage")));
            this.btnConnectVpn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConnectVpn.ButtonText = "Connect To Vpn";
            this.btnConnectVpn.ButtonTextMarginLeft = 0;
            this.btnConnectVpn.ColorContrastOnClick = 45;
            this.btnConnectVpn.ColorContrastOnHover = 45;
            this.btnConnectVpn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnConnectVpn.CustomizableEdges = borderEdges1;
            this.btnConnectVpn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConnectVpn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConnectVpn.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnConnectVpn.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnConnectVpn.Enabled = false;
            this.btnConnectVpn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnConnectVpn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConnectVpn.ForeColor = System.Drawing.Color.White;
            this.btnConnectVpn.IconLeft = null;
            this.btnConnectVpn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnectVpn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnConnectVpn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnConnectVpn.IconMarginLeft = 11;
            this.btnConnectVpn.IconPadding = 10;
            this.btnConnectVpn.IconRight = null;
            this.btnConnectVpn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnectVpn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnConnectVpn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnConnectVpn.IconSize = 25;
            this.btnConnectVpn.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnConnectVpn.IdleBorderRadius = 0;
            this.btnConnectVpn.IdleBorderThickness = 0;
            this.btnConnectVpn.IdleFillColor = System.Drawing.Color.Empty;
            this.btnConnectVpn.IdleIconLeftImage = null;
            this.btnConnectVpn.IdleIconRightImage = null;
            this.btnConnectVpn.IndicateFocus = false;
            this.btnConnectVpn.Location = new System.Drawing.Point(427, 64);
            this.btnConnectVpn.Name = "btnConnectVpn";
            this.btnConnectVpn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConnectVpn.OnDisabledState.BorderRadius = 1;
            this.btnConnectVpn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConnectVpn.OnDisabledState.BorderThickness = 1;
            this.btnConnectVpn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConnectVpn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConnectVpn.OnDisabledState.IconLeftImage = null;
            this.btnConnectVpn.OnDisabledState.IconRightImage = null;
            this.btnConnectVpn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnConnectVpn.onHoverState.BorderRadius = 1;
            this.btnConnectVpn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConnectVpn.onHoverState.BorderThickness = 1;
            this.btnConnectVpn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnConnectVpn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnConnectVpn.onHoverState.IconLeftImage = null;
            this.btnConnectVpn.onHoverState.IconRightImage = null;
            this.btnConnectVpn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnConnectVpn.OnIdleState.BorderRadius = 1;
            this.btnConnectVpn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConnectVpn.OnIdleState.BorderThickness = 1;
            this.btnConnectVpn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnConnectVpn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnConnectVpn.OnIdleState.IconLeftImage = null;
            this.btnConnectVpn.OnIdleState.IconRightImage = null;
            this.btnConnectVpn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConnectVpn.OnPressedState.BorderRadius = 1;
            this.btnConnectVpn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConnectVpn.OnPressedState.BorderThickness = 1;
            this.btnConnectVpn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConnectVpn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnConnectVpn.OnPressedState.IconLeftImage = null;
            this.btnConnectVpn.OnPressedState.IconRightImage = null;
            this.btnConnectVpn.Size = new System.Drawing.Size(178, 36);
            this.btnConnectVpn.TabIndex = 28;
            this.btnConnectVpn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConnectVpn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConnectVpn.TextMarginLeft = 0;
            this.btnConnectVpn.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnConnectVpn.UseDefaultRadiusAndThickness = true;
            // 
            // ROBO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(824, 719);
            this.Controls.Add(this.grpReportage);
            this.Controls.Add(this.grpSeoSite);
            this.Controls.Add(this.prgs);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ROBO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROBO";
            this.Load += new System.EventHandler(this.ROBO_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpSeoSite.ResumeLayout(false);
            this.grpSeoSite.PerformLayout();
            this.grpReportage.ResumeLayout(false);
            this.grpReportage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CefSharp.WinForms.ChromiumWebBrowser browser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar prgs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
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
        private System.Windows.Forms.GroupBox grpReportage;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblReportageMess;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.UI.WinForms.BunifuTextBox txtServerIP;
        private Bunifu.UI.WinForms.BunifuTextBox txtUsername;
        private Bunifu.UI.WinForms.BunifuTextBox txtPassword;
        private Bunifu.UI.WinForms.BunifuCheckBox chkWithoutVpn;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCreatVpn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnConnectVpn;
    }
}