using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HBSIS.BookManager.Model.DALs;
using HBSIS.BookManager.Model.Models;

namespace HBSIS.BookManager.Business.Business
{
    public class BookBusiness
    {
        public List<Book> List()
        {
            return new BookDAL().List();
        }

        public void Add(Book book)
        {
            new BookDAL().Add(book);
        }

        public void Edit(Book book)
        {
            new BookDAL().Edit(book);
        }

        public void Remove(int bookId)
        {
            new BookDAL().Remove(bookId);
        }
    }
}
