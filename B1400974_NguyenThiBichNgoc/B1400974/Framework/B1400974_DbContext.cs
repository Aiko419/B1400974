namespace B1400974.Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class B1400974_DbContext : DbContext
    {
        public B1400974_DbContext()
            : base("name=B1400974_DbContext")
        {
        }

        public virtual DbSet<lopchuyennganh> lopchuyennganhs { get; set; }
        public virtual DbSet<sinhvien> sinhviens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<lopchuyennganh>()
                .HasMany(e => e.sinhviens)
                .WithRequired(e => e.lopchuyennganh)
                .WillCascadeOnDelete(false);
        }
    }
}
