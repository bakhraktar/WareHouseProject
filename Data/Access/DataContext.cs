using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Access
{
    public class DataContext : DbContext
    {
        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<AccountentTree> AccountentTrees { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<JobPosition> JobPositions { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<MoneyUnit> MoneyUnits { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrganizationType> OrganizationTypes { get; set; }
        public DbSet<Origin> Origins { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<WareHouse> WareHouses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AccountentTree>().HasIndex(x => x.Code).IsUnique();
            modelBuilder.Entity<AccountentTree>().HasIndex(x => x.FullCode).IsUnique();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-B3Q553I\SQLEXPRESS;Initial Catalog=WareHouseDB;Integrated Security=True");
        }
    }
}