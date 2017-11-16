using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorials9AM.Models
{
    public class StudentDeptVM
    {
        public StudentDeptVM()
        {
            StudentList = new List<StudentVM>();

        }
        public List<StudentVM> StudentList { get; set; }
        public DepartmentVM Department { get; set; }
    }
}