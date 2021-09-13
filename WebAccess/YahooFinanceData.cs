using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinanceApi;
using Owin;
using YSQ;
using System.Net.Http;
using System.IO;
using RestSharp;

namespace WebAccess
{
    public class YahooFinanceData
    {
        public string GetYahooStock()
        {
            var client = new RestClient("https://apidojo-yahoo-finance-v1.p.rapidapi.com/stock/v3/get-historical-data?symbol=AMRN&region=US");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "d6106a289cmshfcfb23adb0bdcf3p10516ejsnd9f4c6e8b93b");
            request.AddHeader("x-rapidapi-host", "apidojo-yahoo-finance-v1.p.rapidapi.com");
            IRestResponse response = client.Execute(request);
            return response.Content.ToString();
        }
       
        public void GetYahooChart()
        {
            var client = new RestClient("https://apidojo-yahoo-finance-v1.p.rapidapi.com/stock/v2/get-chart?interval=5m&symbol=AMRN&range=1d&region=US");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "d6106a289cmshfcfb23adb0bdcf3p10516ejsnd9f4c6e8b93b");
            request.AddHeader("x-rapidapi-host", "apidojo-yahoo-finance-v1.p.rapidapi.com");
            IRestResponse response = client.Execute(request);
        }
    }
}
