using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Game.Models;


namespace Game.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DrawingController : ControllerBase
  {
    private readonly GameContext _db;

    public DrawingsController(GameContext db)
    {
      _db = db;
    }

    // GET api/drawings
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Drawing>>> Get(string date, string name)
    {
      var query = _db.Drawings.AsQueryable();

      if (date != null)
      {
        query = query.Where(entry => entry.Date == date);
      }
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      return await query.ToListAsync();
    }

    // POST api/drawings
    [HttpPost]
    public async Task<ActionResult<Drawing>> Post(Drawing drawing)
    {
      _db.Drawings.Add(drawing);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetDrawing), new { id = drawing.DrawingId }, drawing);
    }
    // GET: api/Drawings/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Drawing>> GetDrawing(int id)
    {
      var drawing = await _db.Drawings.FindAsync(id);

      if (drawings == null)
      {
        return NotFound();
      }

      return drawing;
    }
    // PUT: api/Drawings/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Drawing drawing)
    {
      if (id != drawing.DrawingId)
      {
        return BadRequest();
      }

      _db.Entry(drawing).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!DrawingExists(id))
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
    // DELETE: api/Drawings/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDrawing(int id)
    {
      var drawing = await _db.Drawings.FindAsync(id);
      if (drawing == null)
      {
        return NotFound();
      }

      _db.Drawings.Remove(drawing);
      await _db.SaveChangesAsync();

      return NoContent();
    }
    private bool DrawingExists(int id)
    {
      return _db.Drawings.Any(e => e.DrawingId == id);
    }
  }
}