using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Runtime.InteropServices;

namespace WebAccess
{
    class WebScraping
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        static void Main()
        {
            WebScraping er = new WebScraping();
            // er.Scraper();
            Console.WriteLine(er.IsConnectedToInternet());
            string a = Console.ReadLine();
        }
        
         public void Scraper()
        {
            HtmlAgilityPack.HtmlWeb webScraper = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = webScraper.Load("https://www.yellowpages.com/search?search_terms=Software&geo_location_terms=Sydney%2C+ND");
            var headernames = doc.DocumentNode.SelectNodes("//a[@class='business-name']").ToList();
            foreach (var item in headernames)
            {
                Console.WriteLine(item.InnerText);
            }
        }
        
        //Creating a function that uses the API function...
        bool IsConnectedToInternet()
        {

            bool a;
            int Desc;
            a = InternetGetConnectedState(out Desc, 0);
            return a;
        }

    }
    
}
