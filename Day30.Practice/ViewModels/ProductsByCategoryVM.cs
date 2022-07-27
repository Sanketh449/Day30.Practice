using Day30.Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day30.Practice.ViewModels
{
    public class ProductsByCategoryVM
    {
        public IEnumerable<SelectListItem> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}