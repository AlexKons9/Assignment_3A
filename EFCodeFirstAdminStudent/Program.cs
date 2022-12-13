using EFCodeFirstAdminStudent.Data.Services;
using EFCodeFirstAdminStudent.Services;
using MyModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EFCodeFirstAdminStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdminService adminService = new AdminService();
            //adminService.CreateCandidate();
            //adminService.UpdateCandidate();
            //adminService.ReadCandidate();
            //adminService.RemoveCandidate();

            adminService.ReadCandidateExamsResults();
            
        }
    }
}
