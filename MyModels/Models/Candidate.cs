using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.Models
{
    internal class Candidate
    {
        [Key]
        public int CandidateId { get; set; }
        [Required]
        public string FirstName { get; set;}
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set;}
        public Gender Gender { get; set; }
        public string NativeLanguage { get; set; }
        public DateTime BirthDate { get; set; }
        public PhotoIdType PhotoIdType { get; set; }
        public string PhotoIdNumber { get; set;}
        public DateTime PhotoIssueDate { get; set;}
        [Required]
        public string Email { get; set; }
        public string AddressLine { get; set; }
        public string AddressLine2 { get; set; }
        public string CountryOfResidence { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string LandlineNumber { get; set; }
        public string MobileNumber { get; set; }

    }
}
