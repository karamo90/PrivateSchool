using Project.Core.Entities;
using Project.View.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.View.Students
{
    class ViewCourse
    {
        public static void PrintCourses(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{new string('-', 62)}{"All the entities of the Courses"}{new string('-', 62)}");
            Console.WriteLine(new string('-', 155));
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{"ID",-10}{"Title",-18}{"Stream",-16}{"Type",-17}{"Start Date",-20}{"End Date",-25}{"Description",-15}");
            Console.ResetColor();
            Console.WriteLine(new string('-', 155));
            foreach (var cou in courses)
            {
                Console.WriteLine($"{cou.ID,-10}{cou.Title,-18}{cou.Stream,-15}{cou.Type,-18}{cou.Start_Date.ToString("dd-MM-yyyy"),-20}{cou.End_Date.ToString("dd-MM-yyyy"),-25}{cou.Description,-15}");
                Console.WriteLine(new string('-', 155));
            }
        }
        public static Course CreateCourse()
        {
            //Title of new Course

            string title = HelperClassInputText.InputTextTitles("Type Course's Title----> ex:Python");
            Console.WriteLine();

            //Stream of new Course

            string stream = HelperClassInputText.InputTextStreams("Type Course's Stream----> ex:CB#15");
            Console.WriteLine();

            //Type of new Course
            string type = "";
            string choice = "";
            do
            {

                Console.WriteLine("Please choose the Type of the new Course:");
                Console.WriteLine("1 for FullTime and 2 for PartTime");
                choice = Console.ReadLine();
                Console.WriteLine();
                switch (choice)
                {
                    case "1": type = "Fulltime"; break;
                    case "2": type = "PartTime"; break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please Type 1 or 2 depending on your choice--->1-FullTime, 2-PartTime");
                        Console.ResetColor(); break;

                }

            } while (choice != "1" && choice != "2");


            //Description of new Course

            string description = HelperClassInputText.InputTextDescription("Type Course's Description");
            Console.WriteLine();

            do
            {
                bool condition;
                // Start Date of new Course

                DateTime startDate = HelperClassInputDate.InputDate("Type Course's Starting Date--->YEAR-MONTH-DAY ex:2021-12-10 or MONTH-DAY-YEAR ex:12-10-2021");
                Console.WriteLine();

                //End Date of new Course

                DateTime endDate = HelperClassInputDate.InputDate("Type Course's Ending Date--->YEAR-MONTH-DAY ex:2021-12-10 or MONTH-DAY-YEAR ex:12-10-2021--Must be after Start Date");
                Console.WriteLine();
                condition = startDate < endDate;
                if (condition)
                {
                    Course cour = new Course(0, title, stream, type, startDate, endDate, description);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("If you wish to create another Course press 2 Again or enter to another Menu");
                    Console.ResetColor();
                    return cour;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Start Date must be after End Date ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please Input a valid Date");
                    Console.ResetColor();
                }

            } while (true);

        }


        public static void PrintStudentsPerCourse(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{new string('-', 40)}{"All the Students Per Course"}{new string('-', 40)}");
            Console.WriteLine();
            Console.ResetColor();
            Console.ResetColor();
            Console.WriteLine(new string('-', 107));

            foreach (var cou in courses)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"{"ID",-15}{"Title",-15}{"Stream",-15}{"Type",-15}");
                Console.ResetColor();
                Console.WriteLine();

                Console.WriteLine($"{cou.ID,-15}{cou.Title,-15}{cou.Stream,-15}{cou.Type,-15}");
                foreach (var stu in cou.Student)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{"",-60}{"ID",-15}{"First name",-15}{"Last Name",-15}");
                    Console.WriteLine($"{new string(' ', 60)}{new string('-', 47)}");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine($"{"",-60}{stu.ID,-15}{stu.FirstName,-15}{stu.Lastname,-15}");
                    Console.WriteLine();

                    Console.ResetColor();


                }
                Console.WriteLine(new string('-', 107));

            }

        }
        public static void PrintTrainersPerCourse(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{new string('-', 40)}{"All the Trainers Per Course"}{new string('-', 40)}");
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ResetColor();
            Console.WriteLine(new string('-', 107));

            foreach (var cou in courses)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"{"ID",-15}{"Title",-15}{"Stream",-15}{"Type",-15}");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine($"{cou.ID,-15}{cou.Title,-15}{cou.Stream,-15}{cou.Type,-15}");
                foreach (var tra in cou.Trainer)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{"",-62}{"ID",-15}{"First name",-15}{"Last Name",-15}");
                    Console.WriteLine($"{new string(' ', 62)}{new string('-', 45)}");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine($"{"",-62}{tra.ID,-15}{tra.FirstName,-15}{tra.Lastname,-15}");
                    Console.WriteLine();

                    Console.ResetColor();


                }
                Console.WriteLine(new string('-', 107));

            }


        }
        public static void PrintAssignmentsPerCourse(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{new string('-', 60)}{"All the Assignments Per Course"}{new string('-', 60)}");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine(new string('-', 150));

            foreach (var cou in courses)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{"ID",-15}{"Title",-15}{"Stream",-15}{"Type",-15}");
                Console.WriteLine();
                Console.ResetColor();

                Console.WriteLine($"{cou.ID,-15}{cou.Title,-15}{cou.Stream,-15}{cou.Type,-15}");
                foreach (var assi in cou.Assignment)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{"",-60}{"ID",-10}{"Title",-25}{"Submission Date",-25}{"Oral Mark",-15}{"Total Mark",-15}");
                    Console.WriteLine($"{new string(' ', 60)}{new string('-', 90)}");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine($"{"",-60}{assi.ID,-10}{assi.Title,-25}{assi.SubDateTime.ToString("dd-MM-yyyy"),-25}{assi.OralMark,-15}{assi.TotalMark,-15}");
                    Console.WriteLine();

                    Console.ResetColor();


                }
                Console.WriteLine(new string('-', 150));

            }


        }

    }
}

