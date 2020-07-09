﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.C.E.S.Models
{
    /// <summary>
    /// This class links the student to a course
    /// </summary>
    public class Enrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        /// <summary>
        /// If inactive, enrollment belongs to a past semester
        /// </summary>
        public bool Active { get; set; }
    }
}
