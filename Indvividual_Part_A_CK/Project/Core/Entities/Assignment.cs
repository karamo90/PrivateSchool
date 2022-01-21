using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Entities
{
    
    class Assignment:Information
    {
        public Assignment(int ID,string title , int oralMark, int totalMark,DateTime subDateTime,string description) :base(ID,title,description)
        {
            SubDateTime = subDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
        }

        public DateTime SubDateTime { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }

        //Navigation
        public Course Course { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
