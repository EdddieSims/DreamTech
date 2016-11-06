using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace console.Models.Mapping
{
    public class tblProductMap : EntityTypeConfiguration<tblProduct>
    {
        public tblProductMap()
        {
            // Primary Key
            this.HasKey(t => t.product_id);

            // Properties
            this.Property(t => t.product_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("tblProduct");
            this.Property(t => t.product_id).HasColumnName("product_id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.units).HasColumnName("units");
            this.Property(t => t.categoty_id).HasColumnName("categoty_id");
            this.Property(t => t.price_id).HasColumnName("price_id");
            this.Property(t => t.type_id).HasColumnName("type_id");

            // Relationships
            this.HasRequired(t => t.btl_ProductPrice)
                .WithMany(t => t.tblProducts)
                .HasForeignKey(d => d.price_id);
            this.HasRequired(t => t.tbl_ProductType)
                .WithMany(t => t.tblProducts)
                .HasForeignKey(d => d.type_id);
            this.HasRequired(t => t.tblProductCategory)
                .WithMany(t => t.tblProducts)
                .HasForeignKey(d => d.categoty_id);

        }
    }
}
