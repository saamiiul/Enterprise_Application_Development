using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Blog_Application.Models
{
    public class User
    {
        [Required(ErrorMessage = "Email field is Required.")]
        [EmailAddress(ErrorMessage = "Email format is not Correct.")]
        [StringLength(50)]
        public string email { set; get; }

        [Required(ErrorMessage = "Password field is Required.")]
        [StringLength(50)]
        public string password { set; get; }
    }
}
