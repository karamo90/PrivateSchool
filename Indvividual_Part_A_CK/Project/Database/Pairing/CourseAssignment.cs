using Project.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Database.Pairing
{
    class CourseAssignment
    {
        public static void Pairing(Course c, Assignment a)
        {
            c.Assignment.Add(a);
            a.Course = c;
        }
    }
}
