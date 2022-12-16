using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoUniversityReal.Models;

namespace ContosoUniversityReal.Data
{
    public class ContosoUniversityRealContext : DbContext
    {
        public ContosoUniversityRealContext (DbContextOptions<ContosoUniversityRealContext> options)
            : base(options)
        {
        }

        public DbSet<ContosoUniversityReal.Models.Student> Student { get; set; } = default!;
        public DbSet<ContosoUniversityReal.Models.Course> Course { get; set; } = default!;
        public DbSet<ContosoUniversityReal.Models.Enrollment> Enrollment { get; set; } = default!;
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<CourseAssignment> CourseAssignments { get; set; }

    }
}
