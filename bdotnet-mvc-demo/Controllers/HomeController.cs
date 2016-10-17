using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bdotnet_mvc_demo.Models;
using Newtonsoft.Json;

namespace bdotnet_mvc_demo.Controllers
{
    public class HomeController : Controller
    {
        HttpClient client;
        public HomeController()
        {
            client = new HttpClient();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public async Task<IActionResult> Session()
        {
            var response = await client.GetStringAsync("http://bdotnetwebapi:8000/api/sessions");
            var sessions = JsonConvert.DeserializeObject<List<Session>>(response);
            ViewData["Message"] = "Sessions";
            return View(sessions);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
