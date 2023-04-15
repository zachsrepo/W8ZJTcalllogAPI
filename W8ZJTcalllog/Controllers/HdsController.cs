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
    public class HdsController : ControllerBase
    {
        private readonly FccAmateurContext _context;

        public HdsController(FccAmateurContext context)
        {
            _context = context;
        }
        // GET: api/Hds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hd>> GetHd(int id)
        {
          if (_context.Hds == null)
          {
              return NotFound();
          }
            var hd = await _context.Hds.FindAsync(id);

            if (hd == null)
            {
                return NotFound();
            }

            return hd;
        }
        private bool HdExists(int id)
        {
            return (_context.Hds?.Any(e => e.Fccid == id)).GetValueOrDefault();
        }
    }
}
