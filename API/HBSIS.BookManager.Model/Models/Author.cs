namespace HBSIS.BookManager.Model.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Author
    {
        public Author()
        {
            Books = new List<Book>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AuthorId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
