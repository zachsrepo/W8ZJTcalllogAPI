using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using W8ZJTcalllog.Models;

namespace W8ZJTcalllog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpotsController : ControllerBase
    {
        private readonly FccAmateurContext _context;

        public SpotsController(FccAmateurContext context)
        {
            _context = context;
        }

        // GET: api/Spots/list/50
        [HttpGet("list/{quantity}")]
        public async Task<ActionResult<IEnumerable<Spot>>> GetSpots(int quantity)
        {
          if (_context.Spots == null)
          {
              return NotFound();
          }
            return await _context.Spots.OrderByDescending(n => n.nr)
                                       .Take(quantity)
                                       .ToListAsync();
        }
        //// GET: api/Spots/list/50 filter by
        //[HttpGet("list/{quantity}")]
        //public async Task<ActionResult<IEnumerable<Spot>>> GetSpots(int quantity)
        //{
        //    if (_context.Spots == null)
        //    {
        //        return NotFound();
        //    }
        //    return await _context.Spots.OrderByDescending(n => n.nr)
        //                               .Take(quantity)
        //                               .ToListAsync();
        //}

        // GET: api/Spots/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Spot>> GetSpot(int id)
        {
          if (_context.Spots == null)
          {
              return NotFound();
          }
            var spot = await _context.Spots.FindAsync(id);

            if (spot == null)
            {
                return NotFound();
            }

            return spot;
        }



        private bool SpotExists(int id)
        {
            return (_context.Spots?.Any(e => e.nr == id)).GetValueOrDefault();
        }
    }
}
