﻿using AssignmentOnMVCWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentOnMVCWeb.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var product = GetProducts();
            return View(product);
        }
        private IEnumerable<Products> GetProducts()
        {
            return new List<Products>()
            {
                new Products { Id = 101, Name = "AC", Rate = 45000 },
                new Products { Id = 102, Name = "Mobile", Rate = 38000 },
                new Products { Id = 103, Name = "Bike", Rate = 94000 }
            };
        }
        public ActionResult Details(int id)
        {
            var product = GetProducts().SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(product);
            }
            
        }
    }
}