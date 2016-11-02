using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace console.Models.Mapping
{
    public class tbl_UserMap : EntityTypeConfiguration<tbl_User>
    {
        public tbl_UserMap()
        {
            // Primary Key
            this.HasKey(t => t.user_id);

            // Properties
            this.Property(t => t.user_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.user_name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.user_surname)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.email_address)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.password)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("tbl.User");
            this.Property(t => t.user_id).HasColumnName("user_id");
            this.Property(t => t.user_name).HasColumnName("user_name");
            this.Property(t => t.user_surname).HasColumnName("user_surname");
            this.Property(t => t.email_address).HasColumnName("email_address");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.delivery_id).HasColumnName("delivery_id");
            this.Property(t => t.billing_id).HasColumnName("billing_id");
            this.Property(t => t.contact_id).HasColumnName("contact_id");

            // Relationships
            this.HasRequired(t => t.tbl_BillingAddress)
                .WithMany(t => t.tbl_User)
                .HasForeignKey(d => d.billing_id);
            this.HasRequired(t => t.tbl_CustomerContact)
                .WithMany(t => t.tbl_User)
                .HasForeignKey(d => d.contact_id);
            this.HasRequired(t => t.tbl_DelivetyAddresses)
                .WithMany(t => t.tbl_User)
                .HasForeignKey(d => d.delivery_id);

        }
    }
}
