using StudentSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using StudentSystem.Data;

namespace StudentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

                do
                {
                 AppStudentOrCourse.menuDisplay();
                string input = Console.ReadLine();
                if (input=="1")
                {
                    AppStudentOrCourse.createStudnet();
                }
                else if(input=="2")
                {
                    AppStudentOrCourse.createCourse();
                }
                else if(input=="3")
                {
                    Console.WriteLine("thank you");
                    break;
                }
                else
                {
                    Console.WriteLine("unknown input , please write a correct input");
                }

                } while (true);





        }
    }
}
