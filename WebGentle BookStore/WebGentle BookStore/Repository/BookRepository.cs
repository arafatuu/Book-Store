using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Data;
using WebGentle_BookStore.Data;
using WebGentle_BookStore.Models;

namespace WebGentle_BookStore.Repository
{
    
    
    public class BookRepository
    {
        private readonly BookStoredbContext _context = null;
        public BookRepository(BookStoredbContext context)
        {
            _context = context;
        }

        public int AddNewBook(BookModel model)
        {
            var newBook = new Books()
            {
                Description = model.Description,
                AuthorName = model.AuthorName,
                BookName = model.BookName,
                TotalPages = model.TotalPages,
                CreateOn = DateTime.UtcNow,
                UpdateOn = DateTime.UtcNow,
            };
            _context.Books.Add(newBook);
            _context.SaveChanges();

            return newBook.Id;
        }
        public async Task<List<BookModel>> GetAllBooks()
        {
            var AllBooks = new List<BookModel>();

            var allbooksdb = await _context.Books.ToListAsync();
            if (allbooksdb?.Any() == true)
            {
                foreach(var book in allbooksdb)
                {
                    AllBooks.Add(new BookModel()
                    {
                        AuthorName = book.AuthorName,
                        Catagory = book.Catagory,
                        Description = book.Description,
                        Id = book.Id,
                        Languages = book.Languages,
                        BookName = book.BookName,
                        TotalPages = book.TotalPages
                    });
                }
                return AllBooks;
            }

            return null;
        }
        public async Task<BookModel> GetBookById(int id)
        {
            var bookdb = await _context.Books.FindAsync(id);

            if(bookdb!=null)
            {
                var bookdetails = new BookModel()
                {
                    AuthorName = bookdb.AuthorName,
                    Catagory = bookdb.Catagory,
                    Description = bookdb.Description,
                    Id = bookdb.Id,
                    Languages = bookdb.Languages,
                    BookName = bookdb.BookName,
                    TotalPages = bookdb.TotalPages
                };
                return bookdetails;
            }
            return null;

        }
        public List<BookModel> SearchBook(string bookname, string authorname)
        {
            return DataSource().Where(x => x.BookName == bookname && x.AuthorName == authorname).ToList();

        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, BookName = "Coding Interview", Description="This is a  Programming books.It has discussed about prepation for software company as a fresher", AuthorName = "Tamim Shahriar Subeen", Catagory="Pogramming", TotalPages=180, Languages="Bangla" },
                new BookModel() { Id = 2, BookName = "Teach Yourself C++", Description="This is a C++ Programming book. Mannualy description", AuthorName = "Herbert Schildt", Catagory="Programming", Languages="English", TotalPages=576 },
                new BookModel() { Id = 3, BookName = "Gavi Brittanto", Description="This is a c++ Novel Book. Mannualy description", AuthorName = "Ahmed Sofa", Catagory="Novel", TotalPages=125, Languages="Bangla"},
                new BookModel() { Id = 4, BookName = "dry ironic wit", Description="This is a poetry book. Mannualy description", AuthorName = "John Keats", Catagory="Poetry" , Languages="English", TotalPages=234 },
            
           };
        }
    }
}
