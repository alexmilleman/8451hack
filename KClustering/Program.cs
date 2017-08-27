using DataImport.Models;
using Main.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KClustering
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new TransactionEntities();
            Console.WriteLine("DB Connection Established.");
            Console.WriteLine("Clearing old recommendations.");

            db.ProductRecommendations.ToList().Select(p => db.ProductRecommendations.Remove(p));
            db.SaveChanges();

            Console.WriteLine("Calculating new recommendations.");
            var records = db.TransactionRecords.ToList();

            var products = records.Select(t => t.productId).Distinct().OrderBy(t=>t).ToList();
            var results = new List<ProductRecommendation>();

            products.ForEach(p =>
            {

                Console.WriteLine($"Calculating recommendations for {p}");
                var rec = new ProductRecommendation();
                rec.ProductId = int.Parse(p);
                rec.RecomendedProductIdsJson = JsonConvert.SerializeObject(CommonlyPurchasedTogether(p, records));
            });


            Console.WriteLine("Saving results.");
            db.ProductRecommendations.AddRange(results);
            db.SaveChanges();


            Console.WriteLine("All done.  Press the anykey to exit!");
            Console.ReadLine();
        }

        static List<int> CommonlyPurchasedTogether(string product, List<TransactionRecord> records)
        {

        }
    }
}
