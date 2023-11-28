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
      //  public static string ssssss = "";
        public async Task InitBrowser()
        {


        }
        public ROBO()
        {
            InitializeComponent();

        }

        private void ROBO_Load(object sender, EventArgs e)
        {
            InitBrowser().GetAwaiter();
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
            if (string.IsNullOrEmpty(txtWaiteTime.Text))
            {
                MessageBox.Show("Please enter wait time");
                txtWaiteTime.BackColor = Color.Wheat;
                return;
            }
            if (string.IsNullOrEmpty(txtDestinationSite.Text))
            {
                MessageBox.Show("Please enter your site");
                txtDestinationSite.BackColor = Color.Wheat;
                return;
            }
            if (string.IsNullOrEmpty(txtSeoText.Text))
            {
                MessageBox.Show("Please enter seo text");
                txtSeoText.BackColor = Color.Wheat;
                return;
            }
            rdoChecked = systemkaran.Checked ? systemkaran.Name : arpce.Name;
            urls = txtSite.Text.Split(',');
            waitTime = int.Parse(txtWaiteTime.Text);
            yourSite = txtDestinationSite.Text;
            seoText = txtSeoText.Text;
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
            LoadUrl(ROBO.urls[index],browser);
        }
        public void LoadUrl(string url, ChromiumWebBrowser browser=null)
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
                if (frameLoadEndArgs.Frame.IsMain )
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
         menu= GetMenu(menu);
            query += "const m=document.getElementById('" + menu + "').getElementsByTagName('a')[0];" + Environment.NewLine;
            query += "m.click();" + Environment.NewLine;
            if (menu.Equals("menu-item-69") || menu.Equals("menu-item-5600"))
                finishLoading = true;
        }
        private string GetMenu(string menu) {
            string nextMenu = "";
            if (ROBO.rdoChecked == "systemkaran") {
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
            else if(ROBO.rdoChecked== "arpce")
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

