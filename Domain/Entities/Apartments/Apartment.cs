using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Application.Models;
using Domain.Entities.Administration;
using Domain.Entities.Catalogs;

namespace Domain.Entities.Apartments
{
    public class Apartment : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(200)]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [StringLength(200)]
        [Required]
        public string Location { get; set; }

        public int RoomTypeId { get; set; }

        public int PhotoId { get; set; }

        public int ApartmentPriceId { get; set; }

        public int FeatureId { get; set; }

        [ForeignKey(nameof(RoomTypeId))]
        public virtual RoomType RoomType { get; set; }

        [ForeignKey(nameof(PhotoId))]
        public Photo MainPhoto { get; set; }

        [InverseProperty(nameof(ApartmentPrice.Apartment))]
        public ICollection<ApartmentPrice> ApartmentPrices { get; set; }

        [InverseProperty(nameof(ApartmentPhoto.Apartment))]
        public ICollection<ApartmentPhoto> ApartmentPhotos { get; set; }

        [InverseProperty(nameof(ApartmentReview.Apartment))]
        public ICollection<ApartmentReview> ApartmentReviews { get; set; }

        [InverseProperty(nameof(ApartmentFeature.Apartment))]
        public ICollection<ApartmentFeature> ApartmentFeatures { get; set; }
    }
}
