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
                new BookModel() { Id = 1, BookName = "C#", Description="This is a c# Programming books. Mannualy description", AuthorName = "Arafat Rahman" },
                new BookModel() { Id = 2, BookName = "Java", Description="This is a Java Programming books. Mannualy description", AuthorName = "Shawon Mahmud" },
                new BookModel() { Id = 3, BookName = "CPP", Description="This is a c++ Programming books. Mannualy description", AuthorName = "Rubel Hossain" },
                new BookModel() { Id = 4, BookName = "C", Description="This is a C Programming books. Mannualy description", AuthorName = "Saiful Islam" },
            
           };
        }
    }
}
