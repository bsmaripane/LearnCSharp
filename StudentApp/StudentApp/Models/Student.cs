using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string CourseCode { get; set; } = "";
        public DateTime RegistrationDate { get; set; }
        public Decimal CourseFee { get; set; }
    }
}
