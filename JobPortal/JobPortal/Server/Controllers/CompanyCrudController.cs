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
    public class CompanyCrudController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Company company)
        {
            JobPortalContext context = new JobPortalContext();
            context.Companies.Add(company);
            await context.SaveChangesAsync();
            return Ok(context);
        }
    }
}
