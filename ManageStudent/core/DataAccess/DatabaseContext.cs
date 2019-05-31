using Microsoft.EntityFrameworkCore;
using StudentAPI.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.core.DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        DbSet<Student> Students { set; get; }

        DbSet<Class> Classes { set; get; }

        DbSet<Faculty> Faculties { set; get; }

        DbSet<Course> Courses { set; get; }

        DbSet<StudentInCourse> StudentInCourses { set; get; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
