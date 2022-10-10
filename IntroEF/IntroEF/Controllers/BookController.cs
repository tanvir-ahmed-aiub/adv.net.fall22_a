using IntroEF.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroEF.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            //receive book from db
            var db = new LibraryMSEntities();
            var books = db.Books.ToList();
            return View(books);
        }
        [HttpGet]
        public ActionResult Create() {
            
            return View();
        }
        [HttpPost]
        public ActionResult Create(Book book) {

            //add book to db
            var db = new LibraryMSEntities();
            db.Books.Add(book);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id) {
            var db = new LibraryMSEntities();
            var book = (from b in db.Books 
                        where b.Id == id 
                        select b).SingleOrDefault();
            return View(book);
        }
        [HttpPost]
        public ActionResult Edit(Book book)
        {
            var db = new LibraryMSEntities();
            //
            //db.Books.Find(book.Id);
            var ext = (from b in db.Books
                       where b.Id == book.Id
                       select b).SingleOrDefault();
            //ext.Author = book.Author;
            //ext.Name = book.Name;
            //ext.Price = book.Price;
            //ext.Edition = book.Edition;

            db.Entry(ext).CurrentValues.SetValues(book);

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        //delete db.Books.Remove(book);
        //db.SaveChanges();
    }
}