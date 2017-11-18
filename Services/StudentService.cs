using MVCTutorials9AM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorials9AM.Services
{
    public class StudentService
    {
        List<StudentVM> studentList = new List<StudentVM>();
        public StudentService()
        {
            studentList.Add(new StudentVM { ID = 1, Name = "Rama", Email = "rama@gmail.com", Address = "Hyd,TG", Phone = "98943435454" });
            studentList.Add(new StudentVM { ID = 2, Name = "Siva", Email = "siva@gmail.com", Address = "Kurnool,AP", Phone = "756556555" });
            studentList.Add(new StudentVM { ID = 3, Name = "Krishna", Email = "krishna@gmail.com", Address = "Mumbai,MH", Phone = "9776765654" });

        }
        public List<StudentVM> GetAll()
        {  
            return studentList;
        }
        public StudentVM GetStudentById(int id)
        {
           return studentList.FirstOrDefault(i => i.ID == id);
        }
    }
}