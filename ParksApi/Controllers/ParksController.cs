using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkApi.Models;

namespace ParkApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ParkApiContext _db;

    public ParksController(ParkApiContext db)
    {
      _db = db;
    }
    //GET: api/parks
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string Name, string Description, string Facilities, string Region, string Stats)
    {
      var query = _db.Parks.AsQueryable();

      if (Name != null)
      {
        query = query.Where(entry => entry.Name == Name);
      }
      if (Description != null)
      {
        query = query.Where(entry => entry.Description == Description);
      }
      if (Facilities != null)
      {
        query = query.Where(entry => entry.Facilities == Facilities);
      }
      if (Region != null)
      {
        query = query.Where(entry => entry.Region == Region);
      }
      if (Stats != null)
      {
        query = query.Where(entry => entry.Stats == Stats);
      }
      return await query.ToListAsync();
    }

    // GET: api/Parks/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      var park = await _db.Parks.FindAsync(id);

      if (park == null)
      {
        return NotFound();
      }

      return park;
    }

    // POST: api/parks
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }

  }
}