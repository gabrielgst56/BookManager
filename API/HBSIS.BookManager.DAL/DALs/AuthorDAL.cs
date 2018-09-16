using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HBSIS.BookManager.Model.Models;
using HBSIS.BookManager.Model.Context;

namespace HBSIS.BookManager.Model.DALs
{
    public class AuthorDAL
    {
        public List<Author> List()
        {
            var context = new HBSISContext();

            return context.Author.AsNoTracking().OrderBy(f => f.Name).ToList();
        }

        public void Add(Author author)
        {
            var context = new HBSISContext();

            author.AuthorId = GetMaxId() + 1;

            context.Author.Add(author);
            context.SaveChanges();
        }

        private int GetMaxId()
        {
            var context = new HBSISContext();

            return context.Author.Max(f => f.AuthorId);
        }

        public Author GetByName(string name)
        {
            var context = new HBSISContext();

            return context.Author.AsNoTracking().FirstOrDefault(f => f.Name == name);
        }
    }
}
