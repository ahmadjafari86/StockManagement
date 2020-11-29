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
        private readonly StockDataAccess stockDataAccess = new StockDataAccess();

        public bool InternetStatus ()
        { 
            return webDataAccess.IsConnectedToInternet();
        }
        public string WebScraping(string stock, string dataSource)
        {
            return stockDataAccess.GetStockData(stockDataAccess.PrepareUrl(stock, dataSource));
        }
    }
}
