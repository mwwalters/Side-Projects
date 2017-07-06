using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarDealership.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            return View();
        }
        
        public ActionResult Used()
        {
            return View();
        }
        [Route("{id}")]
        public ActionResult Details(int id)
        {
            return View(id);
        }
    }
}