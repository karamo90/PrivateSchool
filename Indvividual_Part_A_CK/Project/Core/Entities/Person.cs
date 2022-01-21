using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Entities
{
    class Person
    {
        public Person(int iD, string firstName, string lastname)
        {
            FirstName = firstName;
            Lastname = lastname;
            ID = iD;
        }

        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public int ID { get; set; }
    }
}
