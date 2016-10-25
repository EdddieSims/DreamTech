using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace console.Models.Mapping
{
    public class tbl_PromoTypeMap : EntityTypeConfiguration<tbl_PromoType>
    {
        public tbl_PromoTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.promo_type_id);

            // Properties
            this.Property(t => t.promo_type_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.promo_condition)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tbl.PromoType");
            this.Property(t => t.promo_type_id).HasColumnName("promo_type_id");
            this.Property(t => t.promo_condition).HasColumnName("promo_condition");
        }
    }
}
