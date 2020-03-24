using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.C.E.S.Models
{
    public class Section
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public bool Archived { get; set; }
        public List<Student> Students { get; set; }

        public Section(int id, string name, bool archived)
        {
            ID = id;
            Name = name;
            Archived = archived;
            Students = new List<Student>();
        }
    }
}
