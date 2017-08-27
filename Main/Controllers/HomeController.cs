using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Newtonsoft.Json;
using DataImport.Models;
using Main.Models;

namespace Main.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new TransactionEntities();
            Dictionary<int, string> data = new Dictionary<int, string>();
            var table_inmem = db.ProductRecommendations.ToList();
                table_inmem.ForEach(r=>{
                data.Add((r.ProductId), r.RecomendedProductIdsJson);
            });
            ViewBag.data = data;
            return View();
        }
    }
}
