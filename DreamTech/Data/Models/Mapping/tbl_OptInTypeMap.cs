using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace console.Models.Mapping
{
    public class tbl_OptInTypeMap : EntityTypeConfiguration<tbl_OptInType>
    {
        public tbl_OptInTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.opt_type_id);

            // Properties
            this.Property(t => t.opt_type_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.optin_category)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblOptInType");
            this.Property(t => t.opt_type_id).HasColumnName("opt_type_id");
            this.Property(t => t.optin_category).HasColumnName("optin_category");
        }
    }
}
