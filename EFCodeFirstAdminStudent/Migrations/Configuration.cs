namespace EFCodeFirstAdminStudent.Migrations
{
    using MyModels.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFCodeFirstAdminStudent.Data.Services.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFCodeFirstAdminStudent.Data.Services.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            try
            {
                // Add Photo Id Types
                AddPhotoIdTypes();

                // Add Certificate Types
                AddCertificateTypes();

                // Add Gender Types
                AddGenderTypes();

                // Add Some Candidates
                AddCandidates();

                // Add Some Certificates
                AddCertificates();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }



            void AddPhotoIdTypes()
            {
                try
                {
                    if (context.PhotoIdTypes.Where(t => t.Type == "National Card").Count() == 0 &&
                        context.PhotoIdTypes.Where(t => t.Type == "Passport").Count() == 0)
                    {
                        context.PhotoIdTypes.Add(new PhotoIdType{ Type = "National Card" });
                        context.PhotoIdTypes.Add(new PhotoIdType { Type = "Passport" });
                        context.SaveChanges();
                    }
                }
                catch (Exception exception) 
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Something not working with AddPhotoIdTypes Method!");
                }
            }

            void AddCertificateTypes()
            {
                try
                {
                    if (context.CertificateTypes.Where(t => t.Type == "Java").Count() == 0 &&
                        context.CertificateTypes.Where(t => t.Type == "C#").Count() == 0 &&
                        context.CertificateTypes.Where(t => t.Type == "Javascript").Count() == 0 &&
                        context.CertificateTypes.Where(t => t.Type == "Python").Count() == 0 &&
                        context.CertificateTypes.Where(t => t.Type == "C++").Count() == 0 &&
                        context.CertificateTypes.Where(t => t.Type == "SDS Foundation").Count() == 0 &&
                        context.CertificateTypes.Where(t => t.Type == "SDS Advanced").Count() == 0)
                    {
                        context.CertificateTypes.Add(new CertificateType { Type = "Java", IsActive = true});
                        context.CertificateTypes.Add(new CertificateType { Type = "C#", IsActive = true });
                        context.CertificateTypes.Add(new CertificateType { Type = "Javascript", IsActive = false });
                        context.CertificateTypes.Add(new CertificateType { Type = "Python", IsActive = true });
                        context.CertificateTypes.Add(new CertificateType { Type = "C++", IsActive = false });
                        context.CertificateTypes.Add(new CertificateType { Type = "SDS Foundation", IsActive = true });
                        context.CertificateTypes.Add(new CertificateType { Type = "SDS Advanced", IsActive = true  });
                        context.SaveChanges();
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Something not working with AddCertificateTypes Method!");
                }
            }

            void AddGenderTypes()
            {
                try
                {
                    if (context.Genders.Where(t => t.GenderType == "Female").Count() == 0 &&
                        context.Genders.Where(t => t.GenderType == "Male").Count() == 0 &&
                        context.Genders.Where(t => t.GenderType == "Prefer not to say").Count() == 0 &&
                        context.Genders.Where(t => t.GenderType == "Other").Count() == 0)
                    {
                        context.Genders.Add(new Gender { GenderType = "Female" });
                        context.Genders.Add(new Gender { GenderType = "Male" });
                        context.Genders.Add(new Gender { GenderType = "Prefer not to say" });
                        context.Genders.Add(new Gender { GenderType = "Other" });
                        context.SaveChanges();
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Something not working with AddGenderTypes Method!");
                }
            }

            void AddCandidates()
            {
                try
                {


                    if (context.Candidates.Where(id => id.CandidateId == 1).Count() == 0 &&
                        context.Candidates.Where(id => id.CandidateId == 2).Count() == 0 &&
                        context.Candidates.Where(id => id.CandidateId == 3).Count() == 0 &&
                        context.Candidates.Where(id => id.CandidateId == 4).Count() == 0 &&
                        context.Candidates.Where(id => id.CandidateId == 5).Count() == 0 &&
                        context.Candidates.Where(id => id.CandidateId == 6).Count() == 0 &&
                        context.Candidates.Where(id => id.CandidateId == 7).Count() == 0 &&
                        context.Candidates.Where(id => id.CandidateId == 8).Count() == 0 &&
                        context.Candidates.Where(id => id.CandidateId == 9).Count() == 0 &&
                        context.Candidates.Where(id => id.CandidateId == 10).Count() == 0) 
                    {
                        var genderMale = context.Genders.Where(x => x.GenderType == "Male").SingleOrDefault();
                        var genderFemale = context.Genders.Where(x => x.GenderType == "Female").SingleOrDefault();
                        var idTypeNationalCard = context.PhotoIdTypes.Where(x => x.Type == "National Card").SingleOrDefault();
                        var idTypePassport = context.PhotoIdTypes.Where(x => x.Type == "Passport").SingleOrDefault();

                        context.Candidates.Add(new Candidate 
                        {
                            FirstName = "Alexandros",
                            MiddleName = "Nikolaos",
                            LastName = "Lepeniotis",
                            Gender = genderMale,
                            NativeLanguage = "Greek",
                            BirthDate = new DateTime(1992,02,02),
                            PhotoIdType = idTypeNationalCard,
                            PhotoIdNumber = "AA 123456",
                            PhotoIssueDate = new DateTime(2009,01,01),
                            Email = "alex@alex.com",
                            AddressLine = "Korai 5",
                            AddressLine2 = "2nd Floor",
                            CountryOfResidence = "Greece",
                            Province = "Attiki",
                            City = "Athens",
                            PostalCode = "12345",
                            LandlineNumber = "+306912345678",
                            MobileNumber = "+302109090999"
                        });
                        context.Candidates.Add(new Candidate
                        {
                            FirstName = "Mpampis",
                            LastName = "Papadimitriou",
                            Gender = genderMale,
                            NativeLanguage = "Greek",
                            BirthDate = new DateTime(1998,01,01),
                            PhotoIdType = idTypeNationalCard,
                            PhotoIdNumber = "AB 999999",
                            PhotoIssueDate = new DateTime(2015,05,05),
                            Email = "mpa@mpampis.com",
                            AddressLine = "Axeloou 7",
                            AddressLine2 = "Ground Floor",
                            CountryOfResidence = "Greece",
                            Province = "Thessaloniki",
                            City = "Kalamaria",
                            PostalCode = "12345",
                            LandlineNumber = "+306912345678",
                            MobileNumber = "+30231009090"
                        });
                        context.Candidates.Add(new Candidate
                        {
                            FirstName = "Kostas",
                            LastName = "Kostopoulos",
                            Gender = genderMale,
                            NativeLanguage = "Greek",
                            BirthDate = new DateTime(1980, 05, 12),
                            PhotoIdType = idTypeNationalCard,
                            PhotoIdNumber = "AH 111111",
                            PhotoIssueDate = new DateTime(2015, 09, 25),
                            Email = "kostas@kostopoulos.com",
                            AddressLine = "Pentelis 2",
                            AddressLine2 = "4th Floor",
                            CountryOfResidence = "Greece",
                            Province = "Attiki",
                            City = "Athens",
                            PostalCode = "54321",
                            LandlineNumber = "+306945454545",
                            MobileNumber = "+302108888888"
                        });
                        context.Candidates.Add(new Candidate
                        {
                            FirstName = "Maria",
                            MiddleName = "Eleni",
                            LastName = "Papadopoulou",
                            Gender = genderFemale,
                            NativeLanguage = "Greek",
                            BirthDate = new DateTime(1972, 12, 12),
                            PhotoIdType = idTypePassport,
                            PhotoIdNumber = "AHQ4567FG",
                            PhotoIssueDate = new DateTime(2022, 10, 10),
                            Email = "maria-eleni@papadopoulou.com",
                            AddressLine = "Markou Mpotsari 67",
                            AddressLine2 = "1st Floor",
                            CountryOfResidence = "Greece",
                            Province = "Attiki",
                            City = "Athens",
                            PostalCode = "23456",
                            LandlineNumber = "+306989898809",
                            MobileNumber = "+3021000000"
                        });
                        context.Candidates.Add(new Candidate
                        {
                            FirstName = "Giannis",
                            MiddleName = "Marios",
                            LastName = "Papantoniou",
                            Gender = genderMale,
                            NativeLanguage = "Greek",
                            BirthDate = new DateTime(1970, 05, 12),
                            PhotoIdType = idTypeNationalCard,
                            PhotoIdNumber = "BA 989898",
                            PhotoIssueDate = new DateTime(2020, 05, 17),
                            Email = "giannis@papanto.com",
                            AddressLine = "Zagoriou 54",
                            AddressLine2 = "Ground Floor",
                            CountryOfResidence = "Greece",
                            Province = "Axaia",
                            City = "Patra",
                            PostalCode = "09899",
                            LandlineNumber = "+306932323232",
                            MobileNumber = "+302908567893"
                        });
                        context.Candidates.Add(new Candidate
                        {
                            FirstName = "Marios",
                            LastName = "Konstantinou",
                            Gender = genderMale,
                            NativeLanguage = "Greek",
                            BirthDate = new DateTime(1999, 02, 03),
                            PhotoIdType = idTypePassport,
                            PhotoIdNumber = "AZX09DF45",
                            PhotoIssueDate = new DateTime(2022, 01, 21),
                            Email = "marios@konstantinou.com",
                            AddressLine = "Koukounarias 28",
                            AddressLine2 = "3rd Floor",
                            CountryOfResidence = "Greece",
                            Province = "Attiki",
                            City = "Zografou",
                            PostalCode = "33321",
                            LandlineNumber = "+306900806754",
                            MobileNumber = "+3021045678677"
                        });
                        context.Candidates.Add(new Candidate
                        {
                            FirstName = "Eleni",
                            MiddleName = "Giota",
                            LastName = "Kakavia",
                            Gender = genderFemale,
                            NativeLanguage = "Greek",
                            BirthDate = new DateTime(1999, 01, 11),
                            PhotoIdType = idTypeNationalCard,
                            PhotoIdNumber = "AA 345678",
                            PhotoIssueDate = new DateTime(2018, 01, 10),
                            Email = "giota@kakavia.com",
                            AddressLine = "Parou 33",
                            AddressLine2 = "1th Floor",
                            CountryOfResidence = "Greece",
                            Province = "Attiki",
                            City = "Zografou",
                            PostalCode = "67678",
                            LandlineNumber = "+306978463300",
                            MobileNumber = "+30210983425"
                        });
                        context.Candidates.Add(new Candidate
                        {
                            FirstName = "Alexia",
                            LastName = "Zoumpouri",
                            Gender = genderFemale,
                            NativeLanguage = "Greek",
                            BirthDate = new DateTime(2000, 01, 02),
                            PhotoIdType = idTypeNationalCard,
                            PhotoIdNumber = "AK 345267",
                            PhotoIssueDate = new DateTime(2017, 09, 10),
                            Email = "alexia@zoumpou.com",
                            AddressLine = "Parnithas 22",
                            AddressLine2 = "3th Floor",
                            CountryOfResidence = "Greece",
                            Province = "Attiki",
                            City = "Ano Liosia",
                            PostalCode = "34546",
                            LandlineNumber = "+306945673211",
                            MobileNumber = "+30219080777"
                        });
                        context.Candidates.Add(new Candidate
                        {
                            FirstName = "Pinelopi",
                            MiddleName = "Dafni",
                            LastName = "Karaiskou",
                            Gender = genderFemale,
                            NativeLanguage = "Greek",
                            BirthDate = new DateTime(1987, 03, 03),
                            PhotoIdType = idTypePassport,
                            PhotoIdNumber = "QQ4445GF",
                            PhotoIssueDate = new DateTime(2021, 11, 04),
                            Email = "dafni_pin@kara.com",
                            AddressLine = "Spartis 99",
                            AddressLine2 = "Ground Floor",
                            CountryOfResidence = "Greece",
                            Province = "Axaia",
                            City = "Kalamata",
                            PostalCode = "669077",
                            LandlineNumber = "+306967458933",
                            MobileNumber = "+302107878666"
                        });
                        context.Candidates.Add(new Candidate
                        {
                            FirstName = "Hercules",
                            MiddleName = "John",
                            LastName = "Williams",
                            Gender = genderMale,
                            NativeLanguage = "English",
                            BirthDate = new DateTime(1960, 12, 03),
                            PhotoIdType = idTypePassport,
                            PhotoIdNumber = "FFF3456DQSA",
                            PhotoIssueDate = new DateTime(2020, 04, 01),
                            Email = "herc@williams.com",
                            AddressLine = "Dodekanisou 77",
                            AddressLine2 = "2nd Floor",
                            CountryOfResidence = "Greece",
                            Province = "Attiki",
                            City = "Drosia",
                            PostalCode = "99887",
                            LandlineNumber = "+306934556788",
                            MobileNumber = "+302108877669"
                        });
                        context.SaveChanges();
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Something not working with AddCandidate Method!");
                }
            }

            void AddCertificates()
            {
                try
                {
                    if (context.Certificates.Where(x => x.CertificateId == 1).Count() == 0)
                    {
                        // Succeeded Exam with Certificate
                        var exam1 = new Exam(context.Candidates.Where(c => c.CandidateId == 2).SingleOrDefault(), 
                            context.CertificateTypes.Where(c => c.Type == "Java").SingleOrDefault(), 
                            new MarkPerTopic()
                            {
                                MarkOfTopic1 = 20,
                                MarkOfTopic2 = 10,
                                MarkOfTopic3 = 20,
                                MarkOfTopic4 = 20
                            });

                        context.Certificates.Add(new Certificate
                        {
                            CertificateType = exam1.CertificateType,
                            CandidateId = context.Candidates.Where(c => c.CandidateId == 2).SingleOrDefault(),
                            AssessmentTestCode = "AWW 345622",
                            ExaminationDate = new DateTime(2020, 04, 22),
                            ScoreReportDate = new DateTime(2020, 04, 30),
                            Exam = exam1,
                            CandidateScore = exam1.FinalScore,
                            TopicDescription = "Java Certificate",
                            NumberOfAwardedMarks = 0,
                            NumberOfPossibleMakrs = 1
                        });

                        // A Failed Exam that did not lead to a Certificate
                        var exam2 = new Exam(context.Candidates.Where(c => c.CandidateId == 2).SingleOrDefault(), 
                            context.CertificateTypes.Where(c => c.Type == "SDS Foundation").SingleOrDefault(), 
                            new MarkPerTopic()
                            {
                                MarkOfTopic1 = 10,
                                MarkOfTopic2 = 10,
                                MarkOfTopic3 = 15,
                                MarkOfTopic4 = 20
                            });

                        // Succeeded Exam with Certificate
                        var exam3 = new Exam(context.Candidates.Where(c => c.CandidateId == 6).SingleOrDefault(), 
                            context.CertificateTypes.Where(c => c.Type == "C#").SingleOrDefault(), 
                            new MarkPerTopic()
                            {
                                MarkOfTopic1 = 20,
                                MarkOfTopic2 = 15,
                                MarkOfTopic3 = 25,
                                MarkOfTopic4 = 30
                            });

                        context.Certificates.Add(new Certificate
                        {
                            CertificateType = exam3.CertificateType,
                            CandidateId = context.Candidates.Where(c => c.CandidateId == 6).SingleOrDefault(),
                            AssessmentTestCode = "CSF 659039",
                            ExaminationDate = new DateTime(2019, 08, 04),
                            ScoreReportDate = new DateTime(2019, 08, 30),
                            Exam = exam3,
                            CandidateScore = exam3.FinalScore,
                            TopicDescription = "C# Certificate",
                            NumberOfAwardedMarks = 1,
                            NumberOfPossibleMakrs = 0
                        });

                        // A Failed Exam that did not lead to a Certificate
                        var exam4 = new Exam(context.Candidates.Where(c => c.CandidateId == 6).SingleOrDefault(), 
                            context.CertificateTypes.Where(c => c.Type == "Python").SingleOrDefault(), 
                            new MarkPerTopic()
                            {
                                MarkOfTopic1 = 10,
                                MarkOfTopic2 = 10,
                                MarkOfTopic3 = 20,
                                MarkOfTopic4 = 20
                            });

                        // Succeeded Exam with Certificate
                        var exam5 = new Exam(context.Candidates.Where(c => c.CandidateId == 6).SingleOrDefault(), 
                            context.CertificateTypes.Where(c => c.Type == "Java").SingleOrDefault(), 
                            new MarkPerTopic()
                            {
                                MarkOfTopic1 = 20,
                                MarkOfTopic2 = 15,
                                MarkOfTopic3 = 25,
                                MarkOfTopic4 = 25
                            });

                        context.Certificates.Add(new Certificate
                        {
                            CertificateType = exam5.CertificateType,
                            CandidateId = context.Candidates.Where(c => c.CandidateId == 6).SingleOrDefault(),
                            AssessmentTestCode = "JVW 375488",
                            ExaminationDate = new DateTime(2019,08,04),
                            ScoreReportDate = new DateTime(2019,09,02),
                            Exam = exam5,
                            CandidateScore = exam5.FinalScore,
                            TopicDescription = "Java Certificate",
                            NumberOfAwardedMarks = 1,
                            NumberOfPossibleMakrs = 0
                        });



                        context.SaveChanges();
                    }
                }




                //INSERT INTO Certificates(TypeOfCertificate, CandidateId, AssesmentTestCode, ExaminationDate, ScoreReportDate, CandidateScore,
                //                          MaximumScore, PercentageScore, AssesmentResult, TopicDescription, NumberOfAwardedMarks, NumberOfPossibleMarks)
                //VALUES(6, 8, 'SDS 456834FND', '2018-03-11', '2018-03-15', 92, 100, '100%', 1, 'SDS Foundation', 1, 0)
                //GO

                //INSERT INTO MarksPerTopics(CertificateId, Topic1, Topic2, Topic3, Topic4)
                //VALUES(SCOPE_IDENTITY(), 20, 20, 30, 22)
                //GO


                //INSERT INTO Certificates(TypeOfCertificate, CandidateId, AssesmentTestCode, ExaminationDate, ScoreReportDate, CandidateScore,
                //                          MaximumScore, PercentageScore, AssesmentResult, TopicDescription, NumberOfAwardedMarks, NumberOfPossibleMarks)
                //VALUES(7, 8, 'SDS 338755ADV', '2018-05-17', '2018-05-22', 87, 100, '100%', 1, 'SDS Advanced', 1, 0)
                //GO

                //INSERT INTO MarksPerTopics(CertificateId, Topic1, Topic2, Topic3, Topic4)
                //VALUES(SCOPE_IDENTITY(), 20, 15, 30, 22)
                //GO


                //INSERT INTO Certificates(TypeOfCertificate, CandidateId, AssesmentTestCode, ExaminationDate, ScoreReportDate, CandidateScore,
                //                          MaximumScore, PercentageScore, AssesmentResult, TopicDescription, NumberOfAwardedMarks, NumberOfPossibleMarks)
                //VALUES(4, 10, 'PYH 463377', '2016-11-17', '2016-11-22', 50, 100, '100%', 2, 'Python Certificate', 0, 0)
                //GO

                //INSERT INTO MarksPerTopics(CertificateId, Topic1, Topic2, Topic3, Topic4)
                //VALUES(SCOPE_IDENTITY(), 10, 15, 15, 10)
                //GO


                //INSERT INTO Certificates(TypeOfCertificate, CandidateId, AssesmentTestCode, ExaminationDate, ScoreReportDate, CandidateScore,
                //                          MaximumScore, PercentageScore, AssesmentResult, TopicDescription, NumberOfAwardedMarks, NumberOfPossibleMarks)
                //VALUES(2, 10, 'CSJ 339022', '2022-03-22', '2022-03-29', 98, 100, '100%', 1, 'C# Certificate', 1, 0)
                //GO

                //INSERT INTO MarksPerTopics(CertificateId, Topic1, Topic2, Topic3, Topic4)
                //VALUES(SCOPE_IDENTITY(), 20, 18, 30, 30)
                //GO


                //INSERT INTO Certificates(TypeOfCertificate, CandidateId, AssesmentTestCode, ExaminationDate, ScoreReportDate, CandidateScore,
                //                          MaximumScore, PercentageScore, AssesmentResult, TopicDescription, NumberOfAwardedMarks, NumberOfPossibleMarks)
                //VALUES(6, 4, 'SDS 458839FND', '2015-07-12', '2015-07-20', 83, 100, '100%', 1, 'SDS Foundation', 0, 0)
                //GO

                //INSERT INTO MarksPerTopics(CertificateId, Topic1, Topic2, Topic3, Topic4)
                //VALUES(SCOPE_IDENTITY(), 13, 20, 20, 30)
                //GO


                //INSERT INTO Certificates(TypeOfCertificate, CandidateId, AssesmentTestCode, ExaminationDate, ScoreReportDate, CandidateScore,
                //                          MaximumScore, PercentageScore, AssesmentResult, TopicDescription, NumberOfAwardedMarks, NumberOfPossibleMarks)
                //VALUES(7, 4, 'SDS 994633ADV', '2015-09-09', '2015-09-15', 62, 100, '100%', 2, 'SDS Advanced', 0, 0)
                //GO

                //INSERT INTO MarksPerTopics(CertificateId, Topic1, Topic2, Topic3, Topic4)
                //VALUES(SCOPE_IDENTITY(), 12, 5, 15, 30)
                //GO


                //INSERT INTO Certificates(TypeOfCertificate, CandidateId, AssesmentTestCode, ExaminationDate, ScoreReportDate, CandidateScore,
                //                          MaximumScore, PercentageScore, AssesmentResult, TopicDescription, NumberOfAwardedMarks, NumberOfPossibleMarks)
                //VALUES(6, 1, 'SDS 334490FND', '2022-02-10', '2022-02-15', 70, 100, '100%', 1, 'SDS Foundation', 0, 0)
                //GO

                //INSERT INTO MarksPerTopics(CertificateId, Topic1, Topic2, Topic3, Topic4)
                //VALUES(SCOPE_IDENTITY(), 20, 10, 20, 20)
                //GO


                //INSERT INTO Certificates(TypeOfCertificate, CandidateId, AssesmentTestCode, ExaminationDate, ScoreReportDate, CandidateScore,
                //                          MaximumScore, PercentageScore, AssesmentResult, TopicDescription, NumberOfAwardedMarks, NumberOfPossibleMarks)
                //VALUES(4, 1, 'PYS 993211', '2020-01-10', '2020-01-13', 80, 100, '100%', 1, 'Python Certificate', 0, 0)
                //GO

                //INSERT INTO MarksPerTopics(CertificateId, Topic1, Topic2, Topic3, Topic4)
                //VALUES(SCOPE_IDENTITY(), 20, 20, 15, 25)
                //GO


                //INSERT INTO Certificates(TypeOfCertificate, CandidateId, AssesmentTestCode, ExaminationDate, ScoreReportDate, CandidateScore,
                //                          MaximumScore, PercentageScore, AssesmentResult, TopicDescription, NumberOfAwardedMarks, NumberOfPossibleMarks)
                //VALUES(1, 9, 'JVW 889230', '2014-05-13', '2014-05-18', 88, 100, '100%', 1, 'Java Certificate', 1, 0)
                //GO

                //INSERT INTO MarksPerTopics(CertificateId, Topic1, Topic2, Topic3, Topic4)
                //VALUES(SCOPE_IDENTITY(), 20, 18, 20, 30)
                //GO


                //INSERT INTO Certificates(TypeOfCertificate, CandidateId, AssesmentTestCode, ExaminationDate, ScoreReportDate, CandidateScore,
                //                          MaximumScore, PercentageScore, AssesmentResult, TopicDescription, NumberOfAwardedMarks, NumberOfPossibleMarks)
                //VALUES(4, 5, 'PYT 998435', '2018-04-04', '2018-04-09', 90, 100, '100%', 1, 'Python Certificate', 1, 0)
                //GO

                //INSERT INTO MarksPerTopics(CertificateId, Topic1, Topic2, Topic3, Topic4)
                //VALUES(SCOPE_IDENTITY(), 20, 20, 30, 20)
                //GO


                //INSERT INTO Certificates(TypeOfCertificate, CandidateId, AssesmentTestCode, ExaminationDate, ScoreReportDate, CandidateScore,
                //                          MaximumScore, PercentageScore, AssesmentResult, TopicDescription, NumberOfAwardedMarks, NumberOfPossibleMarks)
                //VALUES(4, 7, 'PYP 567744', '2016-11-11', '2016-11-17', 52, 100, '100%', 2, 'Python Certificate', 0, 0)
                //GO

                //INSERT INTO MarksPerTopics(CertificateId, Topic1, Topic2, Topic3, Topic4)
                //VALUES(SCOPE_IDENTITY(), 12, 10, 20, 10)
                //GO


                //INSERT INTO Certificates(TypeOfCertificate, CandidateId, AssesmentTestCode, ExaminationDate, ScoreReportDate, CandidateScore,
                //                          MaximumScore, PercentageScore, AssesmentResult, TopicDescription, NumberOfAwardedMarks, NumberOfPossibleMarks)
                //VALUES(2, 7, 'CSP 448991', '2019-02-22', '2019-02-26', 60, 100, '100%', 2, 'C# Certificate', 0, 0)
                //GO

                //INSERT INTO MarksPerTopics(CertificateId, Topic1, Topic2, Topic3, Topic4)
                //VALUES(SCOPE_IDENTITY(), 10, 5, 25, 20)
                //GO
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Something not working with AddCertificates Method!");
                }
            }
        }
    }
}
