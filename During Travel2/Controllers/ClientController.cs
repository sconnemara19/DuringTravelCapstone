using During_Travel2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Client client = context.Clients.Where(c => c.Id == id).FirstOrDefault();
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
        public ActionResult StaticBind()
        {

            return View();
        }
        public ActionResult VacationCompany()
        {
            return View();
        }



    }
}