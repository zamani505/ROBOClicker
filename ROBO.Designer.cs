
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.arpce = new System.Windows.Forms.RadioButton();
            this.systemkaran = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSeoText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prgs = new System.Windows.Forms.ProgressBar();
            this.txtWaiteTime = new System.Windows.Forms.TextBox();
            this.txtDestinationSite = new System.Windows.Forms.TextBox();
            timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.txtSite.Location = new System.Drawing.Point(460, 22);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ROBOClicker.Properties.Resources.media_player;
            this.pictureBox1.Location = new System.Drawing.Point(19, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 120);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.arpce);
            this.groupBox1.Controls.Add(this.systemkaran);
            this.groupBox1.Controls.Add(this.browser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSeoText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.prgs);
            this.groupBox1.Controls.Add(this.txtWaiteTime);
            this.groupBox1.Controls.Add(this.txtDestinationSite);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 422);
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
            // txtSeoText
            // 
            this.txtSeoText.Location = new System.Drawing.Point(448, 317);
            this.txtSeoText.Name = "txtSeoText";
            this.txtSeoText.Size = new System.Drawing.Size(169, 20);
            this.txtSeoText.TabIndex = 9;
            this.txtSeoText.Text = "گواهینامه ایزو";
            this.txtSeoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSeoText.TextChanged += new System.EventHandler(this.txtSeoText_TextChanged);
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
            // txtWaiteTime
            // 
            this.txtWaiteTime.Location = new System.Drawing.Point(448, 289);
            this.txtWaiteTime.Name = "txtWaiteTime";
            this.txtWaiteTime.Size = new System.Drawing.Size(169, 20);
            this.txtWaiteTime.TabIndex = 5;
            this.txtWaiteTime.Text = "120000";
            this.txtWaiteTime.TextChanged += new System.EventHandler(this.txtWaiteTime_TextChanged);
            // 
            // txtDestinationSite
            // 
            this.txtDestinationSite.Location = new System.Drawing.Point(448, 257);
            this.txtDestinationSite.Name = "txtDestinationSite";
            this.txtDestinationSite.Size = new System.Drawing.Size(169, 20);
            this.txtDestinationSite.TabIndex = 4;
            this.txtDestinationSite.Text = "https://sistemkaran.ir/%da%af%d9%88%d8%a7%d9%87%db%8c%d9%86%d8%a7%d9%85%d9%87-%d8" +
    "%a7%db%8c%d8%b2%d9%88/";
            this.txtDestinationSite.TextChanged += new System.EventHandler(this.txtDestinationSite_TextChanged);
            // 
            // ROBO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(824, 446);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "ROBO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROBO";
            this.Load += new System.EventHandler(this.ROBO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CefSharp.WinForms.ChromiumWebBrowser browser;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWaiteTime;
        private System.Windows.Forms.TextBox txtDestinationSite;
        private System.Windows.Forms.ProgressBar prgs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSeoText;
        private System.Windows.Forms.RadioButton arpce;
        private System.Windows.Forms.RadioButton systemkaran;
    }
}