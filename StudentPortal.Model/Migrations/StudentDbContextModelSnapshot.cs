﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StudentPortal.Model.Context;

namespace StudentPortal.Model.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    partial class StudentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("StudentPortal.Model.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CourseName")
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.HasKey("CourseId");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CourseName = "OOP",
                            Location = "Campus"
                        });
                });

            modelBuilder.Entity("StudentPortal.Model.Models.Enrollment", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("EnrollmentID")
                        .HasColumnType("integer");

                    b.Property<int>("TeacherId")
                        .HasColumnType("integer");

                    b.HasKey("CourseId", "StudentId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Enrollment");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            StudentId = 1,
                            Date = new DateTime(2021, 11, 4, 23, 3, 13, 90, DateTimeKind.Local).AddTicks(3640),
                            EnrollmentID = 1,
                            TeacherId = 1
                        });
                });

            modelBuilder.Entity("StudentPortal.Model.Models.Standard", b =>
                {
                    b.Property<int>("StandardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("StandardCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("StandardDesc")
                        .HasColumnType("text");

                    b.Property<string>("StandardName")
                        .HasColumnType("text");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.Property<int>("TeacherId")
                        .HasColumnType("integer");

                    b.HasKey("StandardId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Standard");

                    b.HasData(
                        new
                        {
                            StandardId = 1,
                            StandardCode = 1,
                            StandardDesc = "abc",
                            StandardName = "standard",
                            StudentId = 1,
                            TeacherId = 1
                        });
                });

            modelBuilder.Entity("StudentPortal.Model.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<float>("Marks1")
                        .HasColumnType("real");

                    b.Property<float>("Marks2")
                        .HasColumnType("real");

                    b.Property<float>("Marks3")
                        .HasColumnType("real");

                    b.Property<int>("StandardId")
                        .HasColumnType("integer");

                    b.Property<string>("StudentName")
                        .HasColumnType("text");

                    b.Property<string>("StudentPhone")
                        .HasColumnType("text");

                    b.HasKey("StudentId");

                    b.HasIndex("StudentName")
                        .IsUnique();

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Marks1 = 70.9f,
                            Marks2 = 80f,
                            Marks3 = 90.8f,
                            StandardId = 1,
                            StudentName = "Rasba",
                            StudentPhone = "0123456"
                        });
                });

            modelBuilder.Entity("StudentPortal.Model.Models.StudentAddress", b =>
                {
                    b.Property<int>("StandardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<string>("StudentAddress1")
                        .HasColumnType("text");

                    b.Property<string>("StudentAddress2")
                        .HasColumnType("text");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.HasKey("StandardId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentAddress");

                    b.HasData(
                        new
                        {
                            StandardId = 1,
                            City = "Karachi",
                            State = "",
                            StudentAddress1 = "Pechs",
                            StudentAddress2 = "block 6",
                            StudentId = 1
                        });
                });

            modelBuilder.Entity("StudentPortal.Model.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("StandardId")
                        .HasColumnType("integer");

                    b.Property<string>("TeacherName")
                        .HasColumnType("text");

                    b.Property<string>("TeacherType")
                        .HasColumnType("text");

                    b.HasKey("TeacherId");

                    b.ToTable("Teacher");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            StandardId = 1,
                            TeacherName = "XYZ",
                            TeacherType = "Sci"
                        });
                });

            modelBuilder.Entity("StudentPortal.Model.Models.Enrollment", b =>
                {
                    b.HasOne("StudentPortal.Model.Models.Course", "Course")
                        .WithMany("Enrollment")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentPortal.Model.Models.Student", "Student")
                        .WithMany("Enrollment")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentPortal.Model.Models.Teacher", "Teacher")
                        .WithMany("Enrollment")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentPortal.Model.Models.Standard", b =>
                {
                    b.HasOne("StudentPortal.Model.Models.Student", "Student")
                        .WithMany("Standards")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentPortal.Model.Models.Teacher", "Teacher")
                        .WithMany("Standards")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentPortal.Model.Models.StudentAddress", b =>
                {
                    b.HasOne("StudentPortal.Model.Models.Student", "Student")
                        .WithMany("StudentAddress")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
