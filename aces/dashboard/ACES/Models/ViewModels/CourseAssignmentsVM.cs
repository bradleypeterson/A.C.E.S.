﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACES.Models.ViewModels
{
    public class CourseAssignmentsVM
    {
        public int CourseId { get; set; }
        public string CouseName { get; set; }
        public List<Assignment> Assignments { get; set; }
    }
}
