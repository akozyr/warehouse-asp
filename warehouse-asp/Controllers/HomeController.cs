using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using warehouse_asp.Models;

namespace warehouse_asp.Controllers
{
    public class HomeController : Controller
    {
        private ProductDBContext db = new ProductDBContext();
        
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Catalog);
            return View(products.ToList());
        }
    }
}