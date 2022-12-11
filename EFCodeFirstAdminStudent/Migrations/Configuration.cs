namespace EFCodeFirstAdminStudent.Migrations
{
    using MyModels.Models;
    using System;
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

            // Add Photo Id Types
            AddPhotoIdTypes();

            // Add Certificate Types
            AddCertificateTypes();

            // Add Gender Types
            AddGenderTypes();

            // Add Some Candidates
            AddCandidates();



            
            void AddPhotoIdTypes()
            {
                try
                {
                    if (context.PhotoIdTypes.Where(t => t.Type == "National Card").Count() == 0 &&
                        context.PhotoIdTypes.Where(t => t.Type == "Passport").Count() == 0)
                    {
                        context.PhotoIdTypes.Add(new PhotoIdType{ Type = "National Card" });
                        context.PhotoIdTypes.Add(new PhotoIdType { Type = "Passport" });
                        context.PhotoIdTypes.Add(new PhotoIdType { Type = "Javascript" });
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
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Something not working with AddGenderOptions Method!");
                }
            }

            void AddCandidates()
            {
                try
                {
                    if (!context.Candidates.Any()) 
                    {
                        context.Candidates.Add(new Candidate 
                        {
                            FirstName = "Alexandros",
                            MiddleName = "Nikolaos",
                            LastName = "Lepeniotis",
                            Gender = context.Genders.Where(x => x.GenderType== "Male").SingleOrDefault(),
                            NativeLanguage = "Greek",
                            BirthDate = new DateTime(1992,02,02),
                            PhotoIdType = context.PhotoIdTypes.Where(x => x.Type == "National Card").SingleOrDefault(),
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
                            Gender = context.Genders.Where(x => x.GenderType == "Male").SingleOrDefault(),
                            NativeLanguage = "Greek",
                            BirthDate = new DateTime(1998,01,01),
                            PhotoIdType = context.PhotoIdTypes.Where(x => x.Type == "National Card").SingleOrDefault(),
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
                            Gender = context.Genders.Where(x => x.GenderType == "Male").SingleOrDefault(),
                            NativeLanguage = "Greek",
                            BirthDate = new DateTime(1980, 05, 12),
                            PhotoIdType = context.PhotoIdTypes.Where(x => x.Type == "National Card").SingleOrDefault(),
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
                            Gender = context.Genders.Where(x => x.GenderType == "Female").SingleOrDefault(),
                            NativeLanguage = "Greek",
                            BirthDate = new DateTime(1972, 12, 12),
                            PhotoIdType = context.PhotoIdTypes.Where(x => x.Type == "Passport").SingleOrDefault(),
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
                            Gender = context.Genders.Where(x => x.GenderType == "Male").SingleOrDefault(),
                            NativeLanguage = "Greek",
                            BirthDate = new DateTime(1970, 05, 12),
                            PhotoIdType = context.PhotoIdTypes.Where(x => x.Type == "National Card").SingleOrDefault(),
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
                            Gender = context.Genders.Where(x => x.GenderType == "Male").SingleOrDefault(),
                            NativeLanguage = "Greek",
                            BirthDate = new DateTime(1999, 02, 03),
                            PhotoIdType = context.PhotoIdTypes.Where(x => x.Type == "Passport").SingleOrDefault(),
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
                            Gender = context.Genders.Where(x => x.GenderType == "Female").SingleOrDefault(),
                            NativeLanguage = "Greek",
                            BirthDate = new DateTime(1999, 01, 11),
                            PhotoIdType = context.PhotoIdTypes.Where(x => x.Type == "National Card").SingleOrDefault(),
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
                            Gender = context.Genders.Where(x => x.GenderType == "Female").SingleOrDefault(),
                            NativeLanguage = "Greek",
                            BirthDate = new DateTime(2000, 01, 02),
                            PhotoIdType = context.PhotoIdTypes.Where(x => x.Type == "National Card").SingleOrDefault(),
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
                            Gender = context.Genders.Where(x => x.GenderType == "Female").SingleOrDefault(),
                            NativeLanguage = "Greek",
                            BirthDate = new DateTime(1987, 03, 03),
                            PhotoIdType = context.PhotoIdTypes.Where(x => x.Type == "Passport").SingleOrDefault(),
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
                            Gender = context.Genders.Where(x => x.GenderType == "Male").SingleOrDefault(),
                            NativeLanguage = "English",
                            BirthDate = new DateTime(1960, 12, 03),
                            PhotoIdType = context.PhotoIdTypes.Where(x => x.Type == "Passport").SingleOrDefault(),
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
                    }


                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Something not working with AddGenderOptions Method!");
                }
            }
        }
    }
}
