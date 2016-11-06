using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace console.Models.Mapping
{
    public class tbl_OrderMap : EntityTypeConfiguration<tbl_Order>
    {
        public tbl_OrderMap()
        {
            // Primary Key
            this.HasKey(t => t.order_id);

            // Properties
            this.Property(t => t.order_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.cart_ref)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblOrder");
            this.Property(t => t.order_id).HasColumnName("order_id");
            this.Property(t => t.user_id).HasColumnName("user_id");
            this.Property(t => t.cart_ref).HasColumnName("cart_ref");
            this.Property(t => t.order_status_id).HasColumnName("order_status_id");
            this.Property(t => t.delivery_address_id).HasColumnName("delivery_address_id");
            this.Property(t => t.order_total).HasColumnName("order_total");
            this.Property(t => t.promo_id).HasColumnName("promo_id");

            // Relationships
            this.HasRequired(t => t.tbl_DelivetyAddresses)
                .WithMany(t => t.tbl_Order)
                .HasForeignKey(d => d.delivery_address_id);
            this.HasRequired(t => t.tbl_OrderStatus)
                .WithMany(t => t.tbl_Order)
                .HasForeignKey(d => d.order_status_id);
            this.HasRequired(t => t.tbl_PromoCode)
                .WithMany(t => t.tbl_Order)
                .HasForeignKey(d => d.promo_id);
            this.HasRequired(t => t.tbl_User)
                .WithMany(t => t.tbl_Order)
                .HasForeignKey(d => d.user_id);

        }
    }
}
