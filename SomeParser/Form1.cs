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
using CefSharp.WinForms;
using Newtonsoft.Json;

namespace SomeParser
{
    public partial class Form1 : Form
    {
        private ChromiumWebBrowser _mChromeBrowser;
        private List<Uri> _uris;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cef.Initialize();
            //_mChromeBrowser = new ChromiumWebBrowser(@"https://auto.ria.com/");
            _mChromeBrowser = new ChromiumWebBrowser(@"https://auto.ria.com/search/?category_id=1&marka_id=15&model_id=1082#category_id=1&s_yers[0]=2006&po_yers[0]=0&price_do=8000&currency=1&marka_id[0]=15&model_id[0]=1082&countpage=10&page=0&power_name=1&engineVolumeFrom=&engineVolumeTo=&raceTo=125&damage=1");
            panel1.Controls.Add(_mChromeBrowser);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void buttonDisplayDevTools_Click(object sender, EventArgs e)
        {
            _mChromeBrowser.ShowDevTools();
        }

        private void buttonSourceCode_Click(object sender, EventArgs e)
        {

            //_mChromeBrowser.ExecuteScriptAsync("levelsPopupTemplate");
            //var t = _mChromeBrowser.GetSourceAsync();
            //t.Wait();
            //var result = t.Result;
            //HtmlParser parser = new  HtmlParser(result);
            //List<Uri> List = parser.GetLinks();
        }

        private void GetAllAds_Click(object sender, EventArgs e)
        {
            AutoriaParser parser = new AutoriaParser();
            List<AutoInfo> adsList = parser.GetAllAds(_mChromeBrowser.Address);
        }

        private void GetUsersInfo_Click(object sender, EventArgs e)
        {
            AutoriaParser parser = new AutoriaParser();

            Random rnd = new Random();

            List<UserInfo> userInfos = new List<UserInfo>();

            for (int i = 0; i < 100; i++)
            {
                int id = rnd.Next(1, 5150000);
                Uri uri = new Uri("https://auto.ria.com/demo/bu/finalPage/users/" + id + "/_extended");

                string responseText = parser.GetSearchResults(uri);

                UserInfo userInfo;
                try
                {
                    userInfo = JsonConvert.DeserializeObject<UserInfo>(responseText);
                }
                catch (JsonSerializationException exception)
                {
                    Console.WriteLine("error:" + id);
                    continue;
                }

                userInfos.Add(userInfo);

                /*

                StringBuilder phoneString = new StringBuilder("/");
                foreach (var phone in userInfo?.phones)
                {
                    phoneString.Append(phone.phone_formatted);
                    phoneString.Append("/");
                }

                string email = userInfo?.user?.email_normalized;

                string name = userInfo?.user?.name;

                Console.WriteLine("id: {0}; name: {1}; email:{2}; phone: {3}", id, name, email, phoneString);
                */
            }

            using (var db = new AutoRiaContext())
            {
                db.UserInfos.AddRange(userInfos);
                db.SaveChanges();
            }

        }
    }
}
