using Day30.Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Day30.Practice.Controllers
{
    public class ClothesController : Controller
    {
        private readonly ApplicationDbContext _dbContext = null;

        public ClothesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Clothes
        public ActionResult Clothes()
        {
            return View();
        }
    }
}