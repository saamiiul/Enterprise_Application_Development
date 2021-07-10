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
    public class AddController : ControllerBase
    {
        private readonly JobPortalContext _context = new JobPortalContext();
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Candidate candidate)
        {
            JobPortalContext context = new JobPortalContext();
            context.Candidates.Add(candidate);
            await context.SaveChangesAsync();
            return Ok(context);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompany(int id, Candidate candidate)
        {

            _context.Entry(candidate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

            }

            return NoContent();
        }

    }
}
