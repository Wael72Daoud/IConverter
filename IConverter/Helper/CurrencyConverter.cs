/*
 * 
 * 

 * 100   {"to": "CAD", "rate": 1.0123004600000001, "from": "USD"}
100   {"to": "USD", "rate": 0.98784899999999998, "from": "CAD"}

100   {"err": "error occurred"}
100   {"to": "CHF", "rate": 0.91909990699999999, "from": "USD"}
100   {"to": "USD", "rate": 1.0880209999999999, "from": "CHF"}
 * 
 * 
 * 
 * 
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using Microsoft.Phone.Net.NetworkInformation;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace IConverter.Converters
{
   

    public class CurrencyConverter
    {
        public delegate void TestDelegate(IAsyncResult ar); 

        public string stringBuffer { set; get; }
        WebClient webreqObj;
        long Totalbytes = 1;
        long bytesRecieved = 0;
        static string GOOGL_CONVERTER_URL = "http://rate-exchange.appspot.com/currency?"; //from=USD&to=USD";

        public double CONVERT_RATE
        {
            set;
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="From"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public void GetGoogleConvertRate(string From, String To)
        {
           
            webreqObj = new WebClient();
            ManualResetEventSlim signal = new ManualResetEventSlim();

            webreqObj.DownloadStringCompleted += new DownloadStringCompletedEventHandler(webreqObj_DownloadStringCompleted);
            
            webreqObj.DownloadProgressChanged += new DownloadProgressChangedEventHandler(webreqObj_DownloadProgressChanged);

            Uri page = new Uri(GOOGL_CONVERTER_URL + "from=" + From + "&to=" + To);
            webreqObj.DownloadStringAsync(page);            
           
            //MainPage testpage = new MainPage();

            //testpage.txtDisplay.Dispatcher.BeginInvoke(new TestDelegate(PrintResults));
                        
        }

        void webreqObj_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.stringBuffer = e.ProgressPercentage.ToString();
            this.Totalbytes = e.TotalBytesToReceive;
            this.bytesRecieved = e.BytesReceived;
        }

 
   

       public  void webreqObj_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            //MainPage testpage = new MainPage();
            this.CONVERT_RATE =  parseGoogleCurrencyRate(e.Result.ToString());
            

            
        }

       public void PrintResults()
       {
           //MainPage testpage = new MainPage();
          // testpage.txtDisplay.Text = Convert.ToString(this.CONVERT_RATE);
       }

        /****************************************************************************
        * 
        *   100   {"err": "error occurred"}
        *   100   {"to": "CHF", "rate": 0.91909990699999999, "from": "USD"}
        * 
        ***************************************************************************/
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rateExchangeString"></param>
        /// <returns></returns>
        public double parseGoogleCurrencyRate(string rateExchangeString)
        {
            double currencyRate = 0;
            
            if (rateExchangeString.ToUpper().Contains("ERR"))
            {
                return currencyRate;
            }

            try
            {

                if (rateExchangeString.ToUpper().Contains("RATE"))
                {

                    string ratePattern = @"(\d+\.\d+)(?!.*\d)";
                    Regex rateValueRegx = new Regex(ratePattern, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Singleline);
                    Match marchingRateRegex = rateValueRegx.Match(rateExchangeString);
                    string parsedExchnageRate = marchingRateRegex.Value.ToString();
                    currencyRate = Convert.ToDouble(parsedExchnageRate);
                    //int startMarker = rateExchangeString.ToUpper().IndexOf("RATE");
                    //int endMarker = rateExchangeString.ToUpper().IndexOf("FROM");
                    //parsedExchnageRate = rateExchangeString.ToUpper().Substring(startMarker, endMarker - startMarker);
                    //currencyRate = Convert.ToDouble(parsedExchnageRate);
                }
            }
            catch (RegexMatchTimeoutException RegxEx)
            {
                //[TODO] add globabl error messages
            }
            catch (NullReferenceException NullEx)
            {
                //[TODO] add globabl error messages
            }

            return currencyRate;
        }
        

        public enum CurrncyConverterType
        {
            google
        }


    }
}
