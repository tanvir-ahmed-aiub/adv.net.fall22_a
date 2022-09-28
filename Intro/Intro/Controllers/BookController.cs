using Intro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Intro.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            //TempData["msg"] = "Your task was successful";
            //String[] books = new string[] {"Himu","The alchemist","Misir Ali","Byomkesh","Harry Potter" };
            //ViewBag.books = books;
            //return View();

            List<Book> books = new List<Book>();
            for(int i = 1; i <= 10; i++)
            {
                var book = new Book() {
                    Id = i,
                    Title = "Book " + i,
                    Author = "Author of Book " + i,
                    Edition = 1
                };
                books.Add(book);
            }
            return View(books);
            //return RedirectToAction("Index","Home");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Book book) {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Student");
            }
            //ViewBag.BookName = Request["Title"];
            //
            //ViewBag.BookName = form["Title"];
            ViewBag.BookName = book.Author;
            return View(book);   
        }

        public ActionResult Details(int id) {
            Book book = new Book() { 
                Id = id,
                Title = "Book " + id,
                Author = "Author of Book " + id,
                Edition = 1,
            };
                
            return View(book);
        }
    }
}
