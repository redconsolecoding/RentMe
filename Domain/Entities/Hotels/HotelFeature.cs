using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Application.Models;
using Domain.Entities.Administration;
using Domain.Entities.Apartments;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities.Hotels
{
    [PrimaryKey(nameof(HotelId), nameof(FeatureId))]
    public class HotelFeature : BaseEntity
    {
        public int HotelId { get; set; }

        public int FeatureId { get; set; }

        [ForeignKey(nameof(FeatureId))]
        public Feature Feature { get; set; }

        [ForeignKey(nameof(HotelId))]
        public Hotel Hotel { get; set; }
    }
}
