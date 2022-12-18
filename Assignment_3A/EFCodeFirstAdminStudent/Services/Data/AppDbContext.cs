using System;
using MyModels.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace EFCodeFirstAdminStudent.Data.Services
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<PhotoIdType> PhotoIdTypes { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<CertificateType> CertificateTypes { get; set; }
        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<MarkPerTopic> MarkPerTopics { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }


        public AppDbContext(): base("name=MyConnectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Certificate>()
                .HasRequired<Candidate>(c => c.CandidateId).WithMany().WillCascadeOnDelete(true);

            modelBuilder.Entity<Exam>()
                .HasRequired<Candidate>(c => c.CandidateId).WithMany().WillCascadeOnDelete(true);

            modelBuilder.Entity<Exam>()
                .HasRequired<MarkPerTopic>(m => m.MarkPerTopic).WithRequiredPrincipal().WillCascadeOnDelete(true);
        }
    }
}
