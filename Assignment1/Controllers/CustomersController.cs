using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Controllers
{
    public class CustomersController : Controller
    {
        private ProductsContext _db { get; set; }

        public CustomersController(ProductsContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Customers> objList = _db.Customers;
            return View(objList);
        }

        // GET - Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "Create";
            ViewBag.Country = _db.Country.OrderBy(g => g.Name).ToList();
            return View("Edit", new Customers());
        }


        [HttpGet]
        public IActionResult Edit(int Id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Country = _db.Country.OrderBy(g => g.Name).ToList();
            var obj = _db.Customers.Find(Id);
            return View(obj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customers obj)
        {
            if (ModelState.IsValid)
            {
                _db.Customers.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Action = "Create";
            ViewBag.Country = _db.Country.OrderBy(g => g.Name).ToList();
            return View("Edit");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Customers obj)
        {
            if (ModelState.IsValid)
            {
                _db.Customers.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Action = "Edit";
            ViewBag.Country = _db.Country.OrderBy(g => g.Name).ToList();
            return View("Edit");
        }

        // GET - Delete
        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            var obj = _db.Customers.Find(Id);
            ViewBag.Action = "Delete";
            ViewBag.Country = _db.Country.OrderBy(g => g.Name).ToList();
            return View(obj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Customers obj)
        {
            if (ModelState.IsValid)
            {
                _db.Customers.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
    }

}
