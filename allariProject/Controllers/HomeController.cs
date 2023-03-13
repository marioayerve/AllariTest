using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using allariProject.Models;

namespace allariProject.Controllers
{
    public class HomeController : Controller
    {
        IEnumerable<Customers> lstCustomer = Customers.GetCustomers();
        IEnumerable<Service> lstService = Service.GetServices();

        private readonly ITransient _tr;
        private readonly IScoped _isc;
        
        public HomeController()
        {

        }
        public HomeController(ITransient transient, IScoped scoped)
        {
            _tr = transient;
            _isc = scoped;
            
            lstCustomer = new List<Customers>();
            lstService = new List<Service>();
        }
        public ActionResult Index()
        {
            ViewBag.ServiceList = lstService;
            return View(lstCustomer);
        }

        public PartialViewResult getCust(int id)
        {
            //ViewBag.ServiceList = lstService;
            IEnumerable<Customers> filter = lstCustomer.Where(a => a.ServiceId == id);
            return PartialView(filter);
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}