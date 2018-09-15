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
            try
            {
                var context = new HBSISContext();

                return context.Author.AsNoTracking().OrderBy(f=> f.Name).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Author GetByName(string name)
        {
            try
            {
                var context = new HBSISContext();

                return context.Author.AsNoTracking().FirstOrDefault(f=> f.Name == name);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
