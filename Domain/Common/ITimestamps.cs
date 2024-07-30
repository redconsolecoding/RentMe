namespace Domain;

public interface ITimestamps
{
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
}
