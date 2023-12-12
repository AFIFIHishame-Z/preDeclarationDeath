using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PreClaim.Domain;

public class PreClaimDto
{
    // Death Information
    [Required]
    [DataType(DataType.Date)]
    [CurrentDateOrLater(ErrorMessage = "The DeathDate must be greater than or equal to the current date.")]
    public DateTime DeathDate { get; set; }
    [DataType(DataType.Time)]
    public DateTime DeathHour { get; set; }

    [Required(ErrorMessage = "The DeathAddress is required.")]
    public string? DeathAddress { get; set; }

    //public string? DeathPlace { get; set; }
    //public int DeathPlaceId { get; set; }

    public string? ProvinceOrPrefectureDeathFr { get; set; }

    public string? ProvinceOrPrefectureDeathAr { get; set; }

    public int? ProvinceOrPrefectureDeathId { get; set; }

    public string? CommuneOrDistrictDeathFr { get; set; }

    public string? CommuneOrDistrictDeathAr { get; set; }

    public int? CommuneOrDistrictDeathId { get; set; }
    [Required(ErrorMessage = "The IsBornDiedOrNeonatalDeathId is required.")]
    public IsBornDiedOrNeonatalDeath? IsBornDiedOrNeonatalDeathId { get; set; }

    // Mother and Neonatal Information
    [RequiredIf(nameof(IsBornDiedOrNeonatalDeathId),
               nameof(IsBornDiedOrNeonatalDeath.Yes), ErrorMessage = "The MotherNameFr is required")]
    public string? MotherNameFr { get; set; }
    public string? MotherNameAr { get; set; }

    public string? NeonatalDeathNameFr { get; set; }
    public string? NeonatalDeathNameAr { get; set; }

    public string? IsItBornDiedOrNeonatalDeathFr { get; set; }
    public string? IsItBornDiedOrNeonatalDeathAr { get; set; }
    [RequiredIf(nameof(IsBornDiedOrNeonatalDeathId),
        nameof(IsBornDiedOrNeonatalDeath.Yes), ErrorMessage = "The IsItBornDiedOrNeonatalDeathId is required")]
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
    [RequiredIf(nameof(IsBornDiedOrNeonatalDeathId),
        nameof(IsBornDiedOrNeonatalDeath.No), ErrorMessage = "The LastNameFr is required.")]
    public string? LastNameFr { get; set; }
    public string? LastNameAr { get; set; }
    [RequiredIf(nameof(IsBornDiedOrNeonatalDeathId),
        nameof(IsBornDiedOrNeonatalDeath.No), ErrorMessage = "The FirstNameFr is required.")]
    public string? FirstNameFr { get; set; }
    public string? FirstNameAr { get; set; }

    [DataType(DataType.Date)]
    [CurrentDateOrEarlierAttribute(ErrorMessage = "The DateOfBirth must be less than or equal to the current date.")]
    public DateTime? DateOfBirth { get; set; }

    public string? GenderFr { get; set; }
    public string? GenderAr { get; set; }
    [Required(ErrorMessage = "The GenderId is required.")]
    public Gender? GenderId { get; set; }

    public string? NationalityFr { get; set; }
    public string? NationalityAr { get; set; }
    public int? NationalityId { get; set; }

    public string? IdentityTypeFr { get; set; }
    public string? IdentityTypeAr { get; set; }
    public IdentityType? IdentityTypeId { get; set; }

    public string? IdentityNumber { get; set; }
    [DataType(DataType.Upload)]
    public IFormFile? IdentityDocument { get; set; }

    // Country and Consulat Information and usual address
    [DefaultValue(AddressInMoroccoOrAboard.InMorocco)]
    [Required]
    public AddressInMoroccoOrAboard? AddressInMoroccoOrAboardId { get; set; }

    [RequiredIf(nameof(AddressInMoroccoOrAboardId),
      nameof(AddressInMoroccoOrAboard.InMorocco), ErrorMessage = "The UsualAddress is required.")]
    public string? UsualAddress { get; set; }

    public string? CountryFr { get; set; }
    public string? CountryAr { get; set; }
    [RequiredIf(nameof(AddressInMoroccoOrAboardId),
       nameof(AddressInMoroccoOrAboard.Aboard), ErrorMessage = "The CountryId is required.")]
    public int? CountryId { get; set; }

    public string? ConsulatFr { get; set; }
    public string? ConsulatAr { get; set; }
    [RequiredIf(nameof(AddressInMoroccoOrAboardId),
       nameof(AddressInMoroccoOrAboard.Aboard), ErrorMessage = "The CountryId is required.")]
    public int? ConsulatId { get; set; }
    // public string? Status { get; set; }
    // public int? StatusId { get; set; }
}
