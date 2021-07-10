using System;
using System.Collections.Generic;

#nullable disable

namespace JobPortal.Server.Models
{
    public partial class CompanyPost
    {
        public int CompanyPostId { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string JobLocation { get; set; }
        public string JobInfo { get; set; }
        public int CompanyId { get; set; }
    }
}
