using HBSIS.BookManager.Model.DALs;
using HBSIS.BookManager.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBSIS.BookManager.Business.Business
{
    public class AuthorBusiness
    {
        public List<Author> List()
        {
            return new AuthorDAL().List();
        }

        public Author GetByName(string name)
        {
            return new AuthorDAL().GetByName(name);
        }

        public void Add(Author author)
        {
            new AuthorDAL().Add(author);
        }
    }
}
