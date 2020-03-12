using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.C.E.S.Models
{
    public enum Status { Good, Moderate, Bad }

    public class Student
    {
        public ushort ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Status Standing { get; set; }
        public bool Archived { get; set; }

        public Student(ushort id, string email, string name, Status standing)
        {
            ID = id;
            Name = name;
            Email = email;
            Standing = standing;
            Archived = false;
        }
    }
}
