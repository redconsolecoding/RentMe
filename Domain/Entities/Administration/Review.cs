using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Application.Models;
using Domain.Entities.Apartments;

namespace Domain.Entities.Administration
{
    public class Review : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(200)]
        public string Title { get; set; }
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(3,1)")]
        public decimal Rating { get; set; }

        [StringLength(200)]
        [Required]
        public string Author { get; set; }
    }
}
