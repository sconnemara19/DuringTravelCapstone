using During_Travel2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace During_Travel2.Controllers
{
    public class DestinationsController : Controller
    {
        string Baseurl = "https://localhost:44333/";
        public async Task<ActionResult> Index()
        {
            List<Destinations> destInfo = new List<Destinations>();
            using (var Destinations = new HttpClient())
            {
                Destinations.BaseAddress = new Uri(Baseurl);

                Destinations.DefaultRequestHeaders.Clear();

                Destinations.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await Destinations.GetAsync("api/Destinations");

                if (Res.IsSuccessStatusCode)
                {
                    var DestResponse = Res.Content.ReadAsStringAsync().Result;

                    destInfo= JsonConvert.DeserializeObject<List<Destinations>>
                        (DestResponse);
                }
                return View(destInfo);

            }
            
        }


    }
}