using Project.Application.Ouput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.InitialMenu
{
    class InitialMenu
    {
        //Initial Menu
        public static void Menu()
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to our Christmas and New Year's Eve Presentation----HO HO HO!");
            Console.ResetColor();
            Console.WriteLine();
            ChristmasTree.ChristmasTrees();
            Console.WriteLine();
        }
       
    }
}
