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
        private readonly YahooFinanceData yahooFinanceData = new YahooFinanceData();

        public bool InternetStatus ()
        { 
            return webDataAccess.IsConnectedToInternet();
        }
        public string WebScraping(string stock, string dataSource)
        {
            if (InternetStatus())
                return stockDataAccess.GetStockData(stockDataAccess.PrepareUrl(stock, dataSource));
            else return "No internet access!";
        }
        public string GetYahooFinanceData()
        {
            if (InternetStatus())
                return yahooFinanceData.GetYahooStock();
            else return "No internet access!";
        }
    }
}
