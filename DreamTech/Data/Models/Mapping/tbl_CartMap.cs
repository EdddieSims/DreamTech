using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace console.Models.Mapping
{
    public class tbl_CartMap : EntityTypeConfiguration<tbl_Cart>
    {
        public tbl_CartMap()
        {
            // Primary Key
            this.HasKey(t => t.cart_id);

            // Properties
            this.Property(t => t.cart_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cart_ref)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tbl.Cart");
            this.Property(t => t.cart_id).HasColumnName("cart_id");
            this.Property(t => t.cart_ref).HasColumnName("cart_ref");
            this.Property(t => t.cart_total).HasColumnName("cart_total");
        }
    }
}
