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
        [HttpGet("{userid}")]
        public async Task<ActionResult<IEnumerable<HamLog>>> GetHamLogs(int userid)
        {
            if (_context.HamLogs == null)
            {
                return NotFound();
            }
            return await _context.HamLogs.Where(n => n.UserId == userid).ToListAsync();
        }
        // GET: api/Ens/callsign/w8zjt/5
        [HttpGet("callsign/{userid}/{callsign}")]
        public async Task<ActionResult<IEnumerable<HamLog>>> GetEnByCallsign(string callsign, int userid)
        {
            if (_context.HamLogs == null)
            {
                return NotFound();
            }
            var callLogs = await _context.HamLogs.Where(n => n.UserId == userid).ToListAsync();

            if (callLogs == null)
            {
                return NotFound();
            }

            return callLogs;
        }

        // GET: api/HamLogs/5
        [HttpGet("{userid}/{id}")]
        public async Task<ActionResult<HamLog>> GetHamLog(int id, int userid)
        {
            if (_context.HamLogs == null)
            {
                return NotFound();
            }
            var hamLog = await _context.HamLogs.Where(n => n.UserId == userid).SingleOrDefaultAsync(n => n.Id == id);

            if (hamLog == null)
            {
                return NotFound();
            }

            return hamLog;
        }

        // PUT: api/HamLogs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{userid}/{id}")]
        public async Task<IActionResult> PutHamLog(int userid, int id, HamLog hamLog)
        {
            if (id != hamLog.Id && userid != hamLog.UserId)
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
        [HttpPost("{userid}")]
        public async Task<ActionResult<HamLog>> PostHamLog(HamLog hamLog, int userid)
        {
            if (hamLog.UserId != userid)
            {
                return BadRequest();
            }
            if (_context.HamLogs == null)
            {
                return Problem("Entity set 'FccAmateurContext.HamLogs'  is null.");
            }
            _context.HamLogs.Add(hamLog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHamLog", new { id = hamLog.Id }, hamLog);
        }

        // DELETE: api/HamLogs/5
        [HttpDelete("{userid}/{id}")]
        public async Task<IActionResult> DeleteHamLog(int id, int userid)
        {
            if (_context.HamLogs == null)
            {
                return NotFound();
            }
            var hamLog = await _context.HamLogs.FindAsync(id);
            if (hamLog == null || hamLog.UserId != userid)
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
