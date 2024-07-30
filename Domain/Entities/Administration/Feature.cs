using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Application.Models;

namespace Domain.Entities.Administration
{
    public class Feature : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(200)]
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
