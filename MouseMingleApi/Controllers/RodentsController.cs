using MouseMingleApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;


namespace MouseMingleApi.Controllers;

[ApiController]
[Route("api/v{version:ApiVersion}/[controller]")]
[ApiVersion("1.0")]
[ApiVersion("1.1")]
public class RodentsController : Controller
{
  private readonly MouseMingleApiContext _db;

  public RodentsController(MouseMingleApiContext db)
  {
    _db = db;
  }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<Rodent>>> GetRodents()
  {
    return await _db.Rodents
                    .Include(rodent => rodent.RodentInterests)
                    .ToListAsync();
  }

  [HttpGet("{id}")]
  public async Task<ActionResult<Rodent>> GetRodent(int id)
  {
    Rodent thisRodent = await _db.Rodents
                                        .Include(r => r.RodentInterests)
                                        .FirstOrDefaultAsync(r =>r.RodentId == id);
    if (thisRodent == null)
    {
      return NotFound();
    }
    return thisRodent;
  }
}