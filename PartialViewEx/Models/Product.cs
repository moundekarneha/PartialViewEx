using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewEx.Models
{
    public class Product
    {
        public int Pid { get; set; }
        public string Name { get; set; }    
        public string Photo { get; set; }    
        public double Price { get; set; }    
    }
}