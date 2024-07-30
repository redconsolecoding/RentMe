using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Application.Models;
using Domain.Entities.Administration;

namespace Domain.Entities.Apartments
{
    public class ApartmentFeature : BaseEntity
    {
        [Key]
        public int ApartmentId { get; set; }

        [Key]
        public int FeatureId { get; set; }

        [ForeignKey(nameof(FeatureId))]
        public Feature Feature { get; set; }

        [ForeignKey(nameof(ApartmentId))]
        public Apartment Apartment { get; set; }
    }
}
