﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACES.Models
{
    public class Commit
    {
        public int Id { get; set; }
        public int StudentAssignmentId { get; set; }
        public DateTime DateCommitted { get; set; }
        public int LinesAdded { get; set; }
        public int LinesDeleted { get; set; }
    }
}