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
        public List<string> SNPStudents = new List<string>();

        public List<string> Sort(List<Student> students, double minball)
        {
            var sortList = from stud in students
                           where stud.MiddleGrade > minball
                           orderby stud.MiddleGrade
                           select ($"{stud.Surname} {stud.Name} {stud.Patronymic} ");
            
            var SortList = sortList.ToList();
            SNPStudents = SortList;
            return SortList;
        }
        public void Add(Student student)
        { 
            Students.Add(student);
        }
        public string Print()
        {
            string Info="";
            foreach (var student in SNPStudents)
            {
                Info=Info+student+"\n";
            }
            return Info;
        }
    }
}
