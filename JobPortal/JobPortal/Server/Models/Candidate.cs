using System;
using System.Collections.Generic;

#nullable disable

namespace JobPortal.Server.Models
{
    public partial class Candidate
    {
        public int CandidateId { get; set; }
        public string CandidateName { get; set; }
        public string CandidateEmail { get; set; }
        public string CandidatePassord { get; set; }
    }
}
