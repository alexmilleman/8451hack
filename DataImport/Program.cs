using System;
using DataImport.Models;

namespace DataImport
{
    class MainClass
    {
        public static void Main(string[] args)
		{
			var db = new TransactionEntities();
            if (db != null) Console.WriteLine("Azure connection established!");
            var api = new ApiReader();
            if(api != null) {
                Console.WriteLine("API connection established!");
            };
            api.BuildTransactionRecords();
        }
    }
}
