using ConsoleTools;
using EFCodeFirstAdminStudent.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMenu.Services
{
    internal class ConsoleAppService
    {

        public void GenerateConsoleForApp(string[] args, AdminService adminService, CandidateService candidateService)
        {
            
            // Console Menu
            var adminMenu = new ConsoleMenu(args, level: 2)
                            .Add("Create a Candidate Entry", () => adminService.CreateCandidate())
                            .Add("Read a Candidate Entry", () => adminService.ReadCandidate())
                            .Add("Read all Candidates Entries", () => adminService.ReadAllTheCandidates())
                            .Add("Update a Candidate Entry", () => adminService.UpdateCandidate())
                            .Add("Delete a Candidate Entry", () => adminService.RemoveCandidate())
                            .Add("Show Exam Results of a Candidate", () => adminService.ReadCandidateExamsResults())
                            .Add("Show Exam Results of all Candidates", () => adminService.ReadAllCadidatesExamsResults())
                            .Add("Return_Back", ConsoleMenu.Close)
                            .Configure(config =>
                            {
                                config.Selector = "--> ";
                                config.EnableFilter = false;
                                config.Title = "Admin Menu";
                                config.EnableBreadcrumb = true;
                                config.WriteBreadcrumbAction = titles => Console.WriteLine(string.Join(" / ", titles));
                            });


            var candidateMenu = new ConsoleMenu(args, level: 1)
                            .Add("Show list of my Certificates", () => candidateService.ReadCandidateCertificates())
                            .Add("Export and Download my Certificate", () => candidateService.ExtractCertificatePdf())
                            .Add("Return_Back", ConsoleMenu.Close)
                            .Configure(config =>
                            {
                                config.Selector = "--> ";
                                config.EnableFilter = false;
                                config.Title = "Candidate Menu";
                                config.EnableBreadcrumb = true;
                                config.WriteBreadcrumbAction = titles => Console.WriteLine(string.Join(" / ", titles));
                            });


            var mainMenu = new ConsoleMenu(args, level: 0)
                            .Add("Sign in as Admin", () => adminMenu.Show())
                            .Add("Sign in as Candidate", () => candidateMenu.Show())
                            .Add("Exit", () => Environment.Exit(0))
                            .Configure(config =>
                            {
                                config.Selector = "--> ";
                                config.EnableFilter = false;
                                config.Title = "Main menu";
                                config.EnableWriteTitle = false;
                                config.EnableBreadcrumb = true;
                            });

            mainMenu.Show();

        }
    }
}
