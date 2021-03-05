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
                new BookModel() { Id = 1, BookName = "Coding Interview", Description="This is a  Programming books.It has discussed about prepation for software company as a fresher", AuthorName = "Tamim Shahriar Subeen", Catagory="Pogramming", TotalPages=180, Languages="Bangla" },
                new BookModel() { Id = 2, BookName = "Teach Yourself C++", Description="This is a C++ Programming book. Mannualy description", AuthorName = "Herbert Schildt", Catagory="Programming", Languages="English", TotalPages=576 },
                new BookModel() { Id = 3, BookName = "Gavi Brittanto", Description="This is a c++ Novel Book. Mannualy description", AuthorName = "Ahmed Sofa", Catagory="Novel", TotalPages=125, Languages="Bangla"},
                new BookModel() { Id = 4, BookName = "dry ironic wit", Description="This is a poetry book. Mannualy description", AuthorName = "John Keats", Catagory="Poetry" , Languages="English", TotalPages=234 },
            
           };
        }
    }
}
