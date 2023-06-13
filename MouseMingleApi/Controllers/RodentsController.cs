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

  [HttpPost]
  public async Task<ActionResult<Rodent>> Post(Rodent rodent)
  {
    _db.Rodents.Add(rodent);
    await _db.SaveChangesAsync();
    return CreatedAtAction("GetRodent", new { id = rodent.RodentId }, rodent);
  }
  
  [HttpDelete("{id")]
  public async Task<IActionResult> DeleteInterest(int id)
  {
    Interest interest = await _db.Interests.FindAsync(id);
    if (interest == null)
    {
      return NotFound();
    }
    _db.Interests.Remove(interest);
    await _db.SaveChangesAsync();

    return NoContent();
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> Put(int id, Rodent rodent)
  {
    if (id != rodent.RodentId)
    {
      return BadRequest();
    }
    _db.Rodents.Update(rodent);

    try
    {
      await _db.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
      if (!RodentExists(id))
      {
        return NotFound();
      }
      else
      {
        throw;
      }
    }
    return NoContent();
  }

  private bool RodentExists(int id)
  {
    return _db.Rodents.Any(e => e.RodentId == id);
  }
}