using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Application.Models;
using Domain.Entities.Catalogs;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities.Apartments
{
    [PrimaryKey(nameof(GuestId), nameof(ApartmentId))]
    public class ApartmentGuest : BaseEntity
    {
        public int GuestId { get; set; }

        public int ApartmentId { get; set; }
        public int GuestTypeId { get; set; }

        [ForeignKey(nameof(GuestTypeId))]
        public GuestType Guest { get; set; }

        [ForeignKey(nameof(ApartmentId))]
        public virtual Apartment Apartment { get; set; }
    }
}
