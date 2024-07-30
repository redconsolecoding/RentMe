using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Application.Models;
using Domain.Entities.Administration;

namespace Domain.Entities.Hotels
{
    public class HotelPhoto : BaseEntity
    {
        [Key]
        public int HotelId { get; set; }

        [Key]
        public int PhotoId { get; set; }

        [ForeignKey(nameof(PhotoId))]
        public Photo Photo { get; set; }

        [ForeignKey(nameof(HotelId))]
        public Hotel Hotel { get; set; }
    }
}
