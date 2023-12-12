using System.ComponentModel;

namespace PreClaim.Domain;

[Flags]
public enum AddressInMoroccoOrAboard : byte
{
    [Description("Au Maroc")]
    InMorocco = 1,
    [Description("A l'étranger")]
    Aboard = 2
}
