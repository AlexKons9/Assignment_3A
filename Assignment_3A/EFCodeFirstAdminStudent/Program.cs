using EFCodeFirstAdminStudent.Data.Services;
using EFCodeFirstAdminStudent.Services;
using PdfCertificateMaker.Services;
using MyModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ConsoleAppMenu.Services;

namespace EFCodeFirstAdminStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdminService adminService = new AdminService();
            CandidateService candidateService = new CandidateService();
            ConsoleAppService consoleAppService = new ConsoleAppService();
            consoleAppService.GenerateConsoleForApp(args, adminService, candidateService);
        }
    }
}
