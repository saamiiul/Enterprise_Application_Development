using System;
using System.Collections.Generic;

#nullable disable

namespace JobPortal.Server.Models
{
    public partial class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPassword { get; set; }
        public string CompanyLocation { get; set; }
        public string CompanyMoto { get; set; }
    }
}
