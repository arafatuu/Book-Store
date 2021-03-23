using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGentle_BookStore.Data
{
    public class Books
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string Description { get; set; }


        public string Catagory { get; set; }
        public int TotalPages { get; set; }
        public string Languages { get; set; }

        public DateTime? CreateOn { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
