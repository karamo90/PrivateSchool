using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Ouput
{
    class ChristmasTree
    {
        //Christmas tree decoration
        public static void ChristmasTrees()
        {
            int spaces = 10;
            int asterix = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < asterix; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                asterix++;
                spaces--;
                Console.ResetColor();
            }
        }

    }
}
