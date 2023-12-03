using CefSharp;
using CefSharp.SchemeHandler;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ROBOClicker.Model;
using ROBOClicker.Service;

//using CefSharp;
//using CefSharp.WinForms;

namespace ROBOClicker
{
    public partial class ROBO : Form
    {
        // public ChromiumWebBrowser browser;
        JavascriptManager jsmanager;
        public static string menu = "";
        public static string[] urls;
        public static int waitTime = 0;
        public static string yourSite = "";
        public static int progressValue = 0;
        public static string seoText = "";
        public static string rdoChecked = "";
        CreateConnection createConn = new CreateConnection();
        SaveData saveData = new SaveData();
      
        public async Task InitBrowser()
        {


        }
        public ROBO()
        {
            InitializeComponent();

        }

        private void ROBO_Load(object sender, EventArgs e)
        {
            InitialVPN();
            InitialSite();
            InitBrowser().GetAwaiter();
        }

        private void InitialSite()
        {
            var site = saveData.ReadSiteSetting();
            if(site==null)return;
            foreach (var url in site.Urls)
                txtDestinationSite.Text +=( url + Environment.NewLine);
            txtWaiteTime.Text = site.WaitTime.ToString();
            txtSeoText.Text = site.SeoText;

        }

        private void InitialVPN()
        {
            var vpn = saveData.ReadVpnSetting();
            if (vpn == null)return;
            lblVpnName.Text=vpn.Name;
            txtServerIP.Text=vpn.ServerIP;
            txtUsername.Text = vpn.UserName;
            txtPassword.Text= vpn.Password;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (JavascriptManager.loadUrl_Finishid)
            {
                JavascriptManager.loadUrl_Finishid = false;
                prgs.Value = 100;
                button1.Enabled = true;
                // MessageBox.Show(ssssss);
                MessageBox.Show("Operation is done!");

            }
            else
                prgs.Value = progressValue > 100 && !JavascriptManager.loadUrl_Finishid ? 95 : progressValue;





        }

        private void browser_IsBrowserInitializedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            if (string.IsNullOrEmpty(txtSite.Text))
            {
                MessageBox.Show("Please enter url site");
                txtSite.BackColor = Color.Wheat;
                return;
            }
            if (string.IsNullOrEmpty(txtWaiteTime2.Text))
            {
                MessageBox.Show("Please enter wait time");
                txtWaiteTime2.BackColor = Color.Wheat;
                return;
            }
            if (string.IsNullOrEmpty(txtDestinationSite3.Text))
            {
                MessageBox.Show("Please enter your site");
                txtDestinationSite3.BackColor = Color.Wheat;
                return;
            }
            if (string.IsNullOrEmpty(txtSeoText2.Text))
            {
                MessageBox.Show("Please enter seo text");
                txtSeoText2.BackColor = Color.Wheat;
                return;
            }
            rdoChecked = systemkaran.Checked ? systemkaran.Name : arpce.Name;
            urls = txtSite.Text.Split(',');
            waitTime = int.Parse(txtWaiteTime2.Text);
            yourSite = txtDestinationSite3.Text;
            seoText = txtSeoText2.Text;
            progressValue = 0;
            prgs.Value = 0;
            button1.Enabled = false;
            jsmanager = new JavascriptManager(browser);
        }

        private void txtSite_TextChanged(object sender, EventArgs e)
        {
            if (txtSite.Text.Length > 0)
                txtSite.BackColor = Color.White;
        }

        private void txtDestinationSite_TextChanged(object sender, EventArgs e)
        {
            if (txtDestinationSite3.Text.Length > 0)
                txtDestinationSite3.BackColor = Color.White;
        }

        private void txtWaiteTime_TextChanged(object sender, EventArgs e)
        {
            if (txtWaiteTime2.Text.Length > 0)
                txtWaiteTime2.BackColor = Color.White;
        }

        private void txtSeoText_TextChanged(object sender, EventArgs e)
        {
            if (txtSeoText2.Text.Length > 0)
                txtSeoText2.BackColor = Color.White;
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
                    lblVPNMess.Text = createConn.CreateVPN(vpnName, txtServerIP.Text);
                    btnConnectVpn.Enabled = true;
                    lblVpnName.Text = vpnName;
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
                    lblVPNMess.Text = createConn.ConnectVPN(lblVpnName.Text, txtUsername.Text, txtPassword.Text);
                    SaveVpn();
                }

            }
            catch (Exception exception)
            {
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
                ServerIP = txtServerIP.Text,UserName = txtUsername.Text,Password = txtPassword.Text,
                Name = lblVpnName.Text
                
            };
            saveData.WriteVpnSetting(vpn);
        }

        private void txtServerIP_TextChanged(object sender, EventArgs e)
        {
            txtServerIP.BackColor=Color.White;
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
                    Urls = txtDestinationSite.Text.Split(new []{Environment.NewLine},StringSplitOptions.None),
                    SeoText = txtSeoText.Text,
                    WaitTime = int.Parse(txtWaiteTime.Text)
                };
                saveData.WriteSiteSetting(site);
                lblSiteMess.Text = "Your setting is set!";
            }
        }

        private bool SiteValidate()
        {

            if (string.IsNullOrEmpty(txtDestinationSite.Text))
            {
                txtDestinationSite.BackColor=Color.Wheat;
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
                    if (chromiumWebBrowser.Address.Contains(ROBO.yourSite))
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

