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
        public virtual DbSet<Enrollment> Enrollment { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Student>().HasData(
        //        new Student() { StudentId = 1, StudentName = "John", StudentPhone = "Developer" },
        //         new Student() { StudentId = 2, StudentName = "John", StudentPhone = "Developer" },
        //          new Student() { StudentId = 3, StudentName = "John", StudentPhone = "Developer" });
        //}
    }
}
