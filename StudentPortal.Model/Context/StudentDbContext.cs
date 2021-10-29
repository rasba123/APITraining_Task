using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using StudentPortal.Model.Models;

namespace StudentPortal.Model.Context
{
    public class StudentDbContext: DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Standard> Standard { get; set; }
        public virtual DbSet<StudentAddress> StudentAddress { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>()
       .HasKey(c => new { c.CourseId, c.StudentId });
          
        }
    }
}
