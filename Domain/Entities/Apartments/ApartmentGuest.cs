using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Application.Models;
using Domain.Enums;

namespace Domain.Entities.Apartments
{
    public class ApartmentGuest : BaseEntity
    {
        [Key]
        public int GuestId { get; set; }

        [Key]
        public int ApartmentId { get; set; }
        public EGuest Guest { get; set; }

        [ForeignKey(nameof(ApartmentId))]
        public Apartment Apartment { get; set; }
    }
}
