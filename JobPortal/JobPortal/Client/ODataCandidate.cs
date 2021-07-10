using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Client
{
    public  class Candidate
    {
        
        public int CandidateId { get; set; } = 0;
        [Required (ErrorMessage ="Name field is required.")]
        [StringLength(50,ErrorMessage ="Name is too long")]
        public string CandidateName { get; set; }
        [Required(ErrorMessage = "Email field is required.")]
        [EmailAddress]
        public string CandidateEmail { get; set; }
        [Required(ErrorMessage = "Password field is required.")]
        [StringLength(20,ErrorMessage ="Password is not Long more than 20 characters")]
        public string CandidatePassord { get; set; }
       
    }
    public class ApplyJob
    {
        public int ApplyId { get; set; }
        [Required(ErrorMessage ="Candidate Name is required.")]
        public string CandidateName { get; set; }
        [Required(ErrorMessage ="Job Title must required.")]
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string JobLocation { get; set; }
        [Required(ErrorMessage = "Candidate Email is required.")]
        public string CandidateEmail { get; set; }
        
    }
    public class Value
    {
        [Newtonsoft.Json.JsonProperty("odata.Candidate")]
        public string CandidateEmail { get; set; }
        public string CandidatePassord { get; set; }
        [Newtonsoft.Json.JsonProperty("odata.CompanyPost")]
        public int CompanyPostId { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        
        
        public string JobInfo { get; set; }
        public int CompanyId { get; set; }
        
        public string JobLocation { get; set; }
        [Newtonsoft.Json.JsonProperty("odata.Company")]

        public string CompanyEmail { get; set; }
        public string CompanyPassword { get; set; }
        public string CompanyLocation { get; set; }
        public string CompanyMoto { get; set; }
        [Newtonsoft.Json.JsonProperty("odata.ApplyJob")]
        public int ApplyId { get; set; }
        public string CandidateName { get; set; }

    }
    public class ODataCandidate <T>
    {
        [Newtonsoft.Json.JsonProperty("odata.context")]
        public string Metadata { get; set; }
        
        public List<T> Value { get; set; }
    }
    
    public class CompanyPost
    {

        public int CompanyPostId { get; set; }
        [Required(ErrorMessage ="Company Name is required.")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage ="Job Title is required.")]
        public string JobTitle { get; set; }
        [Required(ErrorMessage = "Job Location is required.")]
        public string JobLocation { get; set; }
        [Required(ErrorMessage = "Job Infoz is required.")]
        public string JobInfo { get; set; }
        public int CompanyId { get; set; }


    }
    public class SearchJob
    {
        public string MyLocation { get; set; }
        public string MyTitle { get; set; }
        public string MyInputField { get; set; }
    }

    public class Company
    {
        
        public int CompanyId { get; set; }
        [Required(ErrorMessage = "Company Name field is required.")]
        [StringLength(50,ErrorMessage ="Compnay Name is not more than 50 characters")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Company Email field is required.")]
        [EmailAddress]
        public string CompanyEmail { get; set; }
        [Required(ErrorMessage = "Company Password field is required.")]
        [StringLength(20,ErrorMessage ="Password is no more than 20 characters.")]
        public string CompanyPassword { get; set; }
        [Required(ErrorMessage = "Company Location field is required.")]
        [StringLength(20,ErrorMessage ="Location is not more than 20 characters")]
        public string CompanyLocation { get; set; }
        public string CompanyMoto { get; set; }
    }
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string AdditionalDetails { get; set; }
    }
}
