using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaptopApp_MVC.Models
{
    public class LaptopDetails
    {
        public int? ID { get; set; }

        public string LaptopName { get; set; }

        public double Price { get; set; }

        public string Url { get; set; }

        public string Features { get; set; }

        public string ZoomURL { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }
    }
}