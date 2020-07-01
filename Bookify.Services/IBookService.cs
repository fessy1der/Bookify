using Bookify.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookify.Services
{
    public interface IBookService
    {
        public List<Book> GetAllBooks();
        public Book GetBook(int bookId);
        public void AddBook(Book book);
        public void DeleteBook(int bookId);
    }
}
