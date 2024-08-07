using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Application.Models;
using Domain.Entities.Administration;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities.Hotels
{
    [PrimaryKey(nameof(HotelId), nameof(PhotoId))]
    public class HotelPhoto : BaseEntity
    {
        public int HotelId { get; set; }

        public int PhotoId { get; set; }

        [ForeignKey(nameof(PhotoId))]
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Photo Photo { get; set; }

        [ForeignKey(nameof(HotelId))]
        public Hotel Hotel { get; set; }
    }
}
