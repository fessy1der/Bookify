using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookify.Data;
using Bookify.Services;
using Bookify.Web.RequestModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bookify.Web.Controllers
{
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;
        private readonly IBookService _bookService;

        public BooksController(ILogger<BooksController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        [HttpGet("/api/books")]
        public IActionResult GetBooks()
        {
            var books = _bookService.GetAllBooks();
            return Ok(books);
        }

        [HttpGet("/api/books/{id}")]
        public IActionResult GetBook(int id)
        {
            var book = _bookService.GetBook(id);
            return Ok(book);
        }

        [HttpPost("/api/books")]
        public IActionResult CreateBook([FromBody] NewBookRequest bookRequest)
        {
            var now = DateTime.UtcNow;
            var book = new Book
            {
                DateCreated = now,
                DateUpdated = now,
                Title = bookRequest.Title,
                Author = bookRequest.Author
            };

            _bookService.AddBook(book);
            return Ok($"Book Created: {book.Title}");
        }

        [HttpPost("/api/books/{id}")]
        public IActionResult DeleteBook(int id)
        {
            _bookService.DeleteBook(id);
            return Ok($"book deleted with id: {id}");

        }
    }
}
