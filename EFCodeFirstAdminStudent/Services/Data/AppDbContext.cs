using System;
using MyModels.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstAdminStudent.Data.Services
{
    internal class AppDbContext : DbContext
    {
        public DbSet<PhotoIdType> PhotoIdTypes { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public virtual DbSet<CertificateType> CertificateTypes { get; set; }
        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<MarkPerTopic> MarkPerTopics { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }


        public AppDbContext(): base("name=MyConnectionString")
        {

        }

    }
}
