using Project.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Database.Pairing
{
    class CourseTrainer
    {
        public static void Pairing(Course c, Trainer t)
        {
            c.Trainer.Add(t);
            t.Course.Add(c);
        }
    }
}
