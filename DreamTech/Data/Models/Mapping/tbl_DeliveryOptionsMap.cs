using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace console.Models.Mapping
{
    public class tbl_DeliveryOptionsMap : EntityTypeConfiguration<tbl_DeliveryOptions>
    {
        public tbl_DeliveryOptionsMap()
        {
            // Primary Key
            this.HasKey(t => t.delivery_id);

            // Properties
            this.Property(t => t.delivery_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.delivery_option)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblDeliveryOptions");
            this.Property(t => t.delivery_id).HasColumnName("delivery_id");
            this.Property(t => t.delivery_option).HasColumnName("delivery_option");
        }
    }
}
