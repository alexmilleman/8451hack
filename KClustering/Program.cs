using DataImport.Models;
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
            Console.WriteLine("HelloWorld");
            var db = new TransactionEntities();
            var data = db.TransactionRecords;
            Console.WriteLine(data.Count());
            Console.ReadLine();
        }
    }
}
