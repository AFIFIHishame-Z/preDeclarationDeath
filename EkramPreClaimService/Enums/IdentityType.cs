using System.ComponentModel;

namespace PreClaim.Domain;

[Flags]
public enum IdentityType : byte
{
    [Description("Carte Nationale d'Identité Electronique")]
    CNIE = 1,
    [Description("Passeport")]
    Passport = 2,
    [Description("Carte séjour")]
    StayCard = 3
}
