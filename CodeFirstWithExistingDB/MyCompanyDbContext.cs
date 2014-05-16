using System.Data.Entity;

namespace CodeFirstWithExistingDB
{
    public class MyCompanyDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public MyCompanyDbContext()
        {
            Database.SetInitializer<MyCompanyDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductModelConfiguration());
        }
    }
}