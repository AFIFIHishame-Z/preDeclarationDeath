using System.ComponentModel;

namespace PreClaim.Domain;

public class BaseEntity
{

    public Guid id { get; set; } = Guid.NewGuid();



    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; } = false;
}
