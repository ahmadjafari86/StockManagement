using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Runtime.InteropServices;

namespace WebAccess
{
     public class WebDataAccess
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

         public string Scraper(string scrapeLink)
        {
           // string s = "https://www.yellowpages.com/search?search_terms=Software&geo_location_terms=Sydney%2C+ND";
            HtmlAgilityPack.HtmlWeb webScraper = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = webScraper.Load(scrapeLink);
            var headernames = doc.DocumentNode.SelectNodes("//a[@class='business-name']").ToList();
            string headers = "";
            foreach (var item in headernames)
            {
                headers += "  {" + item.InnerText + "}  ";
            }
            return headers;
        }
        
        //Creating a function that uses the API function...
         public bool IsConnectedToInternet()
        {
            bool a;
            int Desc;
            a = InternetGetConnectedState(out Desc, 0);
            return a;
        }

    }
    
}
