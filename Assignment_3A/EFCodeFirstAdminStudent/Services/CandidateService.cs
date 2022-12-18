using EFCodeFirstAdminStudent.Data.Services;
using PdfCertificateMaker.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstAdminStudent.Services
{
    public class CandidateService
    {
        private AppDbContext _context;
        public AppDbContext context
        {
            get => _context;
            set => _context = value;
        }

        public CandidateService()
        {
            _context = new AppDbContext();
        }

        public void ReadCandidateCertificates()
        {
            try
            {
                Console.Write("Enter your CandidateId, to see your Certificates: ");
                int id = Convert.ToInt32(Console.ReadLine());
                int countCertificates = 0;
                var candidateCertificates = context.Certificates.ToList();

                foreach (var certificate in candidateCertificates)
                {
                    context.Entry(certificate).Reference(e => e.CertificateType).Load();
                    context.Entry(certificate).Reference(e => e.CandidateId).Load();
                    context.Entry(certificate).Reference(e => e.Exam).Load();
                    if (certificate.CandidateId.CandidateId == id)
                    {
                        Console.WriteLine();
                        Console.WriteLine(certificate);
                        Console.WriteLine("\n-------------------------------------------------");
                        countCertificates++;
                    }
                }

                if (countCertificates == 0)
                {
                    Console.WriteLine("\nYou dont have any Certificates yet...\n");
                }

                Console.WriteLine("Press any key to go back to menu...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Something happened with ReadCandidateCertificates Method");
            }
        }

        

        public void ExtractCertificatePdf()
        {
            try
            {
                Console.WriteLine();
                Console.Write("Enter the CertificateId of the Certificate you want to download: ");
                int certificateId = Convert.ToInt32(Console.ReadLine());

                var certificate = context.Certificates.Where(x => x.CertificateId == certificateId).SingleOrDefault();

                // If Certificate Not Exists Show This Message
                if(certificate == null)
                {
                    Console.WriteLine("\nNo Certificate was found with this Id. \n");
                }
                else
                {
                    context.Entry(certificate).Reference(e => e.CertificateType).Load();
                    context.Entry(certificate).Reference(e => e.CandidateId).Load();

                    PdfCertificateService pdfService = new PdfCertificateService();
                    pdfService.CreatePdfCertificate(certificate.CandidateId.FirstName,
                                                    certificate.CandidateId.LastName,
                                                    certificate.CertificateType.Type);

                    Console.WriteLine("\nCongratulations! Your Certificate has been downloaded. " +
                                  "It is located in your Downloads Folder\n");
                }

                Console.WriteLine("Press any key to go back to menu...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Some kind of problem ExtractCertificatePdf Method");
            }
        }
    }
}
