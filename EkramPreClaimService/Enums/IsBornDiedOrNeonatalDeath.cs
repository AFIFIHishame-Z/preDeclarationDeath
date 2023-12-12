using System.ComponentModel;

namespace PreClaim.Domain;

[Flags]
public enum IsBornDiedOrNeonatalDeath : byte
{
    [Description("Oui")]
    Yes = 1,
    [Description("Non")]
    No = 2
}
