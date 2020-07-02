using System;
using System.Collections.Generic;
using System.Text;

namespace Bookify.Data
{
    public class Review
    {
        public int Id { get; set; }
        public string ReviewAuthor { get; set; }
        public string ReviewContent { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public Book BookReviewed { get; set; }

    }
}
