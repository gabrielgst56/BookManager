using HBSIS.BookManager.Model.Context;
using HBSIS.BookManager.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBSIS.BookManager.Model.DALs
{
    public class BookDAL
    {
        public List<Book> List()
        {

            var context = new HBSISContext();

            var books = context.Book.OrderBy(f => f.Name).ToList();

            books.ForEach(f =>
            {
                f.Author = context.Author.FirstOrDefault(x => x.AuthorId == f.AuthorId);
            });

            return books;

        }

        public void Remove(int id)
        {
            var context = new HBSISContext();

            var bookId = new Book { BookId = id };

            context.Book.Attach(bookId);
            context.Entry(bookId).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

        public void Edit(Book book)
        {

            var context = new HBSISContext();

            var oldBook = context.Book.FirstOrDefault(f => f.BookId == book.BookId);

            oldBook.Name = book.Name;
            oldBook.Price = book.Price;
            oldBook.Quantity = book.Quantity;

            context.SaveChanges();


        }

        public void Add(Book book)
        {

            var context = new HBSISContext();

            book.BookId = GetMaxId() + 1;

            context.Book.Add(book);
            context.SaveChanges();


        }

        private int GetMaxId()
        {
            return new HBSISContext().Book.Max(F => F.BookId);
        }

        public List<Book> GetByName(string name)
        {

            var context = new HBSISContext();

            return context.Book.AsNoTracking().Where(f => f.Name.Contains(name)).OrderBy(f => f.Name).ToList();

        }
    }
}
