using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductsContext _db;

        public ProductsController(ProductsContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Products> objList = _db.Products;
            return View(objList);
        }

        // GET - Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //POST CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Products obj)
        {
           if (ModelState.IsValid)
            {
                _db.Products.Add(obj);
                _db.SaveChanges();
               return RedirectToAction("Index");
            }
            return View(obj);

        }
    }
}
