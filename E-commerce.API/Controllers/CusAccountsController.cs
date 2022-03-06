#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using E_commerce.API.Data;
using E_commerce.API.Models;

namespace E_commerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CusAccountsController : ControllerBase
    {
        private readonly MedicineContext _context;

        public CusAccountsController(MedicineContext context)
        {
            _context = context;
        }

        // GET: api/CusAccounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CusAccount>>> GetCusAccounts()
        {
            return await _context.CusAccounts.ToListAsync();
        }

        // GET: api/CusAccounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CusAccount>> GetCusAccount(int id)
        {
            var cusAccount = await _context.CusAccounts.FindAsync(id);

            if (cusAccount == null)
            {
                return NotFound();
            }

            return cusAccount;
        }

        // PUT: api/CusAccounts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCusAccount(int id, CusAccount cusAccount)
        {
            if (id != cusAccount.ID_TKKH)
            {
                return BadRequest();
            }

            _context.Entry(cusAccount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CusAccountExists(id))
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

        // POST: api/CusAccounts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CusAccount>> PostCusAccount(CusAccount cusAccount)
        {
            _context.CusAccounts.Add(cusAccount);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCusAccount", new { id = cusAccount.ID_TKKH }, cusAccount);
        }

        // DELETE: api/CusAccounts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCusAccount(int id)
        {
            var cusAccount = await _context.CusAccounts.FindAsync(id);
            if (cusAccount == null)
            {
                return NotFound();
            }

            _context.CusAccounts.Remove(cusAccount);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CusAccountExists(int id)
        {
            return _context.CusAccounts.Any(e => e.ID_TKKH == id);
        }
    }
}
