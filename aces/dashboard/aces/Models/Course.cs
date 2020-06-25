using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.C.E.S.Models
{/// <summary>
/// this is the Course item base class with all its atributes
/// </summary>
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //public List<Assignment> Assignments { get; set; }
        //public IList<Section> Sections { get; set; }
        public bool Archived { get; set; }

        //public Course(int id, string name)
        //{
        //    ID = id;
        //    Name = name;
        //    Assignments = new List<Assignment>();
        //}
    }
}
