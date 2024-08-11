using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Application.Models;
using Domain.Entities.Administration;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities.Hotels
{
    [PrimaryKey(nameof(HotelId), nameof(ReviewId))]
    public class HotelReview : BaseEntity
    {
        public int ReviewId { get; set; }

        public int HotelId { get; set; }

        [ForeignKey(nameof(HotelId))]
        public Hotel Hotel { get; set; }

        [ForeignKey(nameof(ReviewId))]
        public Review Review { get; set; }
    }
}
