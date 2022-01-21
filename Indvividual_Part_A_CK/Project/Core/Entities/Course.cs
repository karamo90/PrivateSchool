using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Entities
{
    class Course:Information
    {
        public Course(int ID,string title,string stream, string type, DateTime start_Date, DateTime end_Date,string description):base(ID,title,description)
        {
            Stream = stream;
            Type = type;
            Start_Date = start_Date;
            End_Date = end_Date;
        }

        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }

        //Navigation-Instantiate the Lists
        public List<Student> Student { get; set; } = new List<Student>();

        public List<Trainer> Trainer { get; set; } = new List<Trainer>();
        public List<Assignment> Assignment { get; set; } = new List<Assignment>();
    }
}
