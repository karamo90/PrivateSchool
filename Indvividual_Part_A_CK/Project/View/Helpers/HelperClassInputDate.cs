using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.View.Helpers
{
    //Helper class for Input-Dates
    class HelperClassInputDate
    {
         public static DateTime InputDate(string placeholder)
        {
            do
            {
                try
                {
                    Console.WriteLine(placeholder);
                    DateTime result = Convert.ToDateTime(Console.ReadLine());
                    return result;
                }
                catch (Exception )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong Input of Date so you have to Type Again");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The validate input of Date is Year-Month-Day ex: 2021-12-10 or Month-Day-Year ex:12-10-21");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            } while (true);
            
        }
       
            
        }
    }

