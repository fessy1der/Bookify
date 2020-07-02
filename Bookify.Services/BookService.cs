using Bookify.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bookify.Services
{
    public class BookService : IBookService
    {
        private readonly ApplicationDbContext _db;

        public BookService(ApplicationDbContext db)
        {
            _db = db;
        }

        public void AddBook(Book book)
        {
            _db.Add(book);
            _db.SaveChanges();
        }

        public void DeleteBook(int bookId)
        {
            var book = GetBook(bookId);
            if (book != null)
            {
                _db.Remove(book);

            }
            _db.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            return _db.Books.ToList();
        }

        public Book GetBook(int bookId)
        {
            return _db.Books.Find(bookId);
        }
    }
}
