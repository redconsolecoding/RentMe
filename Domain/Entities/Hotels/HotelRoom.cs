using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Application.Models;
using Domain.Entities.Catalogs;

namespace Domain.Entities.Hotels
{
    public class HotelRoom : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int HotelId { get; set; }
        public int RoomTypeId { get; set; }
        public int RoomNumber { get; set; }

        [ForeignKey(nameof(RoomTypeId))]
        public RoomType RoomType { get; set; }

        [ForeignKey(nameof(HotelId))]
        public Hotel Hotel { get; set; }
    }
}
