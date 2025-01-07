using System.ComponentModel.DataAnnotations.Schema;

namespace myAppC.Models.Data;

public class Gap 
{
    public int Id { get; set; }
 
    public required int CountryId { get; set; } // Foreign Key

    [ForeignKey(nameof(CountryId))]     // Navigation Property
    public required string CountryName { get; set; }

    public required int RegionId { get; set; }

    [ForeignKey(nameof(RegionId))]
    public required string RegionName { get; set; } 
    
    public required int Year { get; set; }

    public required decimal GeneralGap { get; set; }

    public required decimal HealthGap { get; set; }

    public required decimal EducationGap { get; set; }

    public required decimal EconomicalGap { get; set; }

    public required decimal PoliticalGap { get; set; }

    public required decimal GdpPerCapita { get; set; }

    public required decimal Population { get; set; }

}
