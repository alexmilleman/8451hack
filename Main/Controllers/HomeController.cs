using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Main.Models.Analysis;
using Newtonsoft.Json;

namespace Main.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new AnalysisEntities();
            Dictionary<int, List<int>> data = new Dictionary<int, List<int>>();
            db.ProductRecomendations.ForEach(r=>{
                data.Add((r.ProductId), JsonConvert.DeserializeObject<List<int>>(r.RecomendedProductIdsJson));
            });
            ViewBag.data = data;
            return View();
        }
    }
}
