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
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("type (1) to enter a new student ");
            Console.WriteLine("type (2) to enter a new course ");
            Console.WriteLine("type (3) to exit ");
            Console.Write("your input : ");
        }

        public static void createStudnet()
        {

            var student = new Student();

                student.enterStudentName();
                student.enterStudentPhone();
                student.RegisteredOn = DateTime.Now;
                student.enterBirthday();

            context.students.Add(student);
            context.SaveChanges();


                do
                {
                    AppStudentOrCourse.displayCourses(context);

                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("enter (A) if you want to join a course ");
                    Console.WriteLine("enter (B) if you don't want to join any course ");
                    Console.Write("your input : ");
                    string input = Console.ReadLine();
                    if (input.ToLower() == "a")
                    {
                        AppStudentOrCourse.joincourse( context, student);
                        Console.WriteLine("course joined successfully");

                    }
                    else if (input.ToLower() == "b")
                    {
                        break;
                    }
                    else
                    {
                    Console.WriteLine("--------------------------------------------");

                    Console.WriteLine("unknown input");
                    }

                } while (true);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("student joined successfully");

            context.SaveChanges();


        }

        public static void joincourse( StudentSystemContext context, Student student)
        {
            StudentCourse studentcourse = new StudentCourse();

            int courseid = AppStudentOrCourse.enterCourseID(context);
            studentcourse.StudentId = student.StudentId;
            studentcourse.CourseId = courseid;

            context.studentsCourses.Add(studentcourse);
            context.SaveChanges();
        }

        public static void displayCourses(StudentSystemContext context)
        {
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("course joining");
            var result = context.courses.ToList();
            foreach (var item in result)
            {
                Console.WriteLine("--------------------------------------------");

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
                    Console.WriteLine("--------------------------------------------");

                    Console.WriteLine("unknown input");
                    return (number, false);
                }
            }


        }

        public static void createCourse()
        {

            var course = new Course();

            course.enterCourseName();
            course.enterDescription();
            course.enterStartDate();
            course.enterEndDate();
            course.enterPrice();

            context.courses.Add(course);

            Console.WriteLine("course add succefully");

            context.SaveChanges();

        }
      static public int enterCourseID(StudentSystemContext context)
        {

            do
            {
                Console.WriteLine("--------------------------------------------");
                Console.Write("enter the wanted course id :");
                var checkCourseId = AppStudentOrCourse.checkInt();

                if (checkCourseId.Item1 >= 1 && checkCourseId.Item1 <= context.courses.ToList().Count())
                {
                    return checkCourseId.Item1;
                }
                else
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("out of course range");
                }
            } while (true);
        }
    }
}
