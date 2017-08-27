using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DataImport.Models;

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

        public string Endpoints => httpClient.GetStringAsync(baseUrl).Result;


        public int GetNumberOfRecords(string relativeUrl){
            string defaultPage = httpClient.GetStringAsync(relativeUrl).Result;
            RootObject root = JsonConvert.DeserializeObject<RootObject>(defaultPage);
            return root.page.totalPages;
        }


        private string Get(string relativeUrl){
            int pageSize = 1000;
            int numberOfRecords = GetNumberOfRecords(relativeUrl);
            List<string> results = new List<string>();
            for (var i = 0; i < (numberOfRecords/pageSize);i++){
                httpClient.GetStringAsync($"{baseUrl}/{relativeUrl}?size={pageSize}&page={i}")
                          .ContinueWith(request=>results.Add(request.Result));
            }

        }
    }
}
