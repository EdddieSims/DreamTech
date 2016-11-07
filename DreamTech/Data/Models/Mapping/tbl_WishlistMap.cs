using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace console.Models.Mapping
{
    public class tbl_WishlistMap : EntityTypeConfiguration<tbl_Wishlist>
    {
        public tbl_WishlistMap()
        {
            // Primary Key
            this.HasKey(t => t.wishlist_id);

            // Properties
            this.Property(t => t.wishlist_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("tblWishlist");
            this.Property(t => t.wishlist_id).HasColumnName("wishlist_id");
            this.Property(t => t.user_id).HasColumnName("user_id");

            // Relationships
            this.HasRequired(t => t.tbl_User)
                .WithMany(t => t.tbl_Wishlist)
                .HasForeignKey(d => d.user_id);

        }
    }
}
