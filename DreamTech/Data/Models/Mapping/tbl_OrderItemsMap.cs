using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace console.Models.Mapping
{
    public class tbl_OrderItemsMap : EntityTypeConfiguration<tbl_OrderItems>
    {
        public tbl_OrderItemsMap()
        {
            // Primary Key
            this.HasKey(t => t.order_item_id);

            // Properties
            this.Property(t => t.order_item_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.item_reference)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tbl.OrderItems");
            this.Property(t => t.order_item_id).HasColumnName("order_item_id");
            this.Property(t => t.item_reference).HasColumnName("item_reference");
            this.Property(t => t.product_id).HasColumnName("product_id");
            this.Property(t => t.price_id).HasColumnName("price_id");
            this.Property(t => t.quantity).HasColumnName("quantity");
        }
    }
}
