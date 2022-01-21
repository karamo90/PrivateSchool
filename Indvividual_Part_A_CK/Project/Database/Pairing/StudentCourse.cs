using Project.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Database.Pairing
{
    class StudentCourse
    {
        public static void Pairing(Student s, Course c)
        {
            s.Course.Add(c);
            c.Student.Add(s);
        }
    }
}
