using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.Models
{
    internal class Exam
    {
        [Key]
        public int ExamsId { get; set; }
        public MarkPerTopic MarkPerTopic { get; set; }
        public int TotalMark { get; set; }
        public AssessmentTestResult AssessmentTestResult { get; set;}
    }
}
