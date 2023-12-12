using Microsoft.AspNetCore.Http;

namespace PreClaim.Domain;

public class AttachementDto
{
    public Guid ClaimId { get; set; }
    public string Path { get; set; }
    public byte[] Document { get; set; }
    public string ContentType { get; set; }
    public bool? IsMotherCard { get; set; }
    public bool? IsDiedPersonCard { get; set; }
}
