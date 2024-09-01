using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Application.DTOs
{
    [Table("user_roles")]
    public class UserRoleDto : BaseModel
    {
        [Column("role")]
        public string Role { get; set; } = String.Empty;

        [Column("user_id")]
        public string UserId { get; set; } = String.Empty;
    }
}
