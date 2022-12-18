using MyModels.Models;
using EFCodeFirstAdminStudent.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EFCodeFirstAdminStudent.Services
{
    public class AdminService
    {
        private AppDbContext _context;
        public AppDbContext context
        {
            get => _context;
            set => _context = value;
        }

        public AdminService()
        {
            _context= new AppDbContext();
        }

        public void CreateCandidate()
        {
            try
            {
                // Adding details info from console
                Console.WriteLine("Creating Candidate...");
                Console.Write("Enter First Name: ");
                var fName = Console.ReadLine();

                Console.Write("Enter Middle Name: ");
                var mName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                var lName = Console.ReadLine();

                Console.Write("Enter Gender Name: ");
                string gender = Console.ReadLine();

                Console.Write("Enter Native Language: ");
                string nativeLanguage = Console.ReadLine();

                Console.Write("Enter BirthDate: ");
                DateTime birthDate = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Enter Photo Id Type: ");
                string photoIdType = Console.ReadLine();

                Console.Write("Enter Photo Id Number: ");
                string photoIdNumber = Console.ReadLine();

                Console.Write("Enter Photo Id Issue Date: ");
                DateTime photoIdIssueDate = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Enter Email: ");
                string email = Console.ReadLine();

                Console.Write("Enter Address Line: ");
                string addressLine = Console.ReadLine();

                Console.Write("Enter Address Line 2: ");
                string addressLine2 = Console.ReadLine();

                Console.Write("Enter Country Of Residence: ");
                string countryOfResidence = Console.ReadLine();

                Console.Write("Enter Province: ");
                string province = Console.ReadLine();

                Console.Write("Enter City: ");
                string city = Console.ReadLine();

                Console.Write("Enter Postal Code: ");
                string postalCode = Console.ReadLine();

                Console.Write("Enter Landline Number: ");
                string landlineNumber = Console.ReadLine();

                Console.Write("Enter Mobile Number: ");
                string mobileNumber = Console.ReadLine();


                // Creating Candidate and add Details
                context.Candidates.Add(new Candidate
                {
                    FirstName = fName,
                    MiddleName = mName,
                    LastName = lName,
                    Gender = context.Genders.Where(x => x.GenderType == gender).SingleOrDefault(),
                    NativeLanguage = nativeLanguage,
                    BirthDate = birthDate,
                    PhotoIdType = context.PhotoIdTypes.Where(x => x.Type == photoIdType).SingleOrDefault(),
                    PhotoIdNumber = photoIdNumber,
                    PhotoIssueDate = photoIdIssueDate,
                    Email = email,
                    AddressLine = addressLine,
                    AddressLine2 = addressLine2,
                    CountryOfResidence = countryOfResidence,
                    Province = province,
                    City = city,
                    PostalCode = postalCode,
                    LandlineNumber = landlineNumber,
                    MobileNumber = mobileNumber
                });

                context.SaveChanges();

                Console.WriteLine();
                Console.WriteLine($"New Candidate has been added.\n");
                Console.WriteLine("Press any key to go back to menu...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Problem with create new Candidate Method");
            }

            Console.ReadKey();
        }

        public void UpdateCandidate()
        {
            try
            {
                // Adding details info from console
                Console.WriteLine("Updating Candidate...");
                Console.Write("Enter the Id of the Candidate that need to be updated: ");
                int id = Convert.ToInt32(Console.ReadLine());
                var candidate = context.Candidates.Find(id);

                Console.WriteLine();
                Console.WriteLine("Fill in the field to update Candidate or leave it blank to stay as it is.");
                Console.WriteLine();

                Console.Write("Enter First Name: ");
                var fName = Console.ReadLine();

                Console.Write("Enter Middle Name: ");
                var mName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                var lName = Console.ReadLine();

                Console.Write("Enter Gender Name: ");
                string gender = Console.ReadLine();

                Console.Write("Enter Native Language: ");
                string nativeLanguage = Console.ReadLine();

                Console.Write("Enter BirthDate: ");
                string birthDate = Console.ReadLine();


                Console.Write("Enter Photo Id Type: ");
                string photoIdType = Console.ReadLine();

                Console.Write("Enter Photo Id Number: ");
                string photoIdNumber = Console.ReadLine();

                Console.Write("Enter Photo Id Issue Date: ");
                string photoIdIssueDate = Console.ReadLine();

                Console.Write("Enter Email: ");
                string email = Console.ReadLine();

                Console.Write("Enter Address Line: ");
                string addressLine = Console.ReadLine();

                Console.Write("Enter Address Line 2: ");
                string addressLine2 = Console.ReadLine();

                Console.Write("Enter Country Of Residence: ");
                string countryOfResidence = Console.ReadLine();

                Console.Write("Enter Province: ");
                string province = Console.ReadLine();

                Console.Write("Enter City: ");
                string city = Console.ReadLine();

                Console.Write("Enter Postal Code: ");
                string postalCode = Console.ReadLine();

                Console.Write("Enter Landline Number: ");
                string landlineNumber = Console.ReadLine();

                Console.Write("Enter Mobile Number: ");
                string mobileNumber = Console.ReadLine();


            
                if (!String.IsNullOrEmpty(fName))
                {
                    candidate.FirstName = fName;
                }
                if (!String.IsNullOrEmpty(mName))
                {
                    candidate.MiddleName = mName;
                }
                if (!String.IsNullOrEmpty(lName))
                {
                    candidate.LastName = lName;
                }
                if (!String.IsNullOrEmpty(gender))
                {
                    candidate.Gender = context.Genders.Where(x => x.GenderType == gender).SingleOrDefault();
                }
                if (!String.IsNullOrEmpty(nativeLanguage))
                {
                    candidate.NativeLanguage = nativeLanguage;
                }
                if (!String.IsNullOrEmpty(birthDate))
                {
                    candidate.BirthDate = Convert.ToDateTime(birthDate);
                }
                if (!String.IsNullOrEmpty(photoIdType))
                {
                    candidate.PhotoIdType = context.PhotoIdTypes.Where(x => x.Type == photoIdType).SingleOrDefault(); ;
                }
                if (!String.IsNullOrEmpty(photoIdNumber))
                {
                    candidate.PhotoIdNumber = photoIdNumber;
                }
                if (!String.IsNullOrEmpty(photoIdIssueDate))
                {
                    candidate.PhotoIssueDate = Convert.ToDateTime(photoIdIssueDate);
                }
                if (!String.IsNullOrEmpty(email))
                {
                    candidate.Email = email;
                }
                if (!String.IsNullOrEmpty(addressLine))
                {
                    candidate.AddressLine = addressLine;
                }
                if (!String.IsNullOrEmpty(addressLine2))
                {
                    candidate.AddressLine2 = addressLine2;
                }
                if (!String.IsNullOrEmpty(countryOfResidence))
                {
                    candidate.CountryOfResidence = countryOfResidence;
                }
                if (!String.IsNullOrEmpty(province))
                {
                    candidate.Province = province;
                }
                if (!String.IsNullOrEmpty(city))
                {
                    candidate.City = city;
                }
                if (!String.IsNullOrEmpty(postalCode))
                {
                    candidate.PostalCode = postalCode;
                }
                if (!String.IsNullOrEmpty(mobileNumber))
                {
                    candidate.MobileNumber = mobileNumber;
                }

                context.SaveChanges();

                Console.WriteLine();
                Console.WriteLine($"Candidate with id: {id}, has been updated.\n");
                Console.WriteLine("Press any key to go back to menu...");
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Problem with update data of Candidate Method");
            }
        }

        public void ReadCandidate()
        {
            try
            {
                Console.Write("Enter the Id of the Candidate you want to read: ");
                int id = Convert.ToInt32(Console.ReadLine());
                var candidate = context.Candidates.Where(c => c.CandidateId == id).SingleOrDefault();
                context.Entry(candidate).Reference(c => c.Gender).Load();
                context.Entry(candidate).Reference(c => c.PhotoIdType).Load();
                Console.WriteLine();
                Console.WriteLine(candidate);

                Console.WriteLine();
                Console.WriteLine("Press any key to go back to menu...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Something happened with ReadCandidate Method");
            }
            Console.ReadKey();

        }

        public void ReadAllTheCandidates()
        {
            try
            {
                var candidates = context.Candidates.ToList();
                foreach (var candidate in candidates)
                {
                    context.Entry(candidate).Reference(x => x.Gender).Load();
                    context.Entry(candidate).Reference(x => x.PhotoIdType).Load();
                    Console.WriteLine(candidate);
                    Console.WriteLine("\n-------------------------------------------------\n");
                }
                Console.WriteLine("Press any key to go back to menu...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Something happened with ReadAllTheCandidates");
            }
            Console.ReadKey();
        }

        public void ReadCandidateExamsResults()
        {
            try
            {
                Console.Write("Enter the Id of the Candidate, to see the results of their exams: ");
                int id = Convert.ToInt32(Console.ReadLine());
                var candidateExams = context.Exams.ToList();

                foreach (var exam in candidateExams)
                {
                    context.Entry(exam).Reference(e => e.CertificateType).Load();
                    context.Entry(exam).Reference(e => e.CandidateId).Load();
                    context.Entry(exam).Reference(e => e.MarkPerTopic).Load();
                    if (exam.CandidateId.CandidateId == id)
                    {
                        Console.WriteLine();
                        Console.WriteLine(exam);
                        Console.WriteLine("\n-------------------------------------------------\n");
                    }
                }
                Console.WriteLine("Press any key to go back to menu...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Something happened in ReadCandidateExamsResults Method");
            }
            Console.ReadKey();
        }

        public void ReadAllCadidatesExamsResults()
        {
            try
            {
                var exams = context.Exams.ToList();
                foreach (var exam in exams)
                {
                    context.Entry(exam).Reference(e => e.CertificateType).Load();
                    context.Entry(exam).Reference(e => e.CandidateId).Load();
                    context.Entry(exam).Reference(e => e.MarkPerTopic).Load();
                    Console.WriteLine(exam);
                    Console.WriteLine("\n-------------------------------------------------\n");
                }
                Console.WriteLine("Press any key to go back to menu...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Something happened with ReadAllCadidatesExamsResults Method.");
            }
            Console.ReadKey();
        }

        public void RemoveCandidate()
        {
            try
            {
                Console.Write("Enter the Id of the Candidate you want to remove: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nAre you sure you want to delete a Candidate?" +
                    "\nDeleting a Candidate will delete the Cartificate and Exams data of this specific Candidate.\n" +
                    "Press \"yes\" to continue or \"no\" to cancel: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "yes")
                {
                    // Delete Candidate with no Cascade
                    var candidate = context.Candidates.Where(x => x.CandidateId == id).SingleOrDefault();
                    var certificates = context.Certificates.Where(c => c.CandidateId.CandidateId == id).ToList();
                    var exams = context.Exams.Where(a => a.CandidateId.CandidateId == id).ToList();


                    context.Candidates.Remove(candidate);



                    context.SaveChanges();

                    Console.WriteLine();
                    Console.WriteLine($"Candidate with id: {id}, has been removed.\n");
                }
                else
                {
                    Console.WriteLine("\nDeleting canceled...\n");
                }

                Console.WriteLine("Press any key to go back to menu...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.InnerException.Message);
                Console.WriteLine("Something happend with RemoveCandidate Method");
            }
            Console.ReadKey();
        }
    }
}
