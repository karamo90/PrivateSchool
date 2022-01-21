using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Entities
{
    class Student:Person
    {
        public Student(int ID,string firstname,string lastname,DateTime dateOfBirth, int tutitionFees):base(ID,firstname,lastname)
        {
            DateOfBirth = dateOfBirth;
            TutitionFees = tutitionFees;
        }

        public DateTime DateOfBirth { get; set; }
        public int TutitionFees { get; set; }

        //Navigation
        public List<Course> Course { get; set; } = new List<Course>();
        public List<Assignment> Assignment { get; set; } = new List<Assignment>();

    }
}
