namespace Domain;

public interface IAuthor
{
    public Guid CreatedBy { get; set; }

    public Guid? ModifiedBy { get; set; }
}
