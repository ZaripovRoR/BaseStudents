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
        
        public IEnumerable<Student> Sort(List<Student> students, double minball)
        {
            var SortList = from stud in students
                           where stud.MiddleGrade > minball
                           select stud;
            return SortList;
        }
        public void Add(Student student)
        { 
            Students.Add(student);
        }
        public void Print(IEnumerable<Student> Students)
        {
            foreach (var student in Students)
            {
                student.Print();
            }
        }
    }
}
