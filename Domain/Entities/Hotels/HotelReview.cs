using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Application.Models;
using Domain.Entities.Administration;

namespace Domain.Entities.Hotels
{
    public class HotelReview : BaseEntity
    {
        [Key]
        public int ReviewId { get; set; }

        [Key]
        public int HotelId { get; set; }

        [ForeignKey(nameof(HotelId))]
        public Hotel Hotel { get; set; }

        [ForeignKey(nameof(ReviewId))]
        public Review Review { get; set; }
    }
}
