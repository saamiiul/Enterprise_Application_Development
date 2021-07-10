using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace JobPortal.Server.Models
{
    public partial class ApplyJob
    {
        [Key]
        public int ApplyId { get; set; }
        public string CandidateName { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string JobLocation { get; set; }
        public string CandidateEmail { get; set; }
    }
}
