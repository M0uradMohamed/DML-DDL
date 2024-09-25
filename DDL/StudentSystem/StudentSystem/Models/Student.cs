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


        public void enterStudentName()
        {
            Console.WriteLine("--------------------------------------------");
            Console.Write("Enter student full name : ");
            Name = Console.ReadLine();
        }

        public void enterStudentPhone()
        {
            do
            {

                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Enter student phone exaclly 10 numbers : ");

                string number = Console.ReadLine();
                if (number.Length == 10)
                {
                    PhoneNumber = number;
                    break;
                }
                else
                {

                    Console.WriteLine("--------------------------------------------");
                   Console.WriteLine("this phone number is not 10 chars length");

                }
            } while (true);
        }

        public void enterBirthday()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("birthday");
            do
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("enter 1 to enter a birthday");
                Console.WriteLine("enter 2 to enter skip this step");
                string input = Console.ReadLine();
                if(input =="1")
                {
                    int year;
                    int month;
                    int day;

                    do
                    {
                        Console.WriteLine("enter the year");
                            year = int.Parse(Console.ReadLine());

                        if(year< DateTime.Now.Year && year>=1000)
                        { 
                            break;
                        }
                        else
                        {
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("please enter a correct year");
                        }
                    } while (true);
                    do
                    {
                        Console.WriteLine("enter the month");
                        month = int.Parse(Console.ReadLine());

                        if (month >=1 && month <= 12)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("please enter a correct month");
                        }
                    } while (true);
                    do
                    {
                        Console.WriteLine("enter the day");
                        day = int.Parse(Console.ReadLine());

                        if (day>=1 && day <= 31)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("please enter a correct day");
                        }
                    } while (true);


                    Birthday = new DateTime(year, month, day);
                    Console.WriteLine($"birth :{Birthday}");

                    break;
                }
                else if(input =="2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("unknown input , please write a correct input");
                }
            }while (true);
            
            
        }

    }
}
