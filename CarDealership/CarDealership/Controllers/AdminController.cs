using CarDealership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarDealership.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
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
            List<Special> specials = new List<Special> {
                new Special
                {
                    Id=1,
                    Title ="Special Deal 1",
                    Details="TESTTESTTESTESTESTESTESTESTESTESTESTESTESTTESTTESTTESTESTESTESTESTESTESTESTESTESTEST"
                },
                new Special
                {
                    Id=2,
                    Title="Special Deal 2",
                    Details="TESTTESTTESTESTESTESTESTESTESTESTESTESTESTTESTTESTTESTESTESTESTESTESTESTESTESTESTEST"
                }
            };

            AdminSpecialsViewModel vm = new AdminSpecialsViewModel(specials);

            return View(vm);
        }

        [HttpPost]
        public ActionResult CreateSpecial(AdminSpecialsViewModel special)
        {
            //method to add special to table of current specials in the db here
            return RedirectToAction("Specials");
        }

        public ActionResult AddVehicle()
        {
            AdminAddVehicleViewModel vm = new AdminAddVehicleViewModel();
            return View(vm);
        }

        [HttpPost]
        public ActionResult AddVehicle(AdminAddVehicleViewModel vm)
        {
            //action to use storedproc for creating table object here
            return RedirectToAction("Index");
        }

        public ActionResult EditVehicle(int id)
        {
            AdminEditVehicleViewModel vm = new AdminEditVehicleViewModel();
            //Vehicle = storedproc to get specific vehicle from db using the vehicle id from the edit button on index page
            vm.Vehicle = new Vehicle
            {
                Id = 1,
                Make = "Ford",
                Model = "F150",
                Year = 2015,
                Image = "/Content/Cars/2014FordTaurus.jpg",
                IsNew = true,
                BodyStyle = "Truck",
                Trans = "Automatic",
                Color = "Black",
                Interior = "Leather",
                Mileage = 0,
                VinNumber = "1HGCM82633A004352",
                SalePrice = 25000,
                MSRP = 27500,
                Description = "Runs Great, Leather Interior, Vroom",
                IsFeatured = false,
                InStock = true
            };
            return View(vm);
        }

        public ActionResult Makes()
        {
            //stored proc to get all unique models
            List<VehicleMake> allMakes = new List<VehicleMake>
            {
                new VehicleMake
                {
                    Name="Ford"
                },
                new VehicleMake
                {
                    Name="Toyota"
                },
                new VehicleMake
                {
                    Name="Chrysler"
                },
                new VehicleMake
                {
                    Name="Honda"
                }
            };
            AdminAddMakeViewModel vm = new AdminAddMakeViewModel();

            vm.AllMakes = allMakes;

            return View(vm);
        }

        [HttpPost]
        public ActionResult Makes(VehicleMake newmake)
        {
            //storedproctoaddmaketolist
            return RedirectToAction("Makes");
        }

        public ActionResult Models()
        {
            List<VehicleModel> allModels = new List<VehicleModel>
            {
                new VehicleModel
                {
                    Name="F150"
                },
                new VehicleModel
                {
                    Name="Camry"
                },
                new VehicleModel
                {
                    Name="Cherokee"
                },
                new VehicleModel
                {
                    Name="Accord"
                }
            };

            AdminAddModelViewModel vm = new AdminAddModelViewModel();
            vm.AllModels = allModels;
            
            return View(vm);
        }

        [HttpPost]
        public ActionResult Models(VehicleModel newmodel)
        {
            //sproc to add new data to db
            return RedirectToAction("Models");
        }
    }
}