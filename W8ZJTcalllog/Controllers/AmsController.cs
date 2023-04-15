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
    public class AmsController : ControllerBase
    {
        private readonly FccAmateurContext _context;

        public AmsController(FccAmateurContext context)
        {
            _context = context;
        }
        // GET: api/Ams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Am>> GetAm(int id)
        {
          if (_context.Ams == null)
          {
              return NotFound();
          }
            var am = await _context.Ams.FindAsync(id);

            if (am == null)
            {
                return NotFound();
            }

            return am;
        }
        private bool AmExists(int id)
        {
            return (_context.Ams?.Any(e => e.Fccid == id)).GetValueOrDefault();
        }
    }
}
