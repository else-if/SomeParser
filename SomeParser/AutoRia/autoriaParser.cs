using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Text.RegularExpressions;
using System.Threading;
using CsQuery.ExtensionMethods;
using CsQuery.Utility;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SomeParser
{
    public class AutoriaParser
    {
        private const string ApiHost = "https://auto.ria.com/";
        private const string UriSearchLocalPath = @"blocks_search_ajax/search/";
        private const string UriAutoDataPath = @"demo/bu/searchPage/v2/view/auto/";

        public AutoriaParser()
        {
        }

        public List<AutoInfo> GetAllAds(string searchLink)
        {
            if (searchLink == null) throw new ArgumentNullException();

            List<string> ids = GetAllAutoIds(searchLink);
            
            List<AutoInfo> result = new List<AutoInfo>();

            return result;
        }

        private List<string> GetAllAutoIds(string searchLink)
        {
            int pageNumber = 0;
            int numberPerPage = 10;

            List<string> ids = new List<string>();

            bool allPagesRead = false;
            while (!allPagesRead)
            {
                Uri requestUri = GetSearchRequestUri(searchLink, pageNumber, numberPerPage);

                string responseText = GetSearchResults(requestUri);
                var searchResults = JsonConvert.DeserializeObject<SearchResults>(responseText);

                int resultsCount = searchResults.result.search_result.count;

                if (resultsCount == 0) break;

                ids.AddRange(searchResults.result.search_result.ids);

                if (resultsCount <= pageNumber*numberPerPage)
                    allPagesRead = true;
                else
                    pageNumber += 1;
            }

            return ids;
        }

        private Uri GetSearchRequestUri(string searchLink)
        {
            return GetSearchRequestUri(searchLink, 0, 50);
        }

        private Uri GetSearchRequestUri(string searchLink, int pageNumber)
        {
            return GetSearchRequestUri(searchLink, pageNumber, numberPerPage: 50);
        }

        private Uri GetSearchRequestUri(string searchLink, int pageNumber, int numberPerPage)
        {
            if (pageNumber < 0) throw new ArgumentOutOfRangeException(nameof(pageNumber));
            if (numberPerPage <= 0) throw new ArgumentOutOfRangeException(nameof(numberPerPage));

            int index = searchLink.LastIndexOf("#", StringComparison.Ordinal);
            if (index == -1) throw new ArgumentException(@"Http address must contain ""#"" symbol");

            string queryString = searchLink.Substring(index + 1);

            NameValueCollection queryCollection = HttpUtility.ParseQueryString(queryString);
            queryCollection.Set("page", pageNumber.ToString());
            queryCollection.Set("countpage", numberPerPage.ToString());

            return new Uri(ApiHost + UriSearchLocalPath + "?" + queryCollection);
        }

        public string GetSearchResults(Uri requesrUri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requesrUri);

            request.Method = "GET";
            request.Accept = "application/json";
            
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream stream = response.GetResponseStream();
            if (stream == null) throw new WebException("Null response stream");

            StreamReader sr = new StreamReader(stream);
            string responseText = sr.ReadToEnd();
            sr.Close();

            response.Close();
            
            return responseText;
        }
    }
}