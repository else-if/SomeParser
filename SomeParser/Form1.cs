using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.Internals;
using CefSharp.WinForms;

namespace SomeParser
{
    public partial class Form1 : Form
    {
        private ChromiumWebBrowser m_chromeBrowser;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cef.Initialize();
            m_chromeBrowser = new ChromiumWebBrowser("https://auto.ria.com/search/?category_id=1&marka_id=15&model_id=1082#category_id=1&s_yers[0]=2006&po_yers[0]=0&price_do=8000&currency=1&marka_id[0]=15&model_id[0]=1082&countpage=10&page=0&power_name=1&engineVolumeFrom=&engineVolumeTo=&raceTo=125&damage=1");
            panel1.Controls.Add(m_chromeBrowser);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void buttonDisplayDevTools_Click(object sender, EventArgs e)
        {
            m_chromeBrowser.ShowDevTools();
        }

        private void buttonSourceCode_Click(object sender, EventArgs e)
        {
            var t = m_chromeBrowser.GetSourceAsync();
            t.Wait();
            var result = t.Result;            
        }
    }
}
