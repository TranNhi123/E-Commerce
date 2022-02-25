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
    public class ClassificationDetailsController : ControllerBase
    {
        private readonly MedicineContext _context;

        public ClassificationDetailsController(MedicineContext context)
        {
            _context = context;
        }

        // GET: api/ClassificationDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassificationDetail>>> GetClassificationDetails()
        {
            return await _context.ClassificationDetails.ToListAsync();
        }

        // GET: api/ClassificationDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClassificationDetail>> GetClassificationDetail(int id)
        {
            var classificationDetail = await _context.ClassificationDetails.FindAsync(id);

            if (classificationDetail == null)
            {
                return NotFound();
            }

            return classificationDetail;
        }

        // PUT: api/ClassificationDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClassificationDetail(int id, ClassificationDetail classificationDetail)
        {
            if (id != classificationDetail.ID_phan_loai)
            {
                return BadRequest();
            }

            _context.Entry(classificationDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassificationDetailExists(id))
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

        // POST: api/ClassificationDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ClassificationDetail>> PostClassificationDetail(ClassificationDetail classificationDetail)
        {
            _context.ClassificationDetails.Add(classificationDetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ClassificationDetailExists(classificationDetail.ID_phan_loai))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetClassificationDetail", new { id = classificationDetail.ID_phan_loai }, classificationDetail);
        }

        // DELETE: api/ClassificationDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClassificationDetail(int id)
        {
            var classificationDetail = await _context.ClassificationDetails.FindAsync(id);
            if (classificationDetail == null)
            {
                return NotFound();
            }

            _context.ClassificationDetails.Remove(classificationDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClassificationDetailExists(int id)
        {
            return _context.ClassificationDetails.Any(e => e.ID_phan_loai == id);
        }
    }
}
