using Project.Application.Ouput;
using Project.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application
{
    class App
    {
        public static void Run()
        {
            
            AssignmentController assignmentController = new AssignmentController();
            CourseController courseController = new CourseController();
            StudentController studentController = new StudentController();
            TrainerController trainerController = new TrainerController();

            string input = "";
            string input2 = "";
            InitialMenu.InitialMenu.Menu();

            //Switch Cases in order to select and prevent the user to entry false inputs
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("These are your Choices:");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("1-Read Synthetic Data");
                Console.WriteLine("2-Input Data");
                Console.WriteLine("3-Exit");
                input2 = Console.ReadLine();
                Console.Clear();
                switch (input2)
                {

                    case "1":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("---------------------Synthetic Data Entries--------------------------");
                        Console.ResetColor();
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{new string('-', 69)}");
                            Console.ResetColor();
                            Console.WriteLine("1-Read all Students");
                            Console.WriteLine("2-Read all Courses");
                            Console.WriteLine("3-Read all Trainers");
                            Console.WriteLine("4-Read all Assignments");
                            Console.WriteLine("5-Read all Students Per Course");
                            Console.WriteLine("6-Read all Trainers Per Courses");
                            Console.WriteLine("7-Read all Assignments Per Courses");
                            Console.WriteLine("8-Read all Assignments Per Students");
                            Console.WriteLine("9-Read all Students that Belong to more than one Course");
                            Console.WriteLine("10-Read all Assignments that Belong to a specific date-week");
                            Console.WriteLine(new string('-',69));
                            Console.WriteLine("R for Return to the previously MENU");
                            Console.WriteLine("E for EXIT");
                            Console.WriteLine();
                            input = Console.ReadLine();
                            Console.Clear();
                            switch (input)
                            {
                                case "1": studentController.ReadAllStudents(); break;
                                case "2": courseController.ReadAllCourses(); break;
                                case "3": trainerController.ReadAllTrainers(); break;
                                case "4": assignmentController.ReadAllAssignments(); break;
                                case "5": courseController.ReadAllStudentsPerCourse(); break;
                                case "6": courseController.ReadAllTrainersPerCourse(); break;
                                case "7": courseController.ReadAssignmentPerCourse(); break;
                                case "8": studentController.ReadAllAssignmentsPerStudent(); break;
                                case "9": studentController.ReadAllStudentWithMoreThanOneCourse(); break;
                                case "10":assignmentController.ListOfStudentsWithAssignmentsInTheSelectedCalendarWeek();break;
                                case "R": InitialMenu.InitialMenu.Menu(); break;
                                case "E":
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Goodbye and a happy new year!");
                                    Console.ResetColor(); break;


                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Wrong Input please Type again!");
                                    Console.WriteLine();
                                    Console.ResetColor(); break;

                            }

                        } while (input != "E" && input != "R"); break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("---------------------Create Data Entries--------------------------");
                        Console.ResetColor();
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{new string('-', 66)}");
                            Console.ResetColor();
                            Console.WriteLine("1-Create and Add new Students");
                            Console.WriteLine("2-Create and Add new Courses");
                            Console.WriteLine("3-Create and Add Trainers");
                            Console.WriteLine("4-Create and Add new Assignments");
                            Console.WriteLine(new string('-', 69));
                            Console.WriteLine("R for Return to the previously MENU");
                            Console.WriteLine("E for EXIT");
                            input = Console.ReadLine();
                            Console.Clear();
                            switch (input)
                            {
                                case "1": studentController.CreateStudent(); break;
                                case "2": courseController.CreateCourse(); break;
                                case "3": trainerController.CreateTrainer(); break;
                                case "4": assignmentController.CreateAssignment(); break;
                                case "R": InitialMenu.InitialMenu.Menu(); break;
                                case "E":
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Goodbye and a happy new year!");
                                    Console.ResetColor(); break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Wrong Input please Type again!");
                                    Console.WriteLine();
                                    Console.ResetColor(); break;

                            }

                        } while (input != "E" && input != "R"); break;
                    case "3":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Goodbye and a happy new year!");
                        Console.ResetColor(); break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{new string('-', 30)}{"Wrong Input please Type again!"}{new string('-', 30)}");
                        Console.WriteLine();
                        Console.ResetColor();
                        InitialMenu.InitialMenu.Menu(); break;
                }
            } while (input2 != "3" && input != "E");
        }
    }
}






