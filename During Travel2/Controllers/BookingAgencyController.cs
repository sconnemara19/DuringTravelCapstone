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
    public class BookingAgencyController : Controller
    {
        // GET: BookingAgency
        public ActionResult Index()
        {
            return View();
        }

        string Baseurl = "https://localhost:44333/";
        public async Task<ActionResult> Index2()
        {
            List<BookingAgency> AgencyInfo = new List<BookingAgency>();
            
            using (var agency = new HttpClient())
            {
                agency.BaseAddress = new Uri(Baseurl);

                agency.DefaultRequestHeaders.Clear();

                agency.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await agency.GetAsync("api/BookingAgencies");

                if (Res.IsSuccessStatusCode)
                {
                    var AgencyResponse = Res.Content.ReadAsStringAsync().Result;

                    AgencyInfo = JsonConvert.DeserializeObject<List<BookingAgency>>
                        (AgencyResponse);
                }
                return View(AgencyInfo);
                





            }
        }
    }
}