using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarDealership.Models
{
    public class AdminEditVehicleViewModel
    {
        public Vehicle Vehicle { get; set; }
        public MakesDictionary AllMakes { get; set; }
        public ModelsDictionary AllModels { get; set; }
        public BodyStyleDictionary AllBodyStyles { get; set; }
        public ColorDictionary AllColors { get; set; }
        public TransmissionDictionary AllTransmissions { get; set; }
        public InteriorDictionary AllInteriors { get; set; }

        public AdminEditVehicleViewModel()
        {
            Vehicle = new Vehicle();
            AllMakes = new MakesDictionary();
            AllModels = new ModelsDictionary();
            AllBodyStyles = new BodyStyleDictionary();
            AllColors = new ColorDictionary();
            AllTransmissions = new TransmissionDictionary();
            AllInteriors = new InteriorDictionary();
        }
    }
}