using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Application.Models;
using Domain.Entities.Administration;
using Domain.Entities.Apartments;
using Domain.Entities.Catalogs;

namespace Domain.Entities.Hotels
{
    public class Hotel : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PhotoId { get; set; }
        public int RoomTypeId { get; set; }

        [StringLength(200)]
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [StringLength(200)]
        [Required]
        public string Location { get; set; }

        [ForeignKey(nameof(RoomTypeId))]
        public virtual RoomType RoomType { get; set; }

        [ForeignKey(nameof(PhotoId))]
        public Photo MainPhoto { get; set; }

        [InverseProperty(nameof(HotelPhoto.Hotel))]
        public ICollection<HotelPhoto> HotelPhotos { get; set; }

        [InverseProperty(nameof(HotelPrice.Hotel))]
        public ICollection<HotelPrice> HotelPrices { get; set; }

        [InverseProperty(nameof(HotelFeature.Hotel))]
        public ICollection<HotelFeature> HotelFeatures { get; set; }

        [InverseProperty(nameof(HotelReview.Hotel))]
        public ICollection<HotelReview> HotelReviews { get; set; }

        [InverseProperty(nameof(HotelRoom.Hotel))]
        public ICollection<HotelRoom> HotelRooms { get; set; }

        [InverseProperty(nameof(HotelGuest.Hotel))]
        public ICollection<HotelGuest> HotelGuests { get; set; }
    }
}
