using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using myAppC.Models.Data;
using myAppC.Models.Request;

namespace myAppC.Controllers;

[ApiController]
[Route("/gender-gap")]
public class GapController(GenderContext context): Controller
{
    private readonly GenderContext _context = context;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Gap>>> GetAll()
    {
        return await _context.Gaps.ToListAsync();
    }

    [HttpGet("country/{id}")]
    public IActionResult GetByCountryId(int id)
    {
        var gaps = _context.Gaps
                    .Where(item => item.CountryId == id)
                    .ToList();

        if (gaps.Count == 0)
        {
            return NotFound();
        }

        return Ok(gaps);
    }

    [HttpGet("general/{year}")]
    public IActionResult GetGeneral(int year)
    {
        var generals = _context.Gaps
                    .Where(item => item.Year == year)
                    .Select(item => new GapGeneral{
                        CountryId = item.CountryId,
                        CountryName = item.CountryName,
                        RegionName = item.RegionName,
                        GeneralGap = item.GeneralGap ,
                        GdpPerCapita = item.GdpPerCapita,
                        Population = item.Population, 
                    })
                    .OrderByDescending(item => item.GeneralGap)
                    .ToList();

        if (generals.Count == 0)
        {
            return NotFound();
        }

        return Ok(generals);
    }
}