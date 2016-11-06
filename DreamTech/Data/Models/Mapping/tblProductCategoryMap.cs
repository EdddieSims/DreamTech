using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace console.Models.Mapping
{
    public class tblProductCategoryMap : EntityTypeConfiguration<tblProductCategory>
    {
        public tblProductCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.category_id);

            // Properties
            this.Property(t => t.category_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.product_category)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("tblProductCategory");
            this.Property(t => t.category_id).HasColumnName("category_id");
            this.Property(t => t.product_category).HasColumnName("product_category");
        }
    }
}
