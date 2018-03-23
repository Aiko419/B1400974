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
            return "Welcome BookStore! " + university;
        }

        public ActionResult ListBook()
        {
            var books = new List<string>();
            books.Add("ASP.NET MVC");
            books.Add("PHP & MySQL");
            books.Add("Java");
            ViewBag.Books = books;
            return View();

        }

        public ActionResult ListBookModel()
        {

            var books = new List<Book>();
            books.Add(new Book(1, "ASP.NET MVC", "Nguyễn Văn A", "/Content/Images/book1.jpg"));
            books.Add(new Book(2, "PHP & MySQL", "Lê Văn Tòng", "/Content/Images/book2.jpg"));
            books.Add(new Book(3, "Java", "Nguyễn Phúc Hậu", "/Content/Images/book3.jpg"));
            return View(books);

        }

        public ActionResult EditBook(int id)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "ASP.NET MVC", "Nguyễn Văn A", "/Content/Images/book1.png"));
            books.Add(new Book(2, "PHP & MySQL", "Lê Văn Tòng", "/Content/Images/book2.png"));
            books.Add(new Book(3, "Java", "Nguyễn Phúc Hậu", "/Content/Images/book3.png"));
            Book book = new Book();
            foreach (Book b in books)
            {
                if (b.ID == id)
                {
                    book = b;
                    break;
                }
            }
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        //Post: Book/EditBook/Id
        [HttpPost, ActionName("EditBook")] //Dữ liệu được post từ Client
        [ValidateAntiForgeryToken] //Security help
        public ActionResult EditBooḳSave(int id, string Title, string Author, string Image_cover)
        {
            //Dữ liệu sách ban đầu
            var books = new List<Book>();
            books.Add(new Book(1, "ASP.NET MVC", "Nguyễn Văn A", "/Content/Images/book1.png"));
            books.Add(new Book(2, "PHP & MySQL", "Lê Văn Tòng", "/Content/Images/book2.png"));
            books.Add(new Book(3, "Java", "Nguyễn Phúc Hậu", "/Content/Images/book3.png"));

            if (id == null)
            {
                return HttpNotFound();
            }
            //Lặp tìm cuốn sách theo id và gán giá trị cập nhật
            foreach (Book b in books)
            {
                if (b.ID == id)
                {
                    b.TITLE = Title;
                    b.AUTHOR = Author;
                    b.IMAGE_COVER = Image_cover;
                    break;
                }
            }
            //Trả về wiew "ListBookModel" kèm theo đối tượng books, sau khi cập nhật
            return View("ListBookModel", books);
        }

        public ActionResult CreateBook()
        {
            return View();
        }

        //Hàm thêm sách mới
        [HttpPost, ActionName("CreateBook")] //Dữ liệu được post từ Client
        [ValidateAntiForgeryToken] //Security help
        public ActionResult CreateBook([Bind(Include = "Id, Title, Author, ImageCover")]Book book)
        {
            //Dữ liệu sách ban đầu
            var books = new List<Book>();
            books.Add(new Book(1, "ASP.NET MVC", "Nguyễn Văn A", "/Content/Images/book1.png"));
            books.Add(new Book(2, "PHP & MySQL", "Lê Văn Tòng", "/Content/Images/book2.png"));
            books.Add(new Book(3, "Java", "Nguyễn Phúc Hậu", "/Content/Images/book3.png"));
            try
            {
                if (ModelState.IsValid)
                {
                    //Thêm mới sách
                    books.Add(book);
                }
            }
            catch (Exception /*dex*/)
            {
                ModelState.AddModelError("", "Error save data");
            }
            return View("ListBookModel", books);

        }
    }
}