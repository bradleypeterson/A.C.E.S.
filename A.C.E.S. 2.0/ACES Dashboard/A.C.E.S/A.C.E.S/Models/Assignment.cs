using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace A.C.E.S.Models
{
    public class Assignment
    {
        public int ID { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
        public string Name { get; set; }
        public string Files { get; set; }
        public string UnitTesters { get; set; }
        public int Grade { get; set; }

        //public Assignment(int id, string name)
        //{
        //    ID = id;
        //    Name = name;
        //}
    }
}
