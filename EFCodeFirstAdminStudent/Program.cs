using EFCodeFirstAdminStudent.Data.Services;
using MyModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstAdminStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext appDbContext = new AppDbContext();
            appDbContext.Candidates.Add(new Candidate{
                FirstName = "Alekos",
                LastName = "Papas",
                Email = "ale@papas.com"
            });
        }
    }
}
