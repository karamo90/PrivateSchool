using Project.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project.Core.Entities
{
    class Trainer:Person
    {
        public Trainer(int ID,string firstname,string lastname,Subject subject):base(ID,firstname,lastname)
        {
            Subject = subject;
        }

        //Navigation
        public Subject Subject { get; set; }
        public List<Course> Course { get; set; } = new List<Course>();
    }
}
