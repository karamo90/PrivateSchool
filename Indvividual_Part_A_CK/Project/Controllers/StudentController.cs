using Project.Core.Entities;
using Project.RepositoryService;
using Project.View.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controllers
{
    //Student Controller
    class StudentController
    {
        StudentRepository studentService = new StudentRepository();

        public void ReadAllStudents()
        {
            var students=studentService.GetAll();
            ViewStudent.PrintStudents(students);
        }
        public void CreateStudent()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Create a new Student");
            Console.ResetColor();
            Console.WriteLine();
           
                var student = ViewStudent.CreateStudent();
                studentService.Add(student);
   
        }
        public void ReadAllAssignmentsPerStudent()
        {
            var students = studentService.GetAll();
            ViewStudent.PrintAssignmentsPerStudent(students);
        }
        public void ReadAllStudentWithMoreThanOneCourse()
        {
            var students = studentService.GetAll();
            ViewStudent.PrintAllStudentsThatBelongToMoreThanOneCourse(students);
        }
        
    }
}
