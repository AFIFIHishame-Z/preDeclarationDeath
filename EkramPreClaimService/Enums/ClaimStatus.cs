namespace PreClaim.Domain;

[Flags]

public enum ClaimStatus
{
    Draft = 0,
    Approved = 1,
    Rejected = 2,
    Assigned = 4,

}
