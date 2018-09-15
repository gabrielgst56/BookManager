namespace HBSIS.BookManager.Model.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using HBSIS.BookManager.Model.Models;
    using HBSIS.BookManager.DAL.Mapping;

    public partial class HBSISContext : DbContext
    {
        public HBSISContext()
            : base("name=Database")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = true;
            Database.SetInitializer<HBSISContext>(null);
            this.Database.Initialize(true);

        }

        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Book { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookMapping());
            modelBuilder.Configurations.Add(new AuthorMapping());
        }
    }
}
