using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.Models
{
    public class Certificate
    {
        [Key]
        public int CertificateId { get; set; }
        [Required]
        public CertificateType CertificateType { get; set; }
        public Candidate Candidate { get; set; }
        public string AssessmentTestCode { get; set; }
        public DateTime ExaminationDate { get; set; }
        public DateTime ScoreReportDate { get; set; }
        [Required]
        public int CandidateScore { get { return CandidateScore; } set { CandidateScore = Exam.MarkPerTopic.FinalScore; } }
        public int MaximumScore { get; set; }
        public string PercentageScore { get; set; }
        public Exam Exam { get; set; }
        public string TopicDescription { get; set; }
        public int NumberOfAwardedMarks { get; set; }
        public int NumberOfPossibleMakrs { get; set; }
    }
}
