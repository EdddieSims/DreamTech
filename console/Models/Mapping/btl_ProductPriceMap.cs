using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace console.Models.Mapping
{
    public class btl_ProductPriceMap : EntityTypeConfiguration<btl_ProductPrice>
    {
        public btl_ProductPriceMap()
        {
            // Primary Key
            this.HasKey(t => t.price_id);

            // Properties
            this.Property(t => t.price_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("btl.ProductPrice");
            this.Property(t => t.price_id).HasColumnName("price_id");
            this.Property(t => t.product_price).HasColumnName("product_price");
        }
    }
}
