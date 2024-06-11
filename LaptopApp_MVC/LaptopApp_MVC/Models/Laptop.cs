using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaptopApp_MVC.Models
{
    public class Laptop
    {
        public int? SrNo { get; set; }

        public string LaptopName { get; set; }

        public double? Price { get; set; }

        public string Url { get; set; }

        public string ZoomURL { get; set; }

        public string Description { get; set; }
    }
}