using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Entities
{
    class Information
    {
        public Information(int iD, string title, string description)
        {
            ID = iD;
            Title = title;
            Description = description;
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
    }
}
