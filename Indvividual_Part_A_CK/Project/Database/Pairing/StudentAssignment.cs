using Project.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Database.Pairing
{
    class StudentAssignment
    {
        public static void Pairing(Student s, Assignment a)
        {
            a.Students.Add(s);
            s.Assignment.Add(a);
        }
    }
}
