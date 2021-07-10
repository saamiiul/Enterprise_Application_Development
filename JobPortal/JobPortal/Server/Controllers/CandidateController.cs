using JobPortal.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JobPortal.Server.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class CandidateController : ODataController
    {
        public JobPortalContext context = new JobPortalContext();
        // GET: api/<CandidateController>
        //[HttpGet]
        [EnableQuery]
        public IEnumerable<Candidate> Get()
        {
            return context.Candidates;
        }

        // GET api/<CandidateController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<CandidateController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Candidate candidate)
        {
            context.Candidates.Add(candidate);
            await context.SaveChangesAsync();
            return Ok(context);
        }

        // PUT api/<CandidateController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CandidateController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
