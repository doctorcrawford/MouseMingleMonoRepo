using MouseMingleApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;


namespace MouseMingleApi.Controllers;

[ApiController]
[Route("api/v{version:ApiVersion}/[controller]")]
[ApiVersion("1.0")]
[ApiVersion("1.1")]
public class InterestsController : Controller
{
  private readonly MouseMingleApiContext _db;

  public InterestsController(MouseMingleApiContext db)
  {
    _db = db;
  }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<Interest>>> Get()
  {
    return await _db.Interests
                    .Include(interest => interest.RodentInterests)
                    .ToListAsync();
  }

  [HttpGet("{id}")]
  public async Task<ActionResult<Interest>> GetInterest(int id)
  {
    Interest thisInterest = await _db.Interests
                                        .Include(r => r.RodentInterests)
                                        .FirstOrDefaultAsync(r =>r.InterestId == id);
    if (thisInterest == null)
    {
      return NotFound();
    }
    return thisInterest;
  }

  [HttpPost]
  public async Task<ActionResult<Interest>> Post(Interest interest)
  {
    _db.Interests.Add(interest);
    await _db.SaveChangesAsync();
    return CreatedAtAction("GetInterest", new { id = interest.InterestId }, interest);
  }

  [HttpDelete("{id}")]
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
  public async Task<IActionResult> Put(int id, Interest interest)
  {
    if (id != interest.InterestId)
    {
      return BadRequest();
    }
    _db.Interests.Update(interest);

    try
    {
      await _db.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
      if (!InterestExists(id))
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

  private bool InterestExists(int id)
  {
    return _db.Interests.Any(e => e.InterestId == id);
  }
}