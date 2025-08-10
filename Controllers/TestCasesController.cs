using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestManagementAPI.Data;
using TestManagementAPI.Models;

namespace TestManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestCasesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TestCasesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/TestCases
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TestCase>>> GetTestCases()
        {
            return await _context.TestCases
                                 .Include(tc => tc.Scenario)
                                 .ToListAsync();
        }

        // GET: api/TestCases/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TestCase>> GetTestCase(int id)
        {
            var testCase = await _context.TestCases
                                         .Include(tc => tc.Scenario)
                                         .FirstOrDefaultAsync(tc => tc.Id == id);

            if (testCase == null)
            {
                return NotFound();
            }

            return testCase;
        }

        // POST: api/TestCases
        [HttpPost]
        public async Task<ActionResult<TestCase>> PostTestCase(TestCase testCase)
        {
            _context.TestCases.Add(testCase);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTestCase), new { id = testCase.Id }, testCase);
        }

        // PUT: api/TestCases/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTestCase(int id, TestCase testCase)
        {
            if (id != testCase.Id)
            {
                return BadRequest();
            }

            _context.Entry(testCase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.TestCases.Any(e => e.Id == id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // DELETE: api/TestCases/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestCase(int id)
        {
            var testCase = await _context.TestCases.FindAsync(id);
            if (testCase == null)
            {
                return NotFound();
            }

            _context.TestCases.Remove(testCase);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
