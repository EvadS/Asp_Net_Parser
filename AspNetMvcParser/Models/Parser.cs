using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using HtmlAgilityPack;

namespace AspNetMvcParser.Models
{
    public class Parser
    {
        private string url;

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        private HtmlDocument DownloadDocument()
        {
            System.Net.WebClient web = new System.Net.WebClient();
            web.Encoding = UTF8Encoding.UTF8;

            string str = web.DownloadString(url);
            HtmlAgilityPack.HtmlDocument doc = new HtmlDocument();

            doc.LoadHtml(str);

            return doc;
        }


        public DataRow Parse()
        {
            HtmlDocument document = DownloadDocument();
            if (document != null)
            {
                HtmlAgilityPack.HtmlNode nodeTitle = document.DocumentNode.SelectSingleNode("/html/body/div[1]/div[2]/div[1]/h3[1]");           
                var nodeText = document.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[1]/div[2]/div[1]/p[1]");
                     
                string title = nodeTitle.InnerText;
                string text = nodeText.InnerText;

                DataRow result = new DataRow(title, text);
                return result;
            }

            return null;
        }
    }
}