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
    public class ClassifiesController : ControllerBase
    {
        private readonly MedicineContext _context;

        public ClassifiesController(MedicineContext context)
        {
            _context = context;
        }

        // GET: api/Classifies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Classify>>> GetClassifies()
        {
            return await _context.Classifies.ToListAsync();
        }

        // GET: api/Classifies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Classify>> GetClassify(int id)
        {
            var classify = await _context.Classifies.FindAsync(id);

            if (classify == null)
            {
                return NotFound();
            }

            return classify;
        }

        // PUT: api/Classifies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClassify(int id, Classify classify)
        {
            if (id != classify.ID_phan_loai)
            {
                return BadRequest();
            }

            _context.Entry(classify).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassifyExists(id))
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

        // POST: api/Classifies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Classify>> PostClassify(Classify classify)
        {
            _context.Classifies.Add(classify);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClassify", new { id = classify.ID_phan_loai }, classify);
        }

        // DELETE: api/Classifies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClassify(int id)
        {
            var classify = await _context.Classifies.FindAsync(id);
            if (classify == null)
            {
                return NotFound();
            }

            _context.Classifies.Remove(classify);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClassifyExists(int id)
        {
            return _context.Classifies.Any(e => e.ID_phan_loai == id);
        }
    }
}
