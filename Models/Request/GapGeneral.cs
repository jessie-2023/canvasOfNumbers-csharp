using System.ComponentModel.DataAnnotations.Schema;

namespace myAppC.Models.Request;

public class GapGeneral
{
    public required int CountryId { get; set; } // Foreign Key

    [ForeignKey(nameof(CountryId))]     // Navigation Property
    public required string CountryName { get; set; }

    public required string RegionName { get; set; } 

    public required decimal GeneralGap { get; set; }

    public required decimal GdpPerCapita { get; set; }

    public required decimal Population { get; set; }

}
