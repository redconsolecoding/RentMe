using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class BaseCatalog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [StringLength(200)]
        [Required]
        public string Name { get; set; }

        [StringLength(50)]
        public string Code { get; set; } = String.Empty;

        public string Description { get; set; } = String.Empty;
    }
}
