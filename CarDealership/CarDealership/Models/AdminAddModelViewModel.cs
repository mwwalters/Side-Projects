﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarDealership.Models
{
    public class AdminAddModelViewModel
    {
        public List<VehicleModel> AllModels { get; set; }
        public VehicleModel NewModel { get; set; }
    }
}