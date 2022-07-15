using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseStudents
{
    internal class Base
    {
        public int Number { get; set; }
        public List<Student> Students = new List<Student>();
        
        public List<Student> Sort(List<Student> students, double minball)
        {
            var sortList = from stud in students
                           where stud.MiddleGrade > minball
                           orderby stud.MiddleGrade
                           select stud;
            List<Student> SortList = sortList.ToList();
            return SortList;
        }
        public void Add(Student student)
        { 
            Students.Add(student);
        }
        public string Print(List<Student> Students)
        {
            string Info="";
            foreach (var student in Students)
            {
                Info=Info+student.Print()+"\n";
            }
            return Info;
        }
    }
}
