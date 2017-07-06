using CarDealership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarDealership.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Vehicle> vehicles = new List<Vehicle> {
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
                Description="Runs Great, Leather Interior, Vroom",
                IsFeatured=true
                },
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
                },
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
                },
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
                },
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
                },
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
                },
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
                },
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
            return View(vehicles);
        }

        public ActionResult Specials()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";
            Contact model = new Contact();

            return View(model);
        }
    }
}