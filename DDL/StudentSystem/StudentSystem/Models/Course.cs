using StudentSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Resource> Resources { get; set; }

        public void courseId(StudentSystemContext context)
        {
            var courseCount = context.students.Count();
            CourseId = courseCount + 1;
        }

        public void enterCourseName()
        {
            Console.Write("Enter course name : ");
            Name = Console.ReadLine();
        }

        public void enterDescription()
        {
            Console.Write("Enter course Description : ");
            Description = Console.ReadLine();
        }

        internal void enterEndDate()
        {
            Console.WriteLine("enter course end date");
            Console.WriteLine("enter the year");
                    int year = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the month");
                    int month = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the day");
                    int day = int.Parse(Console.ReadLine());
                    EndDate = new DateTime(year, month, day);
        }

        public void enterStartDate()
        {
            Console.WriteLine("enter course start date");
            Console.WriteLine("enter the year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the month");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the day");
            int day = int.Parse(Console.ReadLine());
            StartDate = new DateTime(year, month, day);
        }

        public void enterPrice()
        {
            Console.WriteLine("enter course prices");
            var result = AppStudentOrCourse.checkInt();
            Price = result.Item1;
        }
    }
}
