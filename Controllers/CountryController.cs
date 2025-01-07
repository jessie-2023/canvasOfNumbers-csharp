using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using myAppC.Models.Data;

namespace myAppC.Controllers;

[ApiController]
[Route("/countries")]
public class CountryController(GenderContext context) : Controller
{
    private readonly GenderContext _context = context;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Country>>> GetAll()
    {
        return await _context.Countries.ToListAsync();
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var country = _context.Countries.SingleOrDefault(c => c.Id == id);

        if (country == null)
        {
            return NotFound();
        }

        return Ok(country);
    }


}