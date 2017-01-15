using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ZrrUniversity.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ZrrUniversity.DataAccessLayer
{
    public class UniversityContext : DbContext
    {
        public UniversityContext() :base("UniversityContext")
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}