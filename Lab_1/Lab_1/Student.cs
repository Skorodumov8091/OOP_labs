using System;
using System.Collections.Generic;
using System.Text;


namespace Lab_1
{
    public class Student
    {
        public string surname { get; private set; }
        public string name { get; private set; }
        public string middleName { get; private set; }
        public List<int> grades { get; private set; }
        public Student(string surname, string name, string middleName, List<int> grades)
        {
            this.surname = surname;
            this.name = name;
            this.middleName = middleName;
            this.grades = grades;
        }
        public override string ToString()
        {
            string str = $"{ this.surname} { this.name} { this.middleName} ";
            for (int i = 0; i < this.grades.Count; ++i)
            {
                str += $"{this.grades[i]} ";
            }
            return str;
        }
    }
}
