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
    public class TravelDocsController : Controller
    {
        string Baseurl = "https://localhost:44335/";
        public async Task<ActionResult> Index2()
        {
            List<TravelDocs> travelDocsInfo = new List<TravelDocs>();

            using (var traveldocs = new HttpClient())
            {
                traveldocs.BaseAddress = new Uri(Baseurl);

                traveldocs.DefaultRequestHeaders.Clear();

                traveldocs.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await traveldocs.GetAsync("api/TravelDocs");

                if (Res.IsSuccessStatusCode)
                {
                    var TravelResponse = Res.Content.ReadAsStringAsync().Result;

                    travelDocsInfo = JsonConvert.DeserializeObject<List<TravelDocs>>
                        (TravelResponse);

                }
                return View(travelDocsInfo);

            }
        }
    }
}