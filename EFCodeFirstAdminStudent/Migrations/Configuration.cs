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

            void AddGenderTypes ()
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
        }
    }
}
