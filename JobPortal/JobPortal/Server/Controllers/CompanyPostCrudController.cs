using JobPortal.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyPostCrudController : ControllerBase
    {
        private readonly JobPortalContext _context = new JobPortalContext();
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CompanyPost post)
        {
            JobPortalContext context = new JobPortalContext();
            context.CompanyPosts.Add(post);
            await context.SaveChangesAsync();
            return Ok(context);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompany(int id, CompanyPost company)
        {

            _context.Entry(company).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                
            }

            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<CompanyPost>> DeleteCompany(int id)
        {
            var company = await _context.CompanyPosts.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            _context.CompanyPosts.Remove(company);
            await _context.SaveChangesAsync();

            return company;
        }
    }
}
