using BookApp.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookApp.Controllers
{
    public class BookAppController : Controller
    {
        private readonly BookAppContext bookAppContext;
        public BookAppController()
        {
            bookAppContext = new BookAppContext();
        }
        [HttpGet]
        public IActionResult Index()
        {
            var books = bookAppContext.Books;
            return View(books);
        }
        [Route("Create")]
        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                bookAppContext.Books.Add(book);
                bookAppContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [Route("Edit")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = bookAppContext.Books.Single(b=>b.BookId == id);
            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                bookAppContext.Books.Update(book);
                bookAppContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [Route("Delete")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var book = bookAppContext.Books.Single(b=>b.BookId==id);
            return View(book);
        }
        [HttpPost]
        public IActionResult Delete(Book book)
        {
            bookAppContext.Books.Remove(book);
            bookAppContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [Route("Details")]
        [HttpGet]
        public IActionResult Details(int id)
        {
            var book = bookAppContext.Books.Single(b=>b.BookId==id);
            return View(book);
        }
        [Route("Author")]
        public IActionResult Author(string Author)
        {
            var books = bookAppContext.Books.Where(b=>b.Author==Author);
            return View(books);
        }
        [Route("Language")]
        public IActionResult Language(string Language)
        {
            var books = bookAppContext.Books.Where(b => b.Language == Language);
            return View(books);
        }
        [Route("Year")]
        public IActionResult Year(int year)
        {
            var books = bookAppContext.Books.Where(b=>b.ReleaseDate.Year ==  year);
            return View(books);
        }
    }
}
