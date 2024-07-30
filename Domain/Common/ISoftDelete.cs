namespace Domain;

public interface ISoftDelete
{
    public DateTime? DeletedAt { get; set; }
    public bool IsActive { get; set; }
}
