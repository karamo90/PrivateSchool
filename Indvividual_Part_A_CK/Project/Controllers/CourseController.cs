using Project.RepositoryService;
using Project.View.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controllers
{
    //Course Controller
    class CourseController
    {
        CourseRepository courseService = new CourseRepository();
        
        public void ReadAllCourses()
        {
            var courses = courseService.GetAll();
            ViewCourse.PrintCourses(courses);

        }
        public void CreateCourse()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Create a new Course");
            Console.ResetColor();
            Console.WriteLine();

            var course = ViewCourse.CreateCourse();
            courseService.Add(course);
        }
        public void ReadAllStudentsPerCourse()
        {
            var courses = courseService.GetAll();
            ViewCourse.PrintStudentsPerCourse(courses);
        }
        public void ReadAllTrainersPerCourse()
        {
            var courses = courseService.GetAll();
            ViewCourse.PrintTrainersPerCourse(courses);
        }
        public void ReadAssignmentPerCourse()
        {
            var courses = courseService.GetAll();
            ViewCourse.PrintAssignmentsPerCourse(courses);
        }

    }
}
