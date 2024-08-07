using System.Reflection;
using Domain.Entities.Administration;
using Domain.Entities.Apartments;
using Domain.Entities.Catalogs;
using Domain.Entities.Hotels;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options) { }

        #region Administration
        public DbSet<Feature> Features { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Service> Services { get; set; }

        #endregion

        #region Apartment
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<ApartmentFeature> ApartmentFeatures { get; set; }
        public DbSet<ApartmentGuest> ApartmentGuests { get; set; }
        public DbSet<ApartmentPhoto> ApartmentPhotos { get; set; }
        public DbSet<ApartmentPrice> ApartmentPrices { get; set; }
        public DbSet<ApartmentReview> ApartmentReviews { get; set; }
        #endregion

        #region Catalog
        public DbSet<RoomType> RoomTypes { get; set; }

        #endregion

        #region Hotel
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelFeature> HotelFeatures { get; set; }
        public DbSet<HotelGuest> HotelGuests { get; set; }
        public DbSet<HotelPhoto> HotelPhotos { get; set; }
        public DbSet<HotelPrice> HotelPrices { get; set; }
        public DbSet<HotelReview> HotelReviews { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
