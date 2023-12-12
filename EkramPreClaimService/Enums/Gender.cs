using System.ComponentModel;

namespace PreClaim.Domain;

[Flags]
public enum Gender : byte
{
    [Description("Homme")]
    Male = 1,
    [Description("Femme")]
    Female = 2
}
