using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace console.Models.Mapping
{
    public class tbl_DelivetyAddressesMap : EntityTypeConfiguration<tbl_DelivetyAddresses>
    {
        public tbl_DelivetyAddressesMap()
        {
            // Primary Key
            this.HasKey(t => t.delivery_id);

            // Properties
            this.Property(t => t.delivery_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.address_line)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.suburb)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.city)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("tbl.DelivetyAddresses");
            this.Property(t => t.delivery_id).HasColumnName("delivery_id");
            this.Property(t => t.address_line).HasColumnName("address_line");
            this.Property(t => t.suburb).HasColumnName("suburb");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.postal_code).HasColumnName("postal_code");
            this.Property(t => t.country_id).HasColumnName("country_id");

            // Relationships
            this.HasRequired(t => t.tblCountry)
                .WithMany(t => t.tbl_DelivetyAddresses)
                .HasForeignKey(d => d.country_id);

        }
    }
}
