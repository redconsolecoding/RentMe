using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Application.Models;
using Domain.Entities.Administration;

namespace Domain.Entities.Apartments
{
    public class ApartmentReview : BaseEntity
    {
        [Key]
        public int ReviewId { get; set; }

        [Key]
        public int ApartmentId { get; set; }

        [ForeignKey(nameof(ApartmentId))]
        public Apartment Apartment { get; set; }

        [ForeignKey(nameof(ReviewId))]
        public Review Review { get; set; }
    }
}
