using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle_BookStore.Models;

namespace WebGentle_BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();

        }
        public List<BookModel> SearchBook(string bookname, string authorname)
        {
            return DataSource().Where(x => x.BookName == bookname && x.AuthorName == authorname).ToList();

        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, BookName = "C#", AuthorName = "Arafat" },
                new BookModel() { Id = 2, BookName = "Java", AuthorName = "Shawon" },
                new BookModel() { Id = 3, BookName = "CPP", AuthorName = "Rubel" },
                new BookModel() { Id = 4, BookName = "C", AuthorName = "Arafat" },
            };
        }
    }
}
