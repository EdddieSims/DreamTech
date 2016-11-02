using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace console.Models.Mapping
{
    public class tbl_CustomerContactMap : EntityTypeConfiguration<tbl_CustomerContact>
    {
        public tbl_CustomerContactMap()
        {
            // Primary Key
            this.HasKey(t => t.contact_id);

            // Properties
            this.Property(t => t.contact_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("tbl.CustomerContact");
            this.Property(t => t.contact_id).HasColumnName("contact_id");
            this.Property(t => t.cell_number).HasColumnName("cell_number");
            this.Property(t => t.landline).HasColumnName("landline");
        }
    }
}
