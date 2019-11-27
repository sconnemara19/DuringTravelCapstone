﻿using During_Travel2.Models;
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
    public class ClientController : Controller
    {
        ApplicationDbContext context;

        public ClientController()
        {
            context = new ApplicationDbContext();
        }
        
        // GET: Client
        public ActionResult Index()
        {
            List<Client> clients = context.Clients.ToList();
            return View(clients);
        }

        public ActionResult Details(int id)
        {
            Client client = context.Clients.Where(c => c.ClientId == id).FirstOrDefault();
            return View(client);
            
            
        }
        // GET: CarOwner/Create
        public ActionResult Create()
        {
            Client client = new Client();
            return View(client); ;
        }


        // POST: Observer/Create
        [HttpPost]
        public ActionResult Create(Client client)
        {
            try
            {
                // TODO: Add insert logic here
                context.Clients.Add(client);
                context.SaveChanges();
                return RedirectToAction("StaticBind");
            }
            catch
            {
                return View();
            }
      
        }
        //public ActionResult StaticBind()
        //{

        //    return View();
        //}
        //public ActionResult VacationCompany()
        //{
        //    return View();
        //}

        string Baseurl = "https://localhost:44335/";
        public async Task<ActionResult> Index2()
        {
            List<Client> clientInfo = new List<Client>();

            using(var clients = new HttpClient())
            {
                clients.BaseAddress = new Uri(Baseurl);

                clients.DefaultRequestHeaders.Clear();

                clients.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await clients.GetAsync("api/Clients");

                if (Res.IsSuccessStatusCode)
                {
                    var clientResponse = Res.Content.ReadAsStringAsync().Result;

                    clientInfo = JsonConvert.DeserializeObject<List<Client>>
                        (clientResponse);
                }
                return View(clientInfo);
            }
        }



    }
}