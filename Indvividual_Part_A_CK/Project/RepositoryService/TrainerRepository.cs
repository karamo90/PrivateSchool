using Project.Core.Entities;
using Project.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.RepositoryService
{
    class TrainerRepository
    {
        MyDatabase db = new MyDatabase();

        //Return all Trainers
        public List<Trainer> GetAll()
        {
            return db.Trainers;
        }

        //Create a new Trainer
        public List<Trainer> Add(Trainer t)
        {
            int lastId = db.Trainers[db.Trainers.Count - 1].ID;
            t.ID = lastId + 1;
            db.Trainers.Add(t);
            return db.Trainers;
        }
    }
}
