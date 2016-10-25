using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace console.Models.Mapping
{
    public class tbl_ProductTypeMap : EntityTypeConfiguration<tbl_ProductType>
    {
        public tbl_ProductTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.type_id);

            // Properties
            this.Property(t => t.type_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.product_type)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("tbl.ProductType");
            this.Property(t => t.type_id).HasColumnName("type_id");
            this.Property(t => t.product_type).HasColumnName("product_type");
        }
    }
}
