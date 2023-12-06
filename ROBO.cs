using CefSharp;
using CefSharp.SchemeHandler;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ROBOClicker.Model;
using ROBOClicker.Service;

namespace ROBOClicker
{
    public partial class ROBO : Form
    {
        // public ChromiumWebBrowser browser;
        #region Params
        JavascriptManager jsmanager;
        public static string menu = "";
        public static string[] urls;
        public static int waitTime = 0;
        public static string[] yourSite;
        public static string reportageLink = "";
        public static int progressValue = 0;
        public static string seoText = "";
        public static string rdoChecked = "";
        public static byte reportageCounter = 0;
        public static RoboSetting _roboSetting;
        public static ScriptFiles _scriptFiles;
        CreateConnection _createConn = new CreateConnection();
        SaveData _saveData = new SaveData();
        IPCatchService _ipCatchService = new IPCatchService();
        public bool isVpnConnected = false;
        #endregion
        public async Task InitBrowser()
        {


        }
        public ROBO()
        {
            InitializeComponent();

        }

        private void ROBO_Load(object sender, EventArgs e)
        {
            IPCatchService.IpCatch = new List<string>();
            InitialRoboSetting();
            InitialVPN();
            InitialSite();
            InitialReportageSite();
            InitialSciptFile();
            InitBrowser().GetAwaiter();
        }
        private void InitialSciptFile()
        {
            _scriptFiles = _saveData.ReadScriptFile();
            if (_scriptFiles != null)
            {

            }
        }
        private void InitialRoboSetting()
        {
            var roboSetting = _saveData.ReadRoboSetting();
            if (roboSetting == null)
            {
                MessageBox.Show("امکان اجرا وجود ندارد");
                Application.Exit();
            }

            _roboSetting = roboSetting;
        }

        private void InitialReportageSite()
        {
            var rpt = _saveData.ReadReportageSetting();
            txtSite.Text = rpt != null ? rpt.ReportageSite : "";
        }

        private void InitialSite()
        {
            var site = _saveData.ReadSiteSetting();
            if (site == null) return;
            foreach (var url in site.Urls)
                txtDestinationSite.Text += (url + Environment.NewLine);
            txtWaiteTime.Text = site.WaitTime.ToString();
            txtSeoText.Text = site.SeoText;
            grpReportage.Enabled = true;
        }

        private void InitialVPN()
        {
            var vpn = _saveData.ReadVpnSetting();
            if (vpn == null) return;
            lblVpnName2.Text = vpn.Name;
            txtServerIP.Text = vpn.ServerIP;
            txtUsername.Text = vpn.UserName;
            txtPassword.Text = vpn.Password;
            grpSeoSite.Enabled = true;
        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {

            // browser.ExecuteScriptAsync("alert('All Resources Have Loaded');");

        }
        private void OnLoadingStateChanged(object sender, LoadingStateChangedEventArgs args)
        {
            //if (!args.IsLoading)
            //{
            //    browser.ExecuteScriptAsync("document.getElementById('myButton').click();");

            //}
        }

        private void TryVpnConnect(Enums.VpnState vpnState, byte tryVpnConnect)
        {
            switch (vpnState)
            {
            case Enums.VpnState.CanNotConnect:
                if (tryVpnConnect < _roboSetting.TryVpnConnect)
                {
                    tryVpnConnect += 1;
                    TryVpnConnect(TryChangeIP(), tryVpnConnect);
                }
                break;
            case Enums.VpnState.Connected:
                JavascriptManager.loadUrl_Finishid = false;
                jsmanager = null;
                StartReportage();
                break;
            case Enums.VpnState.Error:
                timer1.Enabled = false;
                reportageCounter = _roboSetting.TryReportage;
                break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (JavascriptManager.loadUrl_Finishid)
            {
                prgs.Value += 5;
                reportageCounter++;
                if (reportageCounter < _roboSetting.TryReportage)
                {
                    TryVpnConnect(TryChangeIP(), 1);
                }
                else
                {
                    prgs.Value = 100;

                }
            }
            else
            {
                //   prgs.Value = progressValue > 100 && !JavascriptManager.loadUrl_Finishid ? 95 : progressValue;
            }

            //bunifuButton3.Enabled = true;
            //MessageBox.Show("Operation is done!");


        }

        private void browser_IsBrowserInitializedChanged(object sender, EventArgs e)
        {

        }

        private string GetMyIP()
        {
            var externalIpString = (new HttpClient().GetStringAsync("http://icanhazip.com").Result)
                .Replace("\\r\\n", "").Replace("\\n", "").Trim();
            IPAddress.TryParse(externalIpString, out var ipAddress);
            if (ipAddress != null) return ipAddress.ToString();

            string hostName = Dns.GetHostName();
            string IP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            return IP;
        }

        private void ReConnect()
        {
            _createConn.DisconnectVPN();
            _createConn.ConnectVPN(lblVpnName2.Text, txtUsername.Text, txtPassword.Text);
        }
        private Enums.VpnState TryChangeIP()
        {
            try
            {
                ReConnect();
                var counter = 0;
                while (counter < _roboSetting.TryConnect)
                {
                    if (_ipCatchService.Exist(GetMyIP()))
                        ReConnect();
                    else
                    {
                        _ipCatchService.Add(GetMyIP());
                        return Enums.VpnState.Connected;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("لطفا ویپی ان یا اینترنت خود را بررسی نمایید" + Environment.NewLine + e.Message);
                return Enums.VpnState.Error;
            }
            return Enums.VpnState.CanNotConnect;
        }

        private void StartReportage()
        {
            try
            {
                urls = txtSite.Text.Split(new[] { Environment.NewLine, "," }, StringSplitOptions.None);
                waitTime = int.Parse(txtWaiteTime.Text);
                yourSite = txtDestinationSite.Text.Split(new[] { Environment.NewLine, "," }, StringSplitOptions.None);
                reportageLink = string.IsNullOrEmpty(txtReportageLink.Text) ? string.Empty : txtReportageLink.Text;
                seoText = txtSeoText.Text;
                progressValue = 0;
                prgs.Value = 0;
                prgs.Visible = true;
                timer1.Enabled = true;
                bunifuButton3.Enabled = false;
                reportageCounter = 0;
                jsmanager = new JavascriptManager(browser);
            }
            catch (Exception e)
            {
                progressValue = 0;
                prgs.Value = 0;
                bunifuButton3.Enabled = true;
                timer1.Enabled = false;
                MessageBox.Show("متاسفانه مشکلی بوجود آمده است" + Environment.NewLine + e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isVpnConnected && !chkWithoutVpn.Checked)
            {
                MessageBox.Show("Please connect vpn!");
                return;
            }


            StartReportage();


            // rdoChecked = systemkaran.Checked ? systemkaran.Name : arpce.Name;

        }

        private void txtSite_TextChanged(object sender, EventArgs e)
        {
            if (txtSite.Text.Length > 0)
                txtSite.BackColor = Color.White;
        }

        private void txtDestinationSite_TextChanged(object sender, EventArgs e)
        {
            if (txtDestinationSite.Text.Length > 0)
                txtDestinationSite.BackColor = Color.White;
        }

        private void txtWaiteTime_TextChanged(object sender, EventArgs e)
        {
            if (txtWaiteTime.Text.Length > 0)
                txtWaiteTime.BackColor = Color.White;
        }

        private void txtSeoText_TextChanged(object sender, EventArgs e)
        {
            if (txtSeoText.Text.Length > 0)
                txtSeoText.BackColor = Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreatVpn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    if (!ValidateIPv4(txtServerIP.Text))
                    {
                        MessageBox.Show("IP not valid!");
                        return;
                    }

                    string vpnName = "ROBO_" + DateTime.Now.ToString("mmss");
                    lblVPNMess.Text = _createConn.CreateVPN(vpnName, txtServerIP.Text);
                    btnConnectVpn.Enabled = true;
                    lblVpnName2.Text = vpnName;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("متاسفانه مشکلی بوجود آمده است" + Environment.NewLine + exception.Message);
            }
        }
        public bool ValidateIPv4(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }
        private void btnConnectVpn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    if (!ValidateIPv4(txtServerIP.Text))
                    {
                        MessageBox.Show("IP not valid!");
                        return;
                    }

                    lblVPNMess.Text = "";
                    lblVPNMess.Text = _createConn.ConnectVPN(lblVpnName2.Text, txtUsername.Text, txtPassword.Text);

                    SaveVpn();
                    isVpnConnected = true;
                    grpSeoSite.Enabled = true;
                }

            }
            catch (Exception exception)
            {
                isVpnConnected = false;
                MessageBox.Show("متاسفانه مشکلی بوجود آمده است" + Environment.NewLine + exception.Message);
            }

        }

        private bool Validate()
        {
            var validate = true;
            if (string.IsNullOrEmpty(txtServerIP.Text))
            {
                txtServerIP.BackColor = Color.Wheat;
                validate = false;
            }
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.BackColor = Color.Wheat;
                validate = false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.BackColor = Color.Wheat;
                validate = false;
            }
            return validate;
        }

        private void SaveVpn()
        {
            var vpn = new Vpn()
            {
                ServerIP = txtServerIP.Text,
                UserName = txtUsername.Text,
                Password = txtPassword.Text,
                Name = lblVpnName2.Text

            };
            _saveData.WriteVpnSetting(vpn);
        }

        private void txtServerIP_TextChanged(object sender, EventArgs e)
        {
            txtServerIP.BackColor = Color.White;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SiteValidate())
            {
                var site = new Site
                {
                    Urls = txtDestinationSite.Text.Split(new[] { Environment.NewLine, "," }, StringSplitOptions.None),
                    SeoText = txtSeoText.Text,
                    WaitTime = int.Parse(txtWaiteTime.Text)
                };
                _saveData.WriteSiteSetting(site);
                lblSiteMess.Text = "Your setting is set!";
                grpReportage.Enabled = true;
            }
        }

        private bool SiteValidate()
        {

            if (string.IsNullOrEmpty(txtDestinationSite.Text))
            {
                txtDestinationSite.BackColor = Color.Wheat;
                return false;
            }
            if (string.IsNullOrEmpty(txtWaiteTime.Text))
            {
                txtWaiteTime.BackColor = Color.Wheat;
                return false;
            }
            if (string.IsNullOrEmpty(txtSeoText.Text))
            {
                txtSeoText.BackColor = Color.Wheat;
                return false;
            }
            return true;
        }

        private void txtDestinationSite_TextChanged_1(object sender, EventArgs e)
        {
            txtDestinationSite.BackColor = Color.White;
        }

        private void txtWaiteTime_TextChanged_1(object sender, EventArgs e)
        {
            txtWaiteTime.BackColor = Color.White;
        }

        private void txtSeoText_TextChanged_1(object sender, EventArgs e)
        {
            txtSeoText.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ValidationRepostageSite())
            {
                var rp = new Reportage
                {
                    ReportageSite = txtSite.Text
                };
                _saveData.WriteReportageSetting(rp);
                lblReportageMess.Text = "Success save reportage site!";
            }
        }

        private bool ValidationRepostageSite()
        {
            if (string.IsNullOrEmpty(txtSite.Text))
            {
                txtSite.BackColor = Color.Wheat;
                return false;
            }

            return true;
        }

        private void txtSite_TextChanged_1(object sender, EventArgs e)
        {
            txtSite.BackColor = Color.White;
        }
        private void chkWithoutVpn_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkWithoutVpn.Checked || Validate())
                grpSeoSite.Enabled = true;
            else
                grpSeoSite.Enabled = false;
        }

        private void txtWaiteTime_TextChanged_2(object sender, EventArgs e)
        {
            txtWaiteTime.BackColor = Color.White;
        }

        private void txtDestinationSite_TextChanged_2(object sender, EventArgs e)
        {
            if (txtDestinationSite.Text.Length > 0)
                txtDestinationSite.BackColor = Color.White;
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpReportage_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddScript_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Please select an script file.";

            if (dialog.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
    public class JavascriptManager : ILoadHandler, IRenderProcessMessageHandler
    {
        string injection = "window.InjectedObject = {};";
        public static int countLoader = 0;
        public ChromiumWebBrowser browser_temp;
        public static bool loadUrl_Finishid = false;
        public int index = 0;
        public JavascriptManager(ChromiumWebBrowser browser)
        {
            browser_temp = browser;
            browser_temp.Name = "zagoli";
            LoadUrl(ROBO.urls[index], browser);
        }
        public void LoadUrl(string url, ChromiumWebBrowser browser = null)
        {
            if (browser != null)
            {
                browser.LoadHandler = this;
                browser.RenderProcessMessageHandler = this;
                browser.LoadUrl(url);
                browser_temp = browser;
            }
            else
            {
                browser_temp.LoadHandler = this;
                browser_temp.RenderProcessMessageHandler = this;
                //browser_temp.Address = url;

                browser_temp.LoadUrl(url);
            }


        }
        public void OnContextCreated(IWebBrowser browserControl, IBrowser browser, IFrame frame)
        {
            frame.ExecuteJavaScriptAsync(injection);
        }

        public void OnContextReleased(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame)
        {
            // throw new NotImplementedException();
        }

        public void OnFocusedNodeChanged(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IDomNode node)
        {
            //throw new NotImplementedException();
        }

        public void OnFrameLoadEnd(IWebBrowser chromiumWebBrowser, FrameLoadEndEventArgs frameLoadEndArgs)
        {
            try
            {
                if (frameLoadEndArgs.Frame.IsMain)
                {

                    string query = "";
                    if (chromiumWebBrowser.Address.Contains(ROBO.yourSite[0]))
                    {
                        Thread.Sleep(ROBO.waitTime);
                        ClickSistemkaran(ref query);
                    }
                    else { LoadSistemKar(ref query); ROBO.progressValue += (100 / ROBO.urls.Length); }


                    //---------------------------------------------

                    frameLoadEndArgs.Frame.ExecuteJavaScriptAsync(query);


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("متاسقانه مشکلی بوجود آمده است لطفا ربات را ببندید دوباره تلاش کنید");
                Application.Exit();
            }

        }
        public string menu = "";
        public bool finishLoading = false;
        private void ClickSistemkaran(ref string query)
        {
            if (finishLoading)
            {
                index++;
                if (index < ROBO.urls.Length)
                {

                    LoadUrl(ROBO.urls[index]);
                    // ROBO.ssssss += ROBO.urls[index]+"####";
                }
                else
                {
                    ROBO.urls = new string[] { };
                    index = 0;
                    menu = "";
                    loadUrl_Finishid = true;
                    return;
                };
            }
            menu = GetMenu(menu);
            query += "const m=document.getElementById('" + menu + "').getElementsByTagName('a')[0];" + Environment.NewLine;
            query += "m.click();" + Environment.NewLine;
            if (menu.Equals("menu-item-69") || menu.Equals("menu-item-5600"))
                finishLoading = true;
        }
        private string GetMenu(string menu)
        {
            string nextMenu = "";
            if (ROBO.rdoChecked == "systemkaran")
            {
                switch (menu)
                {
                case "":
                    nextMenu = "menu-item-11";
                    break;
                case "menu-item-11":
                    nextMenu = "menu-item-150";
                    break;
                case "menu-item-150":
                    nextMenu = "menu-item-69";
                    break;
                    //case "menu-item-69":
                    //    nextMenu = "menu-item-28";
                    //    break;
                    //case "menu-item-28":
                    //    nextMenu = "menu-item-28";
                    //    break;
                }
            }
            else if (ROBO.rdoChecked == "arpce")
            {
                switch (menu)
                {
                case "":
                    nextMenu = "menu-item-5596";
                    break;
                case "menu-item-5596":
                    nextMenu = "menu-item-5595";
                    break;
                case "menu-item-5595":
                    nextMenu = "menu-item-5597";
                    break;
                case "menu-item-5597":
                    nextMenu = "menu-item-5600";

                    break;
                }
            }
            return nextMenu;

        }
        private void LoadSistemKar(ref string query)
        {
            query += "const aHtml=document.createElement('a');" + Environment.NewLine;
            query += "aHtml.setAttribute('id','aSeo');" + Environment.NewLine;
            query += "aHtml.href='" + ROBO.yourSite + "';" + Environment.NewLine;
            query += "aHtml.text='" + ROBO.seoText + "';" + Environment.NewLine;
            query += "document.body.appendChild(aHtml);" + Environment.NewLine;
            query += "document.getElementById('aSeo').click();" + Environment.NewLine;

        }
        private void QueryClicker(ref string query)
        {

            //----------------------------------------------
            query += "var iFramHtml=document.createElement('iframe');" + Environment.NewLine;
            query += "iFramHtml.id='ifr';" + Environment.NewLine;
            query += "document.body.appendChild(iFramHtml);" + Environment.NewLine;
            query += "var elms=document.getElementsByClassName('sVXRqc');" + Environment.NewLine;
            query += "for (let i = 0; i < elms.length; i++){" + Environment.NewLine;
            query += "var link=elms[i].getAttribute('href');" + Environment.NewLine;
            query += "var site=elms[i].getAttribute('data-pcu');" + Environment.NewLine;
            query += "if(site.includes('https://www.golbazar.com')){" + Environment.NewLine;
            query += "document.getElementById('ifr').setAttribute('src', link);" + Environment.NewLine;
            query += "}" + Environment.NewLine;
            query += "}" + Environment.NewLine;

        }
        public void OnFrameLoadStart(IWebBrowser chromiumWebBrowser, FrameLoadStartEventArgs frameLoadStartArgs)
        {

        }

        public void OnLoadError(IWebBrowser chromiumWebBrowser, LoadErrorEventArgs loadErrorArgs)
        {

        }

        public void OnLoadingStateChange(IWebBrowser chromiumWebBrowser, LoadingStateChangedEventArgs loadingStateChangedArgs)
        {

        }

        public void OnUncaughtException(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, JavascriptException exception)
        {
            throw new NotImplementedException();
        }
    }
}

