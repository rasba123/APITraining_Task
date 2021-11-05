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
        public virtual DbSet<Enrollment> Enrollment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {//compositekey
            modelBuilder.Entity<Enrollment>()
       .HasKey(c => new { c.CourseId, c.StudentId });
            //index
            modelBuilder.Entity<Student>()
    .HasIndex(p => p.StudentName)
    .IsUnique();
            // autogeneration
            modelBuilder.Entity<Standard>()
            .Property(f => f.StandardCode)
            .ValueGeneratedOnAdd();

            
            //DataSeeding
            modelBuilder.Entity<Student>().HasData(
    new { StudentId = 1, StudentName = "Rasba", StandardId = 1, StudentPhone = "0123456" , Marks1 = 70.9f , Marks2 = 80.0f , Marks3 = 90.8f }
  );

        modelBuilder.Entity<Standard>().HasData(
   new { StandardId = 1, StandardCode = 1, StudentId = 1, TeacherId = 1, StandardName = "standard", StandardDesc="abc" });
           
            
            modelBuilder.Entity<Course>().HasData(
           new { CourseId = 1, CourseName = "OOP", Location = "Campus" });

            modelBuilder.Entity<StudentAddress>().HasData(
          new { StudentId = 1, StandardId = 1, StudentAddress1 = "Pechs", StudentAddress2 = "block 6", City = "Karachi", State = "" });

            modelBuilder.Entity<Teacher>().HasData(
          new { TeacherId = 1, TeacherName = "XYZ", StandardId = 1, TeacherType = "Sci" });
        
        modelBuilder.Entity<Enrollment>().HasData(
          new { StudentId = 1, CourseId = 1, EnrollmentID = 1,Date=DateTime.Now, TeacherId = 1 });

    }
    }
}
