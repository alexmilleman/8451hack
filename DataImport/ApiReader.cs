using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DataImport.Models;
using System.Linq;

namespace DataImport
{
    public class ApiReader
    {

        const string baseUrl = "http://api.8451hack.com";
        private const int pageSize = 1000;

        public ApiReader()
        {
        }

        public HttpClient HttpClient
        {
            get
            {
                var httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(baseUrl);
                httpClient.DefaultRequestHeaders.Add("X-8451", "9b80df31-ffd4-440c-8f93-2828003dcbc2");
                return httpClient;
            }
        }

        public void Add(List<TransactionRecord> records)
        {
            var db = new TransactionEntities();
            db.TransactionRecords.AddRange(records);
            db.SaveChanges();
        }

        public List<TransactionRecord> GetRecords(int pageNumber)
        {
            string endpoint = "/transactionRecords";
            var response_string = Get(endpoint, pageNumber, pageSize);
            RootObject response_object = JsonConvert.DeserializeObject<RootObject>(response_string);
            List<TransactionRecord> records = response_object._embedded.transactionRecords;
            return records;
        }

        public void BuildTransactionRecords()
        {
            string endpoint = "/transactionRecords";
            int numberOfIterations = GetNumberOfRecords(endpoint) / pageSize;
            var size = GetNumberOfRecords(endpoint);
            List<int> pages = new List<int>();
            for(var i = 92; i < numberOfIterations; i++)
            {
                pages.Add(i);
            }

            pages.ForEach(p =>
            {
                List<TransactionRecord> records = GetRecords(p);
                Console.WriteLine($"Page #{p}, count: {records.Count()}");
                Add(records);
            });

        }

        public int GetNumberOfRecords(string relativeUrl){
            string defaultPage = HttpClient.GetStringAsync(relativeUrl).Result;
            RootObject root = JsonConvert.DeserializeObject<RootObject>(defaultPage);
            return root.page.totalPages;
        }


        private string Get(string relativeUrl, int page, int size){
            int numberOfRecords = GetNumberOfRecords(relativeUrl);
            return HttpClient.GetStringAsync($"{baseUrl}/{relativeUrl}?size={size}&page={page}").Result;

        }
    }
}
