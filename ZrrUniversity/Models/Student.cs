using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZrrUniversity.Models
{
    public class Student
    {
        public Student()
        {

        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}