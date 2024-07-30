using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Application.Models;

namespace Domain.Entities.Hotels
{
    public class HotelPrice : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Value { get; set; }

        public int HotelId { get; set; }

        [ForeignKey(nameof(HotelGuest.Hotel))]
        public ICollection<HotelGuest> HotelGuests { get; set; }

        [ForeignKey(nameof(HotelId))]
        public Hotel Hotel { get; set; }
    }
}
