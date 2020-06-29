using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApp.BLL;
using BookApp.DAL;
using BookApp.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private BookServiceBLL BookObj = new BookServiceBLL(new BookDBDAL());

        [HttpGet]
        public ActionResult<List<Book>> GetAllBooks()
        {
            return BookObj.GetAllBookBLL();
        }

        [HttpPost]
        public ActionResult<Book> AddBook(Book book)
        {
            BookObj.AddBookBLL(book);

            return Ok();
        }

        [HttpGet("{categoryId}")]
        public ActionResult<List<Book>> GetBooksByCategoryId(int categoryId)
        {
            return BookObj.GetBookByCategoryIdBLL(categoryId);
        }

        [HttpPut]
        public ActionResult<Book> UpdateBook(Book book)
        {
            BookObj.UpdateBookBLL(book);

            return Ok();
        }

        [HttpGet("{bookId}")]
        public ActionResult<Book> GetBookByBookId(int bookId)
        {
            return BookObj.GetBookByBookIdBLL(bookId);
        }

    }
}