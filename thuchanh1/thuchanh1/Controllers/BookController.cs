using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thuchanh1.Models;

namespace thuchanh1.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public string HelloBookStore(string university)
        {
            return "Welcome BookStore! "+ university;
        }

        public ActionResult ListBooḳ()
        {
            var books = new List<string>();
            books.Add("ASP.NET MVC");
            books.Add("PHP & MySQL");
            books.Add("Java");
            ViewBag.Books = books;
            return View();

        }

        public ActionResult ListBooḳModel()
        {

            var books = new List<Book>();
            books.Add(new Book(1, "ASP.NET MVC", "Nguyễn Văn A", "/Content/Images/book1.jpg"));
            books.Add(new Book(2, "PHP & MySQL", "Lê Văn Tòng", "/Content/Images/book2.jpg"));
            books.Add(new Book(3, "Java", "Nguyễn Phúc Hậu", "/Content/Images/book3.jpg"));
            return View(books);

        }


    }
}