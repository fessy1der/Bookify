using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookify.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(){}
        public ApplicationDbContext( DbContextOptions options) : base(options){ }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Review> BookReviews { get; set; }
    }
}
