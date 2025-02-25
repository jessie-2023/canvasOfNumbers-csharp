using System.Globalization;
using CsvHelper;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using myAppC.Models.Data;
using myAppC.Models.Transfer;

namespace myAppC;
public class GenderContext: DbContext
{
    public DbSet<Country> Countries { get; set; } = default!;
    public DbSet<Region> Regions { get; set; } = default!;
    public DbSet<Gap> Gaps { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Database=gender; Username=gender; Password=gender;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        using var ggiStreamReader = new StreamReader("GlobalGenderGapIndex.csv");
        using var ggiCsvReader = new CsvReader(ggiStreamReader, CultureInfo.InvariantCulture);
        var ggiRaw = ggiCsvReader.GetRecords<GgiRaw>().ToList();

        // Table for region name
        var regionNames = new List<Region>();
        var distinctRegions = ggiRaw.DistinctBy(ggi => ggi.Region).ToList();        
        for (var i = 0; i < distinctRegions.Count; i++)
        {
            var region = new Region
            {
                Id = i + 1,
                Name = distinctRegions[i].Region,
            };
            regionNames.Add(region);           
        }
        modelBuilder.Entity<Region>().HasData(regionNames.ToArray()); // HasData accepts an array of objects. Converting the list to an array ensures compatibility and avoids potential runtime issues.

        // Table for country code (complete list later)
        var countryNames = new List<Country>();
        var distinctCountries = ggiRaw.DistinctBy(ggi => ggi.Country).ToList();
        for (var i = 0; i < distinctCountries.Count; i++)
        {
            var country = new Country
            {
                Id = distinctCountries[i].CountryId,
                Name = distinctCountries[i].Country, 
            };
            countryNames.Add(country);           
        }
        modelBuilder.Entity<Country>().HasData(countryNames.ToArray());

        // Main table
        var gaps = new List<Gap>();
        for (var i = 0; i < ggiRaw.Count; i++)
        {
            var gap = new Gap
            {
                Id = i + 1,
                CountryId = ggiRaw[i].CountryId,
                CountryName = ggiRaw[i].Country,
                RegionId = regionNames.Where(r => r.Name == ggiRaw[i].Region).Select(r => r.Id).FirstOrDefault(),
                RegionName = ggiRaw[i].Region,
                Year = ggiRaw[i].Year,
                GeneralGap = ggiRaw[i].general,
                HealthGap = ggiRaw[i].health,
                EducationGap = ggiRaw[i].education,
                EconomicalGap = ggiRaw[i].economical,
                PoliticalGap = ggiRaw[i].political,
                GdpPerCapita = ggiRaw[i].pcgdp,
                Population = ggiRaw[i].population,
            };
            gaps.Add(gap);
        }
        modelBuilder.Entity<Gap>().HasData(gaps.ToArray());
    }
}
