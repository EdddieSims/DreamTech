using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace console.Models.Mapping
{
    public class tbl_CartItemMap : EntityTypeConfiguration<tbl_CartItem>
    {
        public tbl_CartItemMap()
        {
            // Primary Key
            this.HasKey(t => t.cart_item_id);

            // Properties
            this.Property(t => t.cart_item_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cart_ref)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tbl.CartItem");
            this.Property(t => t.cart_item_id).HasColumnName("cart_item_id");
            this.Property(t => t.cart_ref).HasColumnName("cart_ref");
            this.Property(t => t.product_id).HasColumnName("product_id");
            this.Property(t => t.quantity).HasColumnName("quantity");
        }
    }
}
