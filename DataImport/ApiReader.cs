using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DataImport
{
    public class ApiReader
    {
        private HttpClient httpClient;

        const string baseUrl = "http://api.8451hack.com";

        public ApiReader()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(baseUrl);
            httpClient.DefaultRequestHeaders.Add("X-8451", "9b80df31-ffd4-440c-8f93-2828003dcbc2");
        }

        public List<string> Endpoints {
            get{
                return JsonConvert.DeserializeObject<string>(Get());
            }
        }

        private string Get(string relativeUrl = ""){
            return httpClient.GetStringAsync(baseUrl + relativeUrl).Result;
        }
    }
}
