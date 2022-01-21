using Project.Core.Entities;
using Project.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.RepositoryService
{
    class StudentRepository
    {
        MyDatabase db = new MyDatabase();

        //Return all Students
        public List<Student> GetAll()
        { 
            return db.Students;
        }

        //Create a new Student
        public List<Student> Add(Student s)
        {
            int lastId = db.Students[db.Students.Count - 1].ID;
            s.ID = lastId + 1;
            db.Students.Add(s);
            return db.Students;
        }
    }
}
