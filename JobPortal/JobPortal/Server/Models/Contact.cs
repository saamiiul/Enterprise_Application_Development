﻿using System;
using System.Collections.Generic;

#nullable disable

namespace JobPortal.Server.Models
{
    public partial class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string AdditionalDetails { get; set; }
    }
}
