using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Controllers
{
    public class TechniciansController : Controller
    {
        private ProductsContext _db { get; set; }

        public TechniciansController(ProductsContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Technicians> objList = _db.Technicians;
            return View(objList);
        }

        // GET - Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "Create";
            return View("Edit", new Technicians());
        }


        [HttpGet]
        public IActionResult Edit(int Id)
        {
            ViewBag.Action = "Edit";
            var obj = _db.Technicians.Find(Id);
            return View(obj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Technicians obj)
        {
            if (ModelState.IsValid)
            {
                _db.Technicians.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Action = "Create";
            return View("Edit");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Technicians obj)
        {
            if (ModelState.IsValid)
            {
                _db.Technicians.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Action = "Edit";
            return View("Edit");
        }

        // GET - Delete
        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            var obj = _db.Technicians.Find(Id);
            return View(obj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Technicians obj)
        {
            if (ModelState.IsValid)
            {
                _db.Technicians.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
    }

}
