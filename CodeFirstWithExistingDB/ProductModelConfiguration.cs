using System.Data.Entity.ModelConfiguration;

namespace CodeFirstWithExistingDB
{
    public class ProductModelConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductModelConfiguration()
        {
            ToTable("tblProduct");

            Property(x => x.Id).HasColumnName("intId");
            HasKey(x => x.Id);

            Property(x => x.Name).HasColumnName("strName");
        }
    }
}