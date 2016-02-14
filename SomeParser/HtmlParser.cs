using System;
using System.Collections.Generic;
using System.Threading;
using CsQuery;

namespace SomeParser
{   
    public class HtmlParser
    {
        public CQ Dom { get; private set; }

        public HtmlParser(string HtmlText)
        {
            if(HtmlText==null) throw new ArgumentNullException();
            
            Dom = new CQ(HtmlText);
        }

        public List<Uri> GetLinks()
        {
            List<Uri> result = new List<Uri>();
            //Document.GetElementbyId("")

            CQ ticketItemDom = Dom.Find("div[class=\"ticket-item\"]");
            int count = 0;
            foreach (var item in ticketItemDom)
            {
                foreach (var photoValue in item.Cq().Find("a[class^=\"photo\"]"))
                {
                    string title = photoValue.HasAttribute("title") ? photoValue.Attributes["title"] : "";
                    string link = photoValue.HasAttribute("href") ? photoValue.Attributes["href"] : "";

                    var imageSource = photoValue.Cq().Find("img[src]");
                    string imagelink = imageSource.Length > 0 ? imagelink = imageSource[0].Attributes["src"] : "";
                }
            }

            return result;
        }

    }
}