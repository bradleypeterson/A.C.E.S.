using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.C.E.S.Models
{

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Section> Sections { get; set; }
        public List<Submission> Submissions { get; set; }
        public bool Archived { get; set; }

        //public Student(int id, string email, string name, Standing standing)
        //{
        //    ID = id;
        //    Name = name;
        //    Email = email;
        //    Standing = standing;
        //    Archived = false;
        //}
    }
}
