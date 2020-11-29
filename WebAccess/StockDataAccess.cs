using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinanceApi;
using System.Data;
using HtmlAgilityPack;

namespace WebAccess
{
    public class StockDataAccess
    {
        public string PrepareUrl(string stock, string dataSource)
        {
            string base_url = dataSource + @"/quote/@?p=@&.tsrc=fin-srch";
            string url = base_url.Replace("@", stock);
            return url;
        }

        public string GetStockData(string adres)
        {
            string headers = "";
            try
            {
                HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.Load(adres);
                var headerNames = doc.DocumentNode.SelectNodes(" / html / body / div / div / div / div / div/ div[2] / div / div / div[4]" +
                                                               " / div / div / div / div[3] / div / div / span[1]").ToList();
                foreach (var item in headerNames)
                    headers += " " + item.InnerText + " ";
            }
            catch (Exception e)
            {
                headers = "Error!  " + e.ToString();
            }
            return headers;
        }
    }
}
