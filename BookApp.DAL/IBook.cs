using BookApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.DAL
{
    public interface IBook
    {
        bool AddBookDAL(Book book);
        List<Book> GetBookByCategoryIdDAL(int categoryid);
        List<Book> GetAllBooksDAL();
        Book GetBookByBookIdDAL(int BookId);
        bool UpdateBookDAL(Book book);
    }
}
