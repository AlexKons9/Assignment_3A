using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.Models
{
    public class Exam
    {
        [Key]
        public int ExamsId { get; set; }
        public MarkPerTopic MarkPerTopic { get; set; }
        public string AssessmentTestResult 
        {
            get { return AssessmentTestResult; }
            set
            {
                if (MarkPerTopic.FinalScore >= 65)
                {
                    AssessmentTestResult = "Pass";
                }
                else
                {
                    AssessmentTestResult = "Fail";
                }
            }
        }
    }
}
