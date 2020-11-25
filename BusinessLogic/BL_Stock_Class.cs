using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAccess;

namespace BusinessLogic
{
     public class BL_Stock_Class
    {
        private readonly WebDataAccess webDataAccess = new WebDataAccess();

        public bool InternetStatus ()
        { 
            return webDataAccess.IsConnectedToInternet();
        }
        public string WebScraping(string scrapeLink)
        {
           return webDataAccess.Scraper(scrapeLink);
        }
    }
}
