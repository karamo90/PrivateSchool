using Project.Core.Entities;
using Project.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.RepositoryService
{
    class CourseRepository
    {
        MyDatabase db = new MyDatabase();

        //Return all Courses
        public List<Course> GetAll()
        {
            return db.Courses;
        }

        //Create a new Course
        public List<Course> Add(Course c)
        {
            int lastId = db.Courses[db.Courses.Count - 1].ID;
            c.ID = lastId + 1;
            db.Courses.Add(c);
            return db.Courses;
        }
        
    }
}
