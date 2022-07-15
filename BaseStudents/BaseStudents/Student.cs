using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseStudents
{
    internal class Student
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int Age { get; set; }
        public int NumberClass { get; set; }
        public double MiddleGrade { get; set; }
        public Student(string surname, string name, string patronymic, int age, int numberClass, double middleGrade)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Age = age;
            NumberClass = numberClass;
            MiddleGrade = middleGrade;

        }
        public string Print()
        {
            return ($"{Surname} {Name} {Patronymic} ");
        }
    }
}
