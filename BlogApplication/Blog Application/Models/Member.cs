using System;   
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Blog_Application.Models
{
    public class Member
    {
        [Required(ErrorMessage = "First Name field is Required.")]
        [StringLength(20)]
        public string firstName { set; get; }

        [Required(ErrorMessage = "Last Name field is Required.")]
        [StringLength(20)]
        public string lastName { set; get; }

        [Required(ErrorMessage = "User Name field is Required.")]
        [StringLength(10)]
        public string userName { set; get; }

        [Required(ErrorMessage = "Email field is Required.")]
        [EmailAddress(ErrorMessage = "Email format is not Correct.")]
        [StringLength(50)]
        public string email { set; get; }

        [Required(ErrorMessage = "Password field is Required.")]
        [StringLength(50)]
        public string password { set; get; }

        [Required(ErrorMessage = "Confirm Password field is Required.")]
        [Compare("password", ErrorMessage = "The Password and Confirm Password fields do not match.")]
        [StringLength(50)]
        public string confirmPassword { set; get; }

        [StringLength(50)]
        public string gender { set; get; }
        
    }
}
