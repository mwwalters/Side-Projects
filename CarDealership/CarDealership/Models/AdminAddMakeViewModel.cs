using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarDealership.Models
{
    public class AdminAddMakeViewModel
    {
        public List<VehicleMake> AllMakes { get; set; }
        public VehicleMake NewMake { get; set; }
    }
}