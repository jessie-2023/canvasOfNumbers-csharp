
namespace myAppC.Models.Transfer;

public class GgiRaw
{
    public required string Country { get; set; }

    public required string Region { get; set; } = null!;
    
    public required int Year { get; set; }

    public required decimal general { get; set; }

    public required decimal health { get; set; }

    public required decimal education { get; set; }

    public required decimal economical { get; set; }

    public required decimal political { get; set; }

    public required decimal pcgdp { get; set; }

    public required decimal population { get; set; }

}
