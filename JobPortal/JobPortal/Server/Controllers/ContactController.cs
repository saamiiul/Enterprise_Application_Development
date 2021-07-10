using JobPortal.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly JobPortalContext _context = new JobPortalContext();
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Contact contact)
        {
            JobPortalContext context = new JobPortalContext();
            context.Contacts.Add(contact);
            await context.SaveChangesAsync();
            return Ok(context);
        }
    }
}
