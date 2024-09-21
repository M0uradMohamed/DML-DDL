using Microsoft.EntityFrameworkCore;
using StudentSystem.Data;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    public static class AppStudentOrCourse
    {
       public static StudentSystemContext context = new StudentSystemContext();
        public static void menuDisplay()
        {
            Console.WriteLine("type (1) to enter a new student ");
            Console.WriteLine("type (2) to enter a new course ");
            Console.WriteLine("type (3) to exit ");
            Console.Write("your input : ");
        }

        public static void createStudnet()
        {
            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT students ON");

            var student = new Student();
                student.enterStudentId(context);
                student.enterStudentName();
                student.enterStudentPhone();
                student.RegisteredOn = DateTime.Now;
                student.enterBirthday();

                var studentcourse = new StudentCourse();
                do
                {
                    AppStudentOrCourse.displayCourses(context);

                    Console.WriteLine("enter (1) if you want to join a course ");
                    Console.WriteLine("enter (2) if you don't want to join any course ");
                    Console.Write("your input : ");
                    string input = Console.ReadLine();
                    if (input == "1")
                    {
                        AppStudentOrCourse.joincourse(studentcourse, context, student);
                        Console.WriteLine("course joined successfully");

                    }
                    else if (input == "2")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("unknown input");
                    }

                } while (true);

                context.students.Add(student);

     context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT students OFF");

            Console.WriteLine("student joined successfully");


        }

        public static void joincourse(StudentCourse studentcourse, StudentSystemContext context, Student student)
        {
            int courseId = student.enterCourseID(context);
            studentcourse.StudentId = student.StudentId;
            studentcourse.CourseId = courseId;

            context.studentsCourses.Add(studentcourse);
        }

        public static void displayCourses(StudentSystemContext context)
        {
            Console.WriteLine("course joining");
            var result = context.courses.ToList();
            foreach (var item in result)
            {
                Console.WriteLine($"course id : {item.CourseId} , course name: {item.Name }, course price = {item.Price}");
                Console.WriteLine($"course Description :{item.Description}");
            }
        }
        public static (int, bool) checkInt()
        {
            while (true)
            {
                int number = 0;
                try
                {
                    number = int.Parse(Console.ReadLine());
                    return (number, true);
                }
                catch (FormatException)
                {
                    Console.WriteLine("unknown input");
                    return (number, false);
                }
            }


        }

        public static void createCourse()
        {
            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT courses ON");

            var course = new Course();

            course.courseId(context);
            course.enterCourseName();
            course.enterDescription();
            course.enterStartDate();
            course.enterEndDate();
            course.enterPrice();

            context.courses.Add(course);

            Console.WriteLine("course add succefully");

            context.SaveChanges();
            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT courses ON");

        }
    }
}
