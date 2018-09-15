using HBSIS.BookManager.Model.Models;
using System.Data.Entity.ModelConfiguration;

namespace HBSIS.BookManager.DAL.Mapping
{
    public class BookMapping : EntityTypeConfiguration<Book>
    {
        public BookMapping()
        {

            this.ToTable("Book", "dbo");

            this.HasKey(a => a.BookId);

            this.Property(a => a.BookId).HasColumnName("BookId").IsRequired();
            this.Property(a => a.Name).HasColumnName("Name").IsRequired();
            this.Property(a => a.Price).HasColumnName("Price").HasPrecision(19, 4);
            this.Property(a => a.Quantity).HasColumnName("Quantity");
            this.Property(a => a.AuthorId).HasColumnName("AuthorId").IsRequired();

            this.Ignore(f => f.Author);
        }
    }
}
