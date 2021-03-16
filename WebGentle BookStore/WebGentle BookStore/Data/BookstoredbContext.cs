﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle_BookStore.Data;

namespace Webgentle.BookStore.Data
{
    public class BookStoredbContext : DbContext
    {
        public BookStoredbContext(DbContextOptions<BookStoredbContext> options)
            : base(options)
        {

        }

        public DbSet<Books> Books { get; set; }
    }
}