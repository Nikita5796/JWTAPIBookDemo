using BookApp.DAL;
using BookApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.BLL
{
    public class BookServiceBLL
    {
        IBook bookDAL;

        public BookServiceBLL(IBook BookDAL)
        {
            this.bookDAL = BookDAL;
        }

        public List<Book> GetAllBookBLL()
        {
            try
            {
                return bookDAL.GetAllBooksDAL();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddBookBLL(Book book)
        {
            bool status = false;

            try
            {
                status = bookDAL.AddBookDAL(book);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return status;
        }

        public List<Book> GetBookByCategoryIdBLL(int categoryid)
        {
            try
            {
                return bookDAL.GetBookByCategoryIdDAL(categoryid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateBookBLL(Book book)
        {
            bool status = false;

            try
            {
                status = bookDAL.UpdateBookDAL(book);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return status;
        }

        public Book GetBookByBookIdBLL(int BookId)
        {
            try
            {
                return bookDAL.GetBookByBookIdDAL(BookId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
