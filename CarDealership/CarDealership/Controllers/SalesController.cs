using CarDealership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarDealership.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        public ActionResult Index()
        {
            List<Vehicle> test = new List<Vehicle> {
                new Vehicle{
                    Id = 1,
                Make = "Real",
                Model = "Car",
                Year = 2010,
                Image = "/Content/Cars/2010ChevyCamaro.jpg",
                IsNew = false,
                BodyStyle = "Coupe",
                Trans = "Auto",
                Color = "Blue",
                Interior = "Crocodile",
                Mileage = 100000,
                VinNumber = "1HGCM82633A004352",
                SalePrice = 21000,
                MSRP = 24000,
                Description="Runs Great, Leather Interior, Vroom"
                }

                };
            return View(test);
        }

        // GET: Sales/Details/5
        public ActionResult PurchaseVehicle(int id)
        {

            Vehicle vehicle = new Vehicle
            {
                Id = 1,
                Make = "Real",
                Model = "Car",
                Year = 2010,
                Image = "/Content/Cars/2010ChevyCamaro.jpg",
                IsNew = false,
                BodyStyle = "Coupe",
                Trans = "Auto",
                Color = "Blue",
                Interior = "Crocodile",
                Mileage = 100000,
                VinNumber = "1HGCM82633A004352",
                SalePrice = 21000,
                MSRP = 24000,
                Description = "Runs Great, Leather Interior, Vroom"
            };

            var vm = new SalesVehicleViewModel(vehicle);

            return View(vm);
        }

        public ActionResult MakePurchase(Vehicle vehicle, Sale sale)
        {
            // action here to make purchase in database, remove from inventory table, add to sales table
            return RedirectToAction("Index");

        }

        // GET: Sales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sales/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sales/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sales/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sales/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sales/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
