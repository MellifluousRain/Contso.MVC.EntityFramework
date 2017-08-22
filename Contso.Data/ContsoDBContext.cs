using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contso.Model;

namespace Contso.Data
{
    public class ContsoMVC : DbContext 
    {
        public ContsoMVC()
        {

        }
        public DbSet<People> People { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Enrollments> Enrollments { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<OfficeAssignments> OfficeAssignments { get; set; }
        public DbSet<Roles> Roles { get; set; }

        

    }
}
