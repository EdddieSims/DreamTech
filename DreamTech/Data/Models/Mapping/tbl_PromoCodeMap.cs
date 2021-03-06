using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace console.Models.Mapping
{
    public class tbl_PromoCodeMap : EntityTypeConfiguration<tbl_PromoCode>
    {
        public tbl_PromoCodeMap()
        {
            // Primary Key
            this.HasKey(t => t.promo_id);

            // Properties
            this.Property(t => t.promo_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("tblPromoCode");
            this.Property(t => t.promo_id).HasColumnName("promo_id");
            this.Property(t => t.promo_type_id).HasColumnName("promo_type_id");
            this.Property(t => t.num_of_uses).HasColumnName("num_of_uses");
        }
    }
}
