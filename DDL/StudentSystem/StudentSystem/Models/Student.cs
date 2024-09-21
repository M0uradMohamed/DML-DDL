using StudentSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateTime? Birthday { get; set; }

        public ICollection<Course> Courses { get; set; }
        public ICollection<Homework> Homeworks { get; set; }

        public  void enterStudentId( StudentSystemContext context)
        {
            var studentCount = context.students.Count();
            StudentId = studentCount+1;
        }

        public void enterStudentName()
        {
            Console.Write("Enter student full name : ");
            Name = Console.ReadLine();
        }

        public void enterStudentPhone()
        {
            do
            {
                Console.WriteLine("Enter student phone exaclly 10 numbers : ");

                string number = Console.ReadLine();
                if (number.Length == 10)
                {
                    PhoneNumber = number;
                    break;
                }
                else
                {
                    Console.WriteLine("this phone number is not 10 chars length");
                }
            } while (true);
        }

        public void enterBirthday()
        {
            Console.WriteLine("birthday");
            do
            {
                Console.WriteLine("enter 1 to enter a birthday");
                Console.WriteLine("enter 2 to enter skip this step");
                string input = Console.ReadLine();
                if(input =="1")
                {
                    Console.WriteLine("enter the year");
                    int year = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the month");
                    int month = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the day");
                    int day = int.Parse(Console.ReadLine());
                    Birthday = new DateTime(year, month, day);

                    break;
                }
                else if(input =="2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("unknown input , please write a correct input");
                }
            }while (true);
            
            
        }
        public int enterCourseID(StudentSystemContext context )
        {

            do
            {
                Console.Write("enter the wanted course id :");
                var checkCourseId = AppStudentOrCourse.checkInt();

                if(checkCourseId.Item1 >= 1 && checkCourseId.Item1<= context.courses.ToList().Count() )
                {
                    return checkCourseId.Item1;
                }
                else
                {
                    Console.WriteLine("out of course range");
                }
            }while (true);
        }
    }
}
