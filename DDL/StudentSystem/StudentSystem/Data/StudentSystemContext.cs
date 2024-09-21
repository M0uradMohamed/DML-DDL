using Microsoft.EntityFrameworkCore;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Data
{
    public partial class StudentSystemContext : DbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses {  get; set; }
        public DbSet<Resource> resources { get; set; }
        public DbSet<Homework> homeworks { get; set; }
        public DbSet<StudentCourse> studentsCourses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentSystem;Integrated Security=True;TrustServerCertificate=True");
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>(s =>
            {
                s.Property(s => s.Name).HasColumnType("Nvarchar(100)").IsRequired();
                s.Property(s => s.PhoneNumber).HasMaxLength(10).IsUnicode(false);

                s.HasCheckConstraint("ch_phoneNumberLength", "LEN(PhoneNumber) = 10");

            });

            modelBuilder.Entity<Course>(c =>
            {
                c.Property(c => c.Name).HasMaxLength(80).IsUnicode().IsRequired();
                c.Property(c => c.Description).IsUnicode().IsRequired(false);
            });

            modelBuilder.Entity<Resource>(r =>
            {
                r.Property(r => r.Name).HasMaxLength(50).IsUnicode();
                r.Property(r => r.Url).IsUnicode(false);
            });
            modelBuilder.Entity<Homework>().Property(h => h.Content).IsUnicode(false);

            modelBuilder.Entity<Student>().HasMany(s => s.Courses).WithMany(c => c.Students)
                .UsingEntity<StudentCourse>().HasKey(j => new { j.StudentId, j.CourseId });

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    Name = "ahmed mohamed",
                    PhoneNumber = "0236789066",
                    Birthday = new DateTime(1995, 2, 16),
                    RegisteredOn = new DateTime(2024, 6, 19)
                },
                new Student
                {
                    StudentId = 2,
                    Name = "moahmed abdo",
                    PhoneNumber = "1705454135",
                    Birthday = new DateTime(1999, 8, 27),
                    RegisteredOn = new DateTime(2024,2,9)
                },
                new Student
                {
                    StudentId = 3,
                    Name = "mohsen ali",
                    PhoneNumber = "1210648789",
                    Birthday = new DateTime(1998, 5, 30),
                    RegisteredOn = new DateTime(2024,5, 31)
                }

            );

            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    CourseId = 1,
                    Name = ".net",
                    Description = "back end programing",
                    StartDate = new DateTime(2024 / 10 / 17),
                    EndDate = new DateTime(2025 / 4 / 5),
                    Price = 5000,
                },
                new Course
                {
                    CourseId = 2,
                    Name = "ux ui",
                    Description = "front end programing",
                    StartDate = new DateTime(2024 / 11 / 9),
                    EndDate = new DateTime(2025 / 5 / 2),
                    Price = 4500,
                },
                new Course
                {
                    CourseId = 3,
                    Name = "intro",
                    Description = "basic programing",
                    StartDate = new DateTime(2024 / 11 / 15),
                    EndDate = new DateTime(2025 / 5 / 13),
                    Price = 1500,
                }
            );
            modelBuilder.Entity<Resource>().HasData(
                new Resource
                {
                    ResourceId = 1,
                    Name = "jonny",
                    ResourceType = ResourceType.Video,
                    Url="www.eraasoft.com",
                    CourseId= 1
                },
                new Resource
                {
                    ResourceId = 2,
                    Name = "tom",
                    ResourceType = ResourceType.Document,
                    Url = "www.microsoft.com",
                    CourseId=3
                },
                new Resource
                {
                    ResourceId = 3,
                    Name = "sam",
                    ResourceType = ResourceType.Presentation,
                    Url = "www.amazon.com",
                    CourseId=3
                },
                new Resource
                {
                    ResourceId = 4,
                    Name = "keano",
                    ResourceType = ResourceType.Other ,
                    Url = "www.steam.com",
                    CourseId=2
                }
            );
            modelBuilder.Entity<Homework>().HasData(
                new Homework
                {
                    HomeworkId = 1,
                    Content = "problem solving",
                    ContentType = ContentType.Application,
                    SubmissionTime = new DateTime(2024, 11, 5),
                    StudentId = 2,
                    CourseId = 3
                    
                },
                new Homework
                {
                    HomeworkId = 2,
                    Content = "ef core",
                    ContentType = ContentType.Pdf,
                    SubmissionTime = new DateTime(2024, 11, 12),
                    StudentId= 3,
                    CourseId= 2 
                },
                new Homework
                {
                    HomeworkId = 3,
                    Content = "designing",
                    ContentType = ContentType.Zip,
                    SubmissionTime = new DateTime(2024, 12, 3),
                    StudentId =1,
                    CourseId= 2
                 
                },
                new Homework
                {
                    HomeworkId = 4,
                    Content = "oop",
                    ContentType = ContentType.Application,
                    SubmissionTime = new DateTime(2024, 11, 27),
                    StudentId=2,
                    CourseId= 1
                    
                });
              modelBuilder.Entity<StudentCourse>().HasData(
                new StudentCourse { StudentId = 1, CourseId = 2 },
                new StudentCourse { StudentId = 1, CourseId = 3 },
                new StudentCourse { StudentId = 2, CourseId = 3 },
                new StudentCourse { StudentId = 2, CourseId = 1 },
                new StudentCourse { StudentId = 3, CourseId = 2 }
                );
        }

    }
}
