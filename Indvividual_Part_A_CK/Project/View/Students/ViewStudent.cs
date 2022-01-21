using Project.Core.Entities;
using Project.View.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.View.Students
{
    class ViewStudent
    {
        

        public static void PrintStudents(List<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{new string('-', 45)}{"All the entities of the Students"}{new string('-', 45)}");
            Console.WriteLine(new string('-', 122));
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"ID",-20}{"Firstname",-25}{"Lastname",-23}{"Date of Birth",-28}{"Tutition Fees",-25}");
            Console.ResetColor();
            Console.WriteLine(new string('-', 122));
            foreach (var stu in students)
            {
                Console.WriteLine($"{stu.ID,-20}{stu.FirstName,-25}{stu.Lastname,-25}{stu.DateOfBirth.ToString("dd-MM-yyyy"),-28}{stu.TutitionFees,-25}");
                Console.WriteLine(new string('-', 122));
            }
        }
        public static Student CreateStudent()
        {
            //Firstname of New Student

            string firstName = HelperClassInputText.InputTextNames("Type Student's First Name----> ex:Christos");
            Console.WriteLine();

            //Lastname of New Student
            
            string lastName = HelperClassInputText.InputTextNames("Type Student's Last Name----> ex:Karamolegkos");
            Console.WriteLine();

            //DateOfBirth of New Student
            
            DateTime dateOfBirth = HelperClassInputDate.InputDate("Type Student's Date of Birth---->YEAR-MONTH-DAY ex:1990-06-17 or MONTH-DAY-YEAR ex:06-17-1990");
            Console.WriteLine();

            //Tutition Fees of New Student
            do
            {
                int tutitionFees = HelperClassInputNumber.InputNumber("Type Student's Tutition Fees which must be more than 0 and at Most 20000"); ;
                Console.WriteLine();
                if (tutitionFees > 0 && tutitionFees <= 20000)
                {
                    Student stud = new Student(0, firstName, lastName, dateOfBirth, tutitionFees);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("If you wish to create another Student press 1 Again or enter to another Menu");
                    Console.ResetColor();
                    return stud;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tutition Fees must be more than 0 and at most 20000");
                    Console.ResetColor();
                }
                
            } while (true);

        }

        public static void PrintAssignmentsPerStudent(List<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{new string('-', 27)}{"All the Assignments Per Students"}{new string('-', 27)}");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine(new string('-', 86));
            
            foreach (var stu in students)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"{"ID",-15}{"Firstname",-20}{"Lastname",-20}");
                Console.ResetColor();

                Console.WriteLine();
                Console.WriteLine($"{stu.ID,-15}{stu.FirstName,-20}{stu.Lastname,-20}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{"",-65}{"Title",-15}");
                Console.ResetColor();
                Console.WriteLine($"{new string(' ', 58)}{new string('-', 22)}");

                foreach (var assi in stu.Assignment)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{"",-60}{assi.Title,-15}");
                    Console.ResetColor();
                    Console.WriteLine($"{new string(' ', 58)}{new string('-', 22)}");
                    
                }
                Console.WriteLine(new string('-', 86));

            }
        }
        public static void PrintAllStudentsThatBelongToMoreThanOneCourse(List<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{new string('-', 24)}{"All the Students that belong to more than one Course"}{new string('-', 24)}");
            Console.WriteLine();
            Console.ResetColor();
            foreach (var stu in students)
            {
               
                if (stu.Course.Count > 1)
                {    
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{"ID",-15}{"Firstname",-15}{"Lastname",-15}");
                    Console.ResetColor();
                    Console.WriteLine(new string('-', 100));
                    Console.WriteLine($"{stu.ID,-15}{stu.FirstName,-15}{stu.Lastname,-35}");

                }

                foreach (var cou in stu.Course)
                {
                   
                    if (stu.Course.Count > 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;

                        Console.WriteLine($"{new string(' ', 70)}{"Course"}");
                        Console.ResetColor();
                        Console.WriteLine($"{new string(' ', 67)}{new string('-', 12)}");
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine($"{"",-60}{"ID",-25}{"Title",-15}");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.WriteLine($"{"",-60}{cou.ID,-25}{cou.Title,-15}");
                        Console.WriteLine();

                        Console.ResetColor();
                        Console.WriteLine($"{new string(' ',60)}{new string('-',40)}");


                    }
                }
            }
        }
        

    }
}
