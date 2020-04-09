using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace A.C.E.S.Models
{
    /// <summary>
    /// Section base class with all its atributes
    /// </summary>
    public class Section
    {

        public int ID { get; set; }
        public string Name { get; set; }

        public int CourseID { get; set; }
        public Course Course { get; set; }

        public string Semester { get; set; }
        public string Length { get; set; }
        public int Year { get; set; }
        public virtual List<SectionStudent> Students { get; set; }
        public bool Archived { get; set; }

        //public Section(int id, string name, bool archived)
        //{
        //    ID = id;
        //    Name = name;
        //    Archived = archived;
        //    Students = new List<Student>();
        //}
    }
}
