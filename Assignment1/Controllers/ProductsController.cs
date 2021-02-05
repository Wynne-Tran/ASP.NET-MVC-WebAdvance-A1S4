﻿using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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


        // GET - Edit
        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.Products.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }


        //POST Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Products obj)
        { 
            if (ModelState.IsValid)
            {
                _db.Products.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        // GET - Delete
        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.Products.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Products obj)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
    }
}
