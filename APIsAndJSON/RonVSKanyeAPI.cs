using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class QuoteGenerator
    {
        private HttpClient _client;

        public QuoteGenerator (HttpClient client)
        {
            _client = client;
        }
        public string Kanye()
        {

            var KanyeURL = "https://api.kanye.rest/";

            var KanyeResponse = _client.GetStringAsync(KanyeURL).Result;

            var kanyeQuote = JObject.Parse(KanyeResponse).GetValue("quote").ToString();

            return kanyeQuote;
        }

        public string Ron()
        {
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = _client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse);
           
            return ronQuote[0].ToString();
        }
            
        

    }
}
