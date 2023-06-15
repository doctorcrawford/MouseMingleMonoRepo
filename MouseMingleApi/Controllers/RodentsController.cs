using MouseMingleApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.Authorization;

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

  // [Authorize]
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

  // Get RodentInterests at Rodent
  [HttpGet("{id}/rodentinterests")]
  public async Task<ActionResult<IEnumerable<RodentInterest>>> GetRodentInterest(int id)
  {
    return await _db.RodentInterests
                    .Where(e => e.RodentId == id)
                    .ToListAsync();
  }

  [HttpPost]
  public async Task<ActionResult<Rodent>> Post(Rodent rodent)
  {
    _db.Rodents.Add(rodent);
    await _db.SaveChangesAsync();
    return CreatedAtAction("GetRodent", new { id = rodent.RodentId }, rodent);
  }
  
  // [HttpDelete("{id}")]
  // public async Task<IActionResult> DeleteInterest(int id)
  // {
  //   Rodent rodent = await _db.Rodents.FindAsync(id);
  //   if (rodent == null)
  //   {
  //     return NotFound();
  //   }
  //   _db.Rodents.Remove(rodent);
  //   await _db.SaveChangesAsync();

  //   return NoContent();
  // }

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

  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteRodent(int id)
  {
    Rodent rodent = await _db.Rodents.FindAsync(id);
    if (rodent == null)
    {
      return NotFound();
    }

    _db.Rodents.Remove(rodent);
    await _db.SaveChangesAsync();

    return NoContent();
  }

  private bool RodentExists(int id)
  {
    return _db.Rodents.Any(e => e.RodentId == id);
  }
}


