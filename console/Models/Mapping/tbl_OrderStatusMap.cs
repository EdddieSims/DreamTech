using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace console.Models.Mapping
{
    public class tbl_OrderStatusMap : EntityTypeConfiguration<tbl_OrderStatus>
    {
        public tbl_OrderStatusMap()
        {
            // Primary Key
            this.HasKey(t => t.status_id);

            // Properties
            this.Property(t => t.status_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.status)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tbl.OrderStatus");
            this.Property(t => t.status_id).HasColumnName("status_id");
            this.Property(t => t.status).HasColumnName("status");
        }
    }
}
