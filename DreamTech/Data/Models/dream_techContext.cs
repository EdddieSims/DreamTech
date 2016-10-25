using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using console.Models.Mapping;

namespace console.Models
{
    public partial class dream_techContext : DbContext
    {
        static dream_techContext()
        {
            Database.SetInitializer<dream_techContext>(null);
        }

        public dream_techContext()
            : base("Name=dream_techContext")
        {
        }

        public DbSet<btl_ProductPrice> btl_ProductPrice { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<tbl_BillingAddress> tbl_BillingAddress { get; set; }
        public DbSet<tbl_Cart> tbl_Cart { get; set; }
        public DbSet<tbl_CartItem> tbl_CartItem { get; set; }
        public DbSet<tbl_CustomerContact> tbl_CustomerContact { get; set; }
        public DbSet<tbl_DeliveryOptions> tbl_DeliveryOptions { get; set; }
        public DbSet<tbl_DelivetyAddresses> tbl_DelivetyAddresses { get; set; }
        public DbSet<tbl_OptIn> tbl_OptIn { get; set; }
        public DbSet<tbl_OptInType> tbl_OptInType { get; set; }
        public DbSet<tbl_Order> tbl_Order { get; set; }
        public DbSet<tbl_OrderItems> tbl_OrderItems { get; set; }
        public DbSet<tbl_OrderStatus> tbl_OrderStatus { get; set; }
        public DbSet<tbl_ProductType> tbl_ProductType { get; set; }
        public DbSet<tbl_PromoCode> tbl_PromoCode { get; set; }
        public DbSet<tbl_PromoType> tbl_PromoType { get; set; }
        public DbSet<tbl_User> tbl_User { get; set; }
        public DbSet<tbl_Wishlist> tbl_Wishlist { get; set; }
        public DbSet<tbl_WishlistItem> tbl_WishlistItem { get; set; }
        public DbSet<tblCountry> tblCountries { get; set; }
        public DbSet<tblFeaturedProduct> tblFeaturedProducts { get; set; }
        public DbSet<tblProduct> tblProducts { get; set; }
        public DbSet<tblProductCategory> tblProductCategories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new btl_ProductPriceMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new tbl_BillingAddressMap());
            modelBuilder.Configurations.Add(new tbl_CartMap());
            modelBuilder.Configurations.Add(new tbl_CartItemMap());
            modelBuilder.Configurations.Add(new tbl_CustomerContactMap());
            modelBuilder.Configurations.Add(new tbl_DeliveryOptionsMap());
            modelBuilder.Configurations.Add(new tbl_DelivetyAddressesMap());
            modelBuilder.Configurations.Add(new tbl_OptInMap());
            modelBuilder.Configurations.Add(new tbl_OptInTypeMap());
            modelBuilder.Configurations.Add(new tbl_OrderMap());
            modelBuilder.Configurations.Add(new tbl_OrderItemsMap());
            modelBuilder.Configurations.Add(new tbl_OrderStatusMap());
            modelBuilder.Configurations.Add(new tbl_ProductTypeMap());
            modelBuilder.Configurations.Add(new tbl_PromoCodeMap());
            modelBuilder.Configurations.Add(new tbl_PromoTypeMap());
            modelBuilder.Configurations.Add(new tbl_UserMap());
            modelBuilder.Configurations.Add(new tbl_WishlistMap());
            modelBuilder.Configurations.Add(new tbl_WishlistItemMap());
            modelBuilder.Configurations.Add(new tblCountryMap());
            modelBuilder.Configurations.Add(new tblFeaturedProductMap());
            modelBuilder.Configurations.Add(new tblProductMap());
            modelBuilder.Configurations.Add(new tblProductCategoryMap());
        }
    }
}
