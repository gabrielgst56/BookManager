using System.ComponentModel.DataAnnotations.Schema;

namespace HBSIS.BookManager.Model.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int BookId { get; set; }
     
        public string Name { get; set; }

        public decimal? Price { get; set; }

        public int AuthorId { get; set; }

        public int Quantity { get; set; }

        public virtual Author Author { get; set; }
    }
}
