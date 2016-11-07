using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace console.Models.Mapping
{
    public class tbl_OptInMap : EntityTypeConfiguration<tbl_OptIn>
    {
        public tbl_OptInMap()
        {
            // Primary Key
            this.HasKey(t => t.opt_id);

            // Properties
            this.Property(t => t.opt_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("tblOptIn");
            this.Property(t => t.opt_id).HasColumnName("opt_id");
            this.Property(t => t.user_id).HasColumnName("user_id");
            this.Property(t => t.opt_type_id).HasColumnName("opt_type_id");
        }
    }
}
