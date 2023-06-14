using MouseMingleApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;


namespace MouseMingleApi.Controllers;

[ApiController]
[Route("api/v{version:ApiVersion}/[controller]")]
[ApiVersion("1.0")]
[ApiVersion("1.1")]
public class RodentInterestsController : Controller
{
  private readonly MouseMingleApiContext _db;

  public RodentInterestsController(MouseMingleApiContext db)
  {
    _db = db;
  }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<RodentInterest>>> Get()
  {
    return await _db.RodentInterests
                    .ToListAsync();
  }

  [HttpGet("{id}")]
  public async Task<ActionResult<RodentInterest>> GetRodentInterest(int id)
  {
    RodentInterest entry = await _db.RodentInterests
                                  .FirstOrDefaultAsync(r =>r.RodentInterestId == id);
    if (entry == null)
    {
      return NotFound();
    }
    return entry;
  }

  // [HttpGet("{id}")]
  // public async Task<ActionResult<IEnumerable<RodentInterest>>> GetRodentInterest(int id)
  // {
  //   return await _db.RodentInterests
  //                   .Where(rI => rI.RodentId == id)
  //                   .Include(rodent => rodent.Interest)
  //                   .ToListAsync();
  // }
  

  [HttpPost]
  public async Task<ActionResult<RodentInterest>> Post(RodentInterest rodentInterest)
  {
    _db.RodentInterests.Add(rodentInterest);
    await _db.SaveChangesAsync();
    return CreatedAtAction("Get", new { id = rodentInterest.RodentInterestId }, rodentInterest);
  }
  
  [HttpDelete("{id}")]
  public async Task<IActionResult> Delete(int id)
  {
    RodentInterest entry = await _db.RodentInterests.FindAsync(id);
    if (entry == null)
    {
      return NotFound();
    }
    _db.RodentInterests.Remove(entry);
    await _db.SaveChangesAsync();

    return NoContent();
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> Put(int id, RodentInterest rodentInterest)
  {
    if (id != rodentInterest.RodentInterestId)
    {
      return BadRequest();
    }
    _db.RodentInterests.Update(rodentInterest);

    try
    {
      await _db.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
      if (!RodentInterestExists(id))
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

  private bool RodentInterestExists(int id)
  {
    return _db.RodentInterests.Any(e => e.RodentInterestId == id);
  }
}