using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Application.Models;
using Domain.Entities.Administration;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities.Apartments
{
    [PrimaryKey(nameof(ApartmentId), nameof(FeatureId))]
    public class ApartmentFeature : BaseEntity
    {
        public int ApartmentId { get; set; }

        public int FeatureId { get; set; }

        [ForeignKey(nameof(FeatureId))]
        public Feature Feature { get; set; }

        [ForeignKey(nameof(ApartmentId))]
        public Apartment Apartment { get; set; }
    }
}
