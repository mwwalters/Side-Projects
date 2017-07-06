﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public class Sale
    {
        public string Name { get; set; }
        public int? Phone { get; set; }
        public string Email { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? Zipcode { get; set; }
        public decimal? PurchasePrice { get; set; }
        public string PurchaseType { get; set; }
    }
}