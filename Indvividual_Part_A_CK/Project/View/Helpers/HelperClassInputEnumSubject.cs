using Project.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.View.Helpers
{
    //Helper Class for Input Enum-Subjects
    class HelperClassInputEnumSubject
    {
        public static Subject Subject(string placeholder)
        {
            do
            {
                try
                {
                    int Choice = Convert.ToInt32(Console.ReadLine());
                    if (Choice == 0 || Choice == 1 || Choice == 2)
                    {
                        Subject finalChoice = (Subject)Choice;
                        return finalChoice;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("please input a specific Number depending on your choice: 0 for Csharp, 1 for Python,2 for Java");
                        Console.ResetColor();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                
            } while (true);
            
            
        }
    }
}
