using PreClaim.Domain;
using System.ComponentModel.DataAnnotations;

namespace EkramPreClaimService.Models
{
    public class PreClaimModel : BaseEntity
    {

        // Death Information
        [Required]
        [DataType(DataType.Date)]
        public DateTime DeathDate { get; set; }

        [DataType(DataType.Time)]
        public DateTime DeathHour { get; set; }

        public string? DeathAddress { get; set; }

        public string? ProvinceOrPrefectureDeathFr { get; set; }
        public string? ProvinceOrPrefectureDeathAr { get; set; }
        public int? ProvinceOrPrefectureDeathId { get; set; }

        public string? CommuneOrDistrictDeathFr { get; set; }
        public string? CommuneOrDistrictDeathAr { get; set; }
        public int? CommuneOrDistrictDeathId { get; set; }

        public IsBornDiedOrNeonatalDeath? IsBornDiedOrNeonatalDeathId { get; set; }

        // Mother and Neonatal Information
        public string? MotherNameFr { get; set; }
        public string? MotherNameAr { get; set; }

        public string? NeonatalDeathNameFr { get; set; }
        public string? NeonatalDeathNameAr { get; set; }

        public string? IsItBornDiedOrNeonatalDeathFr { get; set; }
        public string? IsItBornDiedOrNeonatalDeathAr { get; set; }
        public BornDiedOrNeonatalDeath? IsItBornDiedOrNeonatalDeathId { get; set; }

        public int? NumberOfDaysLived { get; set; }

        // Location Information
        public string? ProvinceOrPrefectureFr { get; set; }
        public string? ProvinceOrPrefectureAr { get; set; }
        public int? ProvinceOrPrefectureId { get; set; }

        public string? CommuneOrDistrictFr { get; set; }
        public string? CommuneOrDistrictAr { get; set; }
        public int? CommuneOrDistrictId { get; set; }

        // Personal Information of the died person
        public string? LastNameFr { get; set; }
        public string? LastNameAr { get; set; }

        public string? FirstNameFr { get; set; }
        public string? FirstNameAr { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        public string? GenderFr { get; set; }
        public string? GenderAr { get; set; }
        public Gender? GenderId { get; set; }

        public string? UsualAddress { get; set; }

        public string? NationalityFr { get; set; }
        public string? NationalityAr { get; set; }
        public int? NationalityId { get; set; }

        // Identity Information
        public string? IdentityTypeFr { get; set; }
        public string? IdentityTypeAr { get; set; }
        public IdentityType? IdentityTypeId { get; set; }

        public string? IdentityNumber { get; set; }
        public string? IdentityDocumentPath { get; set; }
        // Country and Consulat Information
        public string? CountryFr { get; set; }
        public string? CountryAr { get; set; }
        public int? CountryId { get; set; }

        public string? ConsulatFr { get; set; }
        public string? ConsulatAr { get; set; }
        public int? ConsulatId { get; set; }

        public AddressInMoroccoOrAboard? AddressInMoroccoOrAboardId { get; set; }

        // Declarant Information -- Should recuperated from the Identity Service -- TODO
        public Guid DeclarantId { get; set; }

        public string? DeclarantFirstName { get; set; }
        public string? DeclarantLastName { get; set; }

        public string? DeclarantPhone { get; set; }

        public string? DeclarantIdentifierTypeId { get; set; }
        public string? DeclarantIdentifierNumber { get; set; }

        public string? Status { get; set; } = ClaimStatus.Draft.ToString();
        public int? StatusId { get; set; } = (int)ClaimStatus.Draft;


    }
}
