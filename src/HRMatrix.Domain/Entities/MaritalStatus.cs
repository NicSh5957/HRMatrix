namespace HRMatrix.Domain.Entities;

public class MaritalStatus
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<UserProfile> UserProfiles { get; set; }
}