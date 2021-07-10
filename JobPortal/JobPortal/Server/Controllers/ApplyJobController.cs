using JobPortal.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Server.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class ApplyJobController : ODataController
    {
        [EnableQuery]
        public IEnumerable<ApplyJob> Get()
        {
            return new JobPortalContext().ApplyJobs;
        }
    }
}
