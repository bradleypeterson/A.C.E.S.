﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACES.Models
{
    public class StudentAssignment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int AssignmentId { get; set; }
        public string Watermark { get; set; }
        public string RepositoryUrl { get; set; }
    }
}