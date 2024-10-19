using Microsoft.EntityFrameworkCore;
using ZurroService.Models;

namespace ZurroService.Data
{
    public class ZurroDBContext : DbContext
    {
        public ZurroDBContext(DbContextOptions<ZurroDBContext> opt) : base(opt) { }

        public DbSet<ZUser> ZUser 
        { 
            get;
            set;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ZUser>().ToTable(Info.MySQLTable);
        }
    }
}
