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
    public class EnsController : ControllerBase
    {
        private readonly FccAmateurContext _context;

        public EnsController(FccAmateurContext context)
        {
            _context = context;
        }

        // GET: api/Ens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<En>> GetEn(int id)
        {
          if (_context.Ens == null)
          {
              return NotFound();
          }
            var en = await _context.Ens.FindAsync(id);

            if (en == null)
            {
                return NotFound();
            }

            return en;
        }

        // GET: api/Ens/callsign
        [HttpGet("callsign/{callsign}")]
        public async Task<ActionResult<En>> GetEnByCallsign(string callsign)
        {
            if (_context.Ens == null)
            {
                return NotFound();
            }
            var en = await (from calls in _context.Ens
                            join active in _context.Hds
                            on calls.Fccid equals active.Fccid
                            where calls.Callsign == callsign && active.Status == "A"
                            select calls).SingleOrDefaultAsync();

            if (en == null)
            {
                return NotFound();
            }

            return en;
        }
        private bool EnExists(int id)
        {
            return (_context.Ens?.Any(e => e.Fccid == id)).GetValueOrDefault();
        }
    }
}
