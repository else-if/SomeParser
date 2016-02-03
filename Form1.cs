using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parser;
using CefSharp;
using CefSharp.WinForms;
using CefSharp.Internals;

namespace SomeParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser webBrowserControl = new ChromiumWebBrowser(""); 
            webBrowserControl.Load("https://auto.ria.com/search/?category_id=1&marka_id=15&model_id=1082#category_id=1&s_yers[0]=2006&po_yers[0]=0&price_do=8000&currency=1&marka_id[0]=15&model_id[0]=1082&countpage=10&page=0&power_name=1&engineVolumeFrom=&engineVolumeTo=&raceTo=125");

            webBrowserControl.FrameLoadEnd += new EventHandler<FrameLoadEndEventArgs>(webBrowserControl_FrameLoadEnd);

            //webBrowserControl.

            /*Uri uri = new Uri("https://auto.ria.com/search/?category_id=1&marka_id=15&model_id=1082#category_id=1&s_yers[0]=2006&po_yers[0]=0&price_do=8000&currency=1&marka_id[0]=15&model_id[0]=1082&countpage=10&page=0&power_name=1&engineVolumeFrom=&engineVolumeTo=&raceTo=125");

            webBrowserControl.AllowNavigation = true;
            // optional but I use this because it stops javascript errors breaking your scraper
           // webBrowserControl.ScriptErrorsSuppressed = true;
            // you want to start scraping after the document is finished loading so do it in the function you pass to this handler
            //webBrowserControl.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowserControl_DocumentCompleted);
            webBrowserControl.Navigate(uri);*/
        }

        private void webBrowserControl_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            /*HtmlElementCollection divs = webBrowserControl.Document.GetElementsByTagName("div");

            foreach (HtmlElement div in divs)
            {
                //do something
            }*/
        }
    }
}
