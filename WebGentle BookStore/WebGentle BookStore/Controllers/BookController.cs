using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle_BookStore.Models;
using WebGentle_BookStore.Repository;

namespace WebGentle_BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository= null; 
        public BookController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;

        }
        public ViewResult GetAllBooks()
        {
            var data= _bookRepository.GetAllBooks();
            return View(data);
        }
        public ViewResult GetBook(int id)
        {
            var book_details =  _bookRepository.GetBookById(id);
            return View(book_details);
        }

        public List<BookModel> SearchBook(string BookName, string AuthorName)
        {
            return _bookRepository.SearchBook(BookName, AuthorName);
        }
        public ViewResult AddBook(bool isSuccess = false, int bookid=0)
        {
            ViewBag.IsSuccess = isSuccess;
            ViewBag.Bookid = bookid;
            return View();
        }

        [HttpPost]

        public IActionResult AddBook(BookModel bookModel)
        {
           int id = _bookRepository.AddNewBook(bookModel);
            if(id>0)
            {
                return RedirectToAction(nameof(AddBook), new { isSuccess = true, bookid =  id});
            }

            return View();
        }
    }
}
