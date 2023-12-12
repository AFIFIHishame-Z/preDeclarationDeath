using System.ComponentModel;

namespace PreClaim.Domain;

[Flags]
public enum BornDiedOrNeonatalDeath : byte
{
    [Description("Né décédé")]
    BornDied = 1,
    [Description("Né vivant puis est décédé")]
    NeonatalDeath = 2
}
