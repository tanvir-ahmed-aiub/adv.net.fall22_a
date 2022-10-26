using E_commerce.Models;
using E_commerce.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_commerce.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View(ProductRepo.Get());
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View(ProductRepo.Get(id));
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            ViewBag.categories = CategoryRepo.Get();
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductModel product)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid) {
                    ProductRepo.Create(product);
                    return RedirectToAction("Index");
                }
                ViewBag.categories = CategoryRepo.Get();
                return View(product);

            }
            catch
            {
                ViewBag.categories = CategoryRepo.Get();
                return View(product);
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
