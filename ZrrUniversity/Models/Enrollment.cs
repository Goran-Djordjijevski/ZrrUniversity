﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZrrUniversity.Models
{
    public class Enrollment
    {
        public Enrollment()
        {

        }

        public int Id { get; set; }

        public int CourseId { get; set; }

        public int StudentId { get; set; }

        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }

    public enum Grade
    {
        A, B, C, D, F
    }
}