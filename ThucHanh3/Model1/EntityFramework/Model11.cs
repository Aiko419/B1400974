namespace Model1.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model11 : DbContext
    {
        public Model11()
            : base("name=Model11")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Chapter> Chapters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(e => e.CoverPage)
                .IsUnicode(false);
            modelBuilder.Entity<Book>().Property(e => e.Title).IsUnicode(false);
            modelBuilder.Entity<Book>().Property(e => e.CoverPage).IsUnicode(false);
            modelBuilder.Entity<Book>().Property(e => e.AuthorName).IsUnicode(false);
        }
    }
}
