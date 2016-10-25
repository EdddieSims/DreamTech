using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace console.Models.Mapping
{
    public class tblCountryMap : EntityTypeConfiguration<tblCountry>
    {
        public tblCountryMap()
        {
            // Primary Key
            this.HasKey(t => t.country_id);

            // Properties
            this.Property(t => t.country_name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblCountry");
            this.Property(t => t.country_id).HasColumnName("country_id");
            this.Property(t => t.country_name).HasColumnName("country_name");
        }
    }
}
