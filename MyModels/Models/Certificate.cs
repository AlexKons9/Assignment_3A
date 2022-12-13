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
        private int _candidateScore;
        private int _maxScore;
        private string _percentageScore;


        [Key]
        public int CertificateId { get; set; }
        [Required]
        public CertificateType CertificateType { get; set; }
        public Candidate CandidateId { get; set; }
        public string AssessmentTestCode { get; set; }
        public DateTime ExaminationDate { get; set; }
        public DateTime ScoreReportDate { get; set; }
        [Required]
        public int CandidateScore { get; set; }
        public int MaximumScore { get; set; } = 100;
        public string PercentageScore { get; set; } = "100%";
        public Exam Exam { get; set; }
        public string TopicDescription { get; set; }
        public int NumberOfAwardedMarks { get; set; }
        public int NumberOfPossibleMakrs { get; set; }

        public override string ToString()
        {
            return $"CertificateId: {CertificateId}\nCertificateType: {CertificateType.Type}\nCandidateId: {CandidateId}\nAssessmentTestCode: {AssessmentTestCode}\n\n" +
                   $"ExaminationDate: {ExaminationDate}\nScoreReportDate: {ScoreReportDate}\nCandidateScore: {CandidateScore}\nMaximumScore: {MaximumScore}\n\n" +
                   $"PercentageScore: {PercentageScore}\nAssessmentTestResult: {Exam.AssessmentTestResult}\nNumberOfAwarderMarks: {NumberOfAwardedMarks}\nNumberOfPossibleMarks: {NumberOfAwardedMarks}";
        }
    }
}
