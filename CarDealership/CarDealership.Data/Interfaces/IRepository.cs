using CarDealership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Data.Interfaces
{
    public interface IRepository
    {
        List<Vehicle> GetAllVehicles();
        Vehicle GetVehicleById(int id);
        void CreateVehicle(Vehicle vehicle);
        void EditVehicle(Vehicle vehicle);
        void DeleteVehicleById(int id);
        void MakePurchase(Sale sale, Vehicle vehicle);
    }
}
