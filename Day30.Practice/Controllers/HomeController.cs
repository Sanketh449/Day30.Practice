using Day30.Practice.Models;
using Day30.Practice.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Day30.Practice.Controllers
{
  
            [RoutePrefix("Home")]
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _dbContext = null;

            public HomeController()
            {
                _dbContext = new ApplicationDbContext();
            }

            private IEnumerable<SelectListItem> PopulateCategories()
            {
                return _dbContext.Categories.Select(c => new SelectListItem
                {
                    Value = c.Name,
                    Text = c.Name,
                }).AsEnumerable();
            }

            public ActionResult Index()
            {
                ProductsByCategoryVM productsByCategory = new ProductsByCategoryVM();
                var categories = PopulateCategories();
                productsByCategory.Categories = categories;
                return View(productsByCategory);
            }

            //[HttpGet]        
            public ActionResult GetProducts(string CategoryName)
            {
                ProductsByCategoryVM productsByCategory = new ProductsByCategoryVM();
                var products = _dbContext.Products.Include(p => p.Category).Where(p => p.Category.Name == CategoryName);
                productsByCategory.Products = products;

                var categories = PopulateCategories();
                productsByCategory.Categories = categories;
                return View("Index", productsByCategory);
            }

            public ActionResult Action()
            {
                return View();
            }

            public ActionResult About()
            {
                ViewBag.Message = "Your application description page.";

                return View();
            }

            public ActionResult Contact()
            {
                ViewBag.Message = "Your contact page.";

                return View();
            }
        }
    }
