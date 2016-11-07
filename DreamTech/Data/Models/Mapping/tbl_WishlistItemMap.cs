using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace console.Models.Mapping
{
    public class tbl_WishlistItemMap : EntityTypeConfiguration<tbl_WishlistItem>
    {
        public tbl_WishlistItemMap()
        {
            // Primary Key
            this.HasKey(t => t.wishlist_item_id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblWishlistItem");
            this.Property(t => t.wishlist_item_id).HasColumnName("wishlist_item_id");
            this.Property(t => t.user_id).HasColumnName("user_id");
            this.Property(t => t.product_id).HasColumnName("product_id");
            this.Property(t => t.price_id).HasColumnName("price_id");

            // Relationships
            this.HasRequired(t => t.btl_ProductPrice)
                .WithMany(t => t.tbl_WishlistItem)
                .HasForeignKey(d => d.price_id);
            this.HasRequired(t => t.tblProduct)
                .WithMany(t => t.tbl_WishlistItem)
                .HasForeignKey(d => d.product_id);

        }
    }
}
