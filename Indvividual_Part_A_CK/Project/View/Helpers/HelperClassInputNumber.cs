using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.View.Helpers
{
    //Helper Class for Input-Numbers
    class HelperClassInputNumber
    {
        public static int InputNumber(string placeholder)
        {
            do
            {
                try
                {
                    Console.WriteLine(placeholder);
                    int result = Convert.ToInt32(Console.ReadLine());
                    return result;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong Input of Number so you have to Type Again");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The validate input of Number is ex:2300");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            } while (true);

        }
    }
}
