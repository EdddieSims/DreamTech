using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace console.Models.Mapping
{
    public class tblFeaturedProductMap : EntityTypeConfiguration<tblFeaturedProduct>
    {
        public tblFeaturedProductMap()
        {
            // Primary Key
            this.HasKey(t => t.feature_id);

            // Properties
            this.Property(t => t.feature_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("tblFeaturedProduct");
            this.Property(t => t.feature_id).HasColumnName("feature_id");
            this.Property(t => t.product_id).HasColumnName("product_id");
            this.Property(t => t.active).HasColumnName("active");
        }
    }
}
