using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.View.Helpers
{
    //Helper class for Different types of Text Entries
    class HelperClassInputText
    {
        public static string InputTextNames(string placeholder)
        {
            
            do
            {

                Console.WriteLine(placeholder);
                string result = Console.ReadLine();
                if (result.All(cha=>char.IsLetter(cha)) &&!string.IsNullOrEmpty(result))
                {
                    return result;

                }
               else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Type only Letters not Numbers or Symbols or Empty Spaces  ex:Christos");
                    Console.ResetColor();
                }

            } while (true);
        }
        public static string InputTextStreams(string placeholder)
        {
            do
            {
                
                    Console.WriteLine(placeholder);
                    string result = Console.ReadLine();
                    if (!string.IsNullOrEmpty(result))
                    {
                        return result;

                    }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Type a valid Input for the property Stream with any Letter,Symbol,Number you want but not Empty Spaces ex:CB#15");
                    Console.ResetColor();
                }

            } while (true);
        }
        public static string InputTextTitles(string placeholder)
        {
            string pattern = "#-_+ ";
            do
            {

                Console.WriteLine(placeholder);
                string result = Console.ReadLine();
                bool condition = result.All(cha => char.IsLetter(cha) || pattern.Contains(cha)) && result.Any(char.IsLetter);

                if (condition)
                {
                    return result;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Type only Letters and/or Symbols( # - _ ) not Numbers or only Empty Spaces");
                    Console.ResetColor();
                }


            } while (true);
        }
        public static string InputTextDescription(string placeholder)
        {
            string pattern = " .,";
            do
            {

                Console.WriteLine(placeholder);
                string result = Console.ReadLine();
                bool condition = result.All(cha => char.IsLetter(cha) || pattern.Contains(cha)) && result.Any(char.IsLetter);
                if (condition)
                {
                    return result;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Type only Letters and empty Spaces not Numbers or Symbols  ex:This Description is a");
                    Console.ResetColor();
                }

            } while (true);
        }
    }
}

