using Project.Core.Entities;
using Project.Core.Enums;
using Project.View.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.View.Students
{
    class ViewTrainer
    {
        public static void PrintTrainers(List<Trainer> trainers)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{new string('-', 31)}{"All the entities of the Trainers"}{new string('-', 32)}");
            Console.WriteLine(new string('-', 95));
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{"ID",-25}{"Firstname",-28}{"Lastname",-28}{"Subject",-25}");
            Console.ResetColor();
            Console.WriteLine(new string('-', 95));
            foreach (var tra in trainers)
            {
                Console.WriteLine($"{tra.ID,-25}{tra.FirstName,-28}{tra.Lastname,-28}{tra.Subject,-25}");
                Console.WriteLine(new string('-', 95));
            }
        }
        public static Trainer CreateTrainer()
        {
            //Firstname of New Trainer

            string firstName = HelperClassInputText.InputTextNames("Type Trainer's First Name----> ex:Hector");
            Console.WriteLine();

            //Lastname of New Trainer

            string lastName = HelperClassInputText.InputTextNames("Type Trainer's Last Name----> ex:Gatsos");
            Console.WriteLine();

            //Subject of new Trainer
            do
            {
                try
                {
                    Console.WriteLine("0--Csharp, 1--Python,2--Java");
                    Subject subject = HelperClassInputEnumSubject.Subject("Give one of the 3 choices");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("If you wish to create another Trainer press 3 Again or enter to another Menu");
                    Console.ResetColor();
                    Trainer tra = new Trainer(0, firstName, lastName, subject);
                    return tra;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("please input a specific Number depending on your choice: 0 for Csharp, 1 for Python,2 for Java");
                    Console.ResetColor();
                }
               
            } while (true);
           
    }
    }
}
