using Project.RepositoryService;
using Project.View.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controllers
{
    //Assignment Controller
    class AssignmentController
    {
        AssignmentRepository assignmentService = new AssignmentRepository();
        public void ReadAllAssignments()
        {
            var asssignments = assignmentService.GetAll();
            ViewAssignment.PrintAssignments(asssignments);
        }
        public void CreateAssignment()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Create a new Assignment");
            Console.ResetColor();
            Console.WriteLine();
            var assignments=ViewAssignment.CreateAssignment();
            assignmentService.Add(assignments);
        }
        public void ListOfStudentsWithAssignmentsInTheSelectedCalendarWeek()
        {
            var assignments = assignmentService.GetAll();
            ViewAssignment.PrintAllTheAssignmentsPerStudentsOnSelectedWeek(assignments);
        }


    }
}
