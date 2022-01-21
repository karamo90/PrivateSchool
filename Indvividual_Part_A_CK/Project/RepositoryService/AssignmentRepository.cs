using Project.Core.Entities;
using Project.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.RepositoryService
{
    class AssignmentRepository
    {
        MyDatabase db = new MyDatabase();

        //Return all Assignments
        public List<Assignment> GetAll()
        {
            
            return db.Assignments;
        }

        //Create a new Assignment
        public List<Assignment> Add(Assignment a)
        {
            int lastId = db.Assignments[db.Assignments.Count - 1].ID;
            a.ID = lastId + 1;
            db.Assignments.Add(a);
            return db.Assignments;
        }
    }
}
