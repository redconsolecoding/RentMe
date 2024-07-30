using System.Text.Json.Serialization;
using Domain;

namespace Application.Models
{
    public class BaseEntity : ISoftDelete, IAuthor, ITimestamps
    {
        [JsonIgnore]
        public DateTime? DeletedAt { get; set; }

        [JsonIgnore]
        public Guid CreatedBy { get; set; }

        [JsonIgnore]
        public Guid? ModifiedBy { get; set; }

        [JsonIgnore]
        public DateTime CreatedAt { get; set; }

        [JsonIgnore]
        public DateTime? LastModifiedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
