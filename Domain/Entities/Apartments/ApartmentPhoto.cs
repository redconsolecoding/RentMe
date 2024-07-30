using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Application.Models;
using Domain.Entities.Administration;

namespace Domain.Entities.Apartments
{
    public class ApartmentPhoto : BaseEntity
    {
        [Key]
        public int PhotoId { get; set; }

        [Key]
        public int ApartmentId { get; set; }

        [ForeignKey(nameof(PhotoId))]
        public Photo Photo { get; set; }

        [ForeignKey(nameof(ApartmentId))]
        public Apartment Apartment { get; set; }
    }
}
