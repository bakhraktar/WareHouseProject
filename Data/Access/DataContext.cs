using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Access
{
    public class DataContext : DbContext
    {
        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<WareHouse> WareHouses { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<WareHouse>().Property(x => new { x.Name, x.Report, x.Code, x.Adress }).IsRequired();
            modelBuilder.Entity<Product>().Property(x => new { x.Name, x.InternalReport, x.MyProperty, x.EnglishName }).IsRequired();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=GIORG;Initial Catalog=WareHouseDB;Integrated Security=True");
        }
    }
}
