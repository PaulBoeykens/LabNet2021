using Lab.Demo.MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lab.Demo.MVC.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            ApiView dolarhoy = new ApiView();
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://api-dolar-argentina.herokuapp.com/api/dolaroficial");

            dolarhoy = JsonConvert.DeserializeObject<ApiView>(json);
            return View(dolarhoy);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}