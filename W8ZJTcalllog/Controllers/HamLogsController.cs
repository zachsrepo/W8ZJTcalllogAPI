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
        // GET: api/list/userid/quantity
        [HttpGet("list/{userId}/{quantity}")]
        public async Task<ActionResult<IEnumerable<HamLog>>> GetHamLogslist(int userId, int quantity)
        {
            if (_context.HamLogs == null)
            {
                return NotFound();
            }
            var limitedList = await _context.HamLogs.Where(n => n.UserId == userId)
                                                    .OrderByDescending(n => n.Id)
                                                    .Take(quantity)
                                                    .ToListAsync();
            return limitedList;
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
            var id = hamLog.UserId;
            _context.HamLogs.Add(hamLog);
            await _context.SaveChangesAsync();
            await UpdateRecordCount(id);

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
            await UpdateRecordCount(hamLog.UserId);

            return NoContent();
        }

        private async Task<IActionResult> UpdateRecordCount(int userId)
        {
            var user = await _context.Users.FindAsync(userId);
            user.RecordCount =  _context.HamLogs.Where(n => n.UserId == userId).Count();
           
            await _context.SaveChangesAsync();
            return Ok();
        }

        private bool HamLogExists(int id)
        {
            return (_context.HamLogs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
