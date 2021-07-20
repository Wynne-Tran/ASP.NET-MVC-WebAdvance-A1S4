using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Controllers
{
    public class IncidentsController : Controller
    {
        private ProductsContext _db { get; set; }

        public IncidentsController(ProductsContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            //IEnumerable<Incidents> objList = _db.Incidents;
            //return View(objList);
            var movies = _db.Incidents
                 .Include(m => m.CustomerName)
                 .Include(g => g.ProductName)
                 .ToList();
            return View(movies);
        }

        // GET - Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "Create";
            ViewBag.Customers = _db.Customers.OrderBy(g => g.FirstName + g.LastName).ToList();
            ViewBag.Products = _db.Products.OrderBy(g => g.Name).ToList();
            ViewBag.Technicians = _db.Technicians.OrderBy(g => g.Name).ToList();
            return View("Edit", new Incidents());
        }


        [HttpGet]
        public IActionResult Edit(int Id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Customers = _db.Customers.OrderBy(g => g.FirstName + g.LastName).ToList();
            ViewBag.Products = _db.Products.OrderBy(g => g.Name).ToList();
            ViewBag.Technicians = _db.Technicians.OrderBy(g => g.Name).ToList();
            var obj = _db.Incidents.Find(Id);
            return View(obj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Incidents obj)
        {
            if (ModelState.IsValid)
            {
                _db.Incidents.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Action = "Create";
            ViewBag.Customers = _db.Customers.OrderBy(g => g.FirstName + g.LastName).ToList();
            ViewBag.Products = _db.Products.OrderBy(g => g.Name).ToList();
            ViewBag.Technicians = _db.Technicians.OrderBy(g => g.Name).ToList();
            return View("Edit");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Incidents obj)
        {
            if (ModelState.IsValid)
            {
                _db.Incidents.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Action = "Edit";
            ViewBag.Customers = _db.Customers.OrderBy(g => g.FirstName + g.LastName).ToList();
            ViewBag.Products = _db.Products.OrderBy(g => g.Name).ToList();
            ViewBag.Technicians = _db.Technicians.OrderBy(g => g.Name).ToList();
            return View("Edit");
        }

        // GET - Delete
        
        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            var obj = _db.Incidents.Find(Id);
            ViewBag.Action = "Delete";
            ViewBag.Customers = _db.Customers.OrderBy(g => g.FirstName + g.LastName).ToList();
            ViewBag.Products = _db.Products.OrderBy(g => g.Name).ToList();
            ViewBag.Technicians = _db.Technicians.OrderBy(g => g.Name).ToList();
            return View(obj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Incidents obj)
        {
            _db.Incidents.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }

}
