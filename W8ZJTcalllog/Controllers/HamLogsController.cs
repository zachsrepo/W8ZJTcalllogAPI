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
    public class HamLogsController : ControllerBase
    {
        private readonly FccAmateurContext _context;

        public HamLogsController(FccAmateurContext context)
        {
            _context = context;
        }

        // GET: api/HamLogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HamLog>>> GetHamLogs()
        {
          if (_context.HamLogs == null)
          {
              return NotFound();
          }
            return await _context.HamLogs.ToListAsync();
        }
        // GET: api/HamLogs/callsign/userid
        [HttpGet("{callsign}/{userId}")]
        public async Task<ActionResult<IEnumerable<HamLog>>> GetHamLogs(string callsign, int userId)
        {
            if (_context.HamLogs == null)
            {
                return NotFound();
            }
            return await _context.HamLogs.Where(n => n.UserId == userId && n.Callsign == callsign).ToListAsync();
        }

        // GET: api/HamLogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HamLog>> GetHamLog(int id)
        {
          if (_context.HamLogs == null)
          {
              return NotFound();
          }
            var hamLog = await _context.HamLogs.FindAsync(id);

            if (hamLog == null)
            {
                return NotFound();
            }

            return hamLog;
        }

        // PUT: api/HamLogs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHamLog(int id, HamLog hamLog)
        {
            if (id != hamLog.Id)
            {
                return BadRequest();
            }

            _context.Entry(hamLog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HamLogExists(id))
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

        // POST: api/HamLogs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HamLog>> PostHamLog(HamLog hamLog)
        {
          if (_context.HamLogs == null)
          {
              return Problem("Entity set 'FccAmateurContext.HamLogs'  is null.");
          }
            _context.HamLogs.Add(hamLog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHamLog", new { id = hamLog.Id }, hamLog);
        }

        // DELETE: api/HamLogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHamLog(int id)
        {
            if (_context.HamLogs == null)
            {
                return NotFound();
            }
            var hamLog = await _context.HamLogs.FindAsync(id);
            if (hamLog == null)
            {
                return NotFound();
            }

            _context.HamLogs.Remove(hamLog);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HamLogExists(int id)
        {
            return (_context.HamLogs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
