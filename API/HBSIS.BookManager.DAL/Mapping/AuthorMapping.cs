using HBSIS.BookManager.Model.Models;
using System.Data.Entity.ModelConfiguration;

namespace HBSIS.BookManager.DAL.Mapping
{
    public class AuthorMapping : EntityTypeConfiguration<Author>
    {
        public AuthorMapping()
        {
            this.ToTable("Author", "dbo");

            this.HasKey(a => a.AuthorId);

            this.Property(a => a.AuthorId).HasColumnName("AuthorId").IsRequired();
            this.Property(a => a.Name).HasColumnName("Name").IsRequired();
            this.Property(a => a.Age).HasColumnName("Age").IsRequired();

            this.Ignore(f => f.Books);
            /*this.HasMany(a => a.Books)
                .WithOptional()
                .HasForeignKey(f=> f.BookId);*/
        }
    }
}
