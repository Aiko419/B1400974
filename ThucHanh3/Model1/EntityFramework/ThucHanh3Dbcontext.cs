using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1.EntityFramework
{
    public partial class ThucHanh3DbContext : DbContext
    {
        public ThucHanh3DbContext() : base("name=ThucHanh3DbContext")
        {

        }
         
        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().Property(e => e.UserName).IsUnicode(false);
            modelBuilder.Entity<Account>().Property(e => e.Password).IsUnicode(false);
        }
    }
}
