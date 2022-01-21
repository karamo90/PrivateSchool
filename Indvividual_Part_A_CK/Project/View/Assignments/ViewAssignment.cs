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
    class ViewAssignment
    {
        public static void PrintAssignments(List<Assignment> assignments)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"{new string('-', 77)}{"All the entities of the Assignments"}{new string('-', 78) }");
            Console.WriteLine(new string('-', 190));
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{"ID",-17}{"Title",-22}{"Oral Mark",-15}{"Total Mark",-18}{"Sub. Date Time",-47}{"Description",-15}");
            Console.ResetColor();
            Console.WriteLine(new string('-', 190));
            foreach (var assi in assignments)
            {
                Console.WriteLine($"{assi.ID,-17}{assi.Title,-25}{assi.OralMark,-15}{assi.TotalMark,-15}{assi.SubDateTime.ToString("dd-MM-yyyy"),-27}{assi.Description,-15}");
                Console.WriteLine(new string('-', 190));
            }
        }
        public static Assignment CreateAssignment()
        {
            //Title of new Assignment

            string title = HelperClassInputText.InputTextTitles("Type Assignment's Title----> ex:Loop Theory");
            Console.WriteLine();




            //Submission date of new Assignment

            DateTime subDate = HelperClassInputDate.InputDate("Type Assignment's SubmissionDate---->YEAR-MONTH-DAY ex:2021-12-10 or MONTH-DAY-YEAR ex:12-10-2021");
            Console.WriteLine();

            //Description of new Assignment

            string description = HelperClassInputText.InputTextDescription("Type Assignment's Description----> ex:This Assignment is about...");
            Console.WriteLine();
            do
            {
                //Oral Mark of new Assignment

                int oralMark = HelperClassInputNumber.InputNumber("Type Assignment's Oral Mark---> ex:20  Must be less than Total Mark and at most 100");
                Console.WriteLine();


                //Total Mark of new Assignment

                int totalMark = HelperClassInputNumber.InputNumber("Type Assignment's Total Mark--Must be more than Oral Mark and at Most 100");
                Console.WriteLine();
                if (oralMark <= totalMark && totalMark <= 100)
                {
                    Assignment assi = new Assignment(0, title, oralMark, totalMark, subDate, description);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("If you wish to create another Assignment press 4 Again or enter to another Menu");
                    Console.ResetColor();
                    return assi;
                }
                else
                {
                    Console.WriteLine("Oral Mark must be less than Total Mark and Total Mark must be at most 100");
                }
            } while (true);

        }
        public static void PrintAllTheAssignmentsPerStudentsOnSelectedWeek(List<Assignment> assignments)
        {
            Calendar calendar = CultureInfo.InvariantCulture.Calendar;
            DateTime week = HelperClassInputDate.InputDate("Give the day for which you want to check the Assignments on the same Calendar week-->YEAR-MONTH-DAY ex:2021-12-10 or MONTH-DAY-YEAR ex:12-10-2021");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NOTE:if there are no Assignments printed after you type the selected date please try another Date");
            Console.ResetColor();
            DateTime weekDate = week.Date.AddDays(-1 * (int)calendar.GetDayOfWeek(week));
            Console.WriteLine();           
            foreach (var assi in assignments)
            {
               
                DateTime weekDateSubTime = assi.SubDateTime.Date.AddDays(-1 * (int)calendar.GetDayOfWeek(assi.SubDateTime));


                if (weekDateSubTime == weekDate)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("The List of Students who need to submit one or more assignments on the same calendar week of your input Date are:");
                    Console.ResetColor();
                    Console.WriteLine(new string('-', 113));
                    Console.WriteLine();

                    foreach (var stu in assi.Students)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"{"FirstName",-20}{"Lastname",-20}{"Assignment",-25}{"Assignment's Sub Date",-15}");
                        Console.ResetColor();
                        Console.WriteLine(new string('-', 113));

                        Console.WriteLine($"{stu.FirstName,-20}{stu.Lastname,-20}{assi.Title,-25}{assi.SubDateTime.ToString("dd-MM-yyyy"),-15}");
                        Console.WriteLine(new string('-', 113));
                        Console.WriteLine();

                    }
                }
     
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("If you want to check another Date press 10 Again");
            Console.ResetColor();
        }
    }
}