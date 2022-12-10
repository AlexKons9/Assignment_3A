using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.Models
{
    internal class Gender
    {
        [Key]
        public int GenderId { get; set; }
        [Required]
        public string GenderType { get; set; }
    }
}
