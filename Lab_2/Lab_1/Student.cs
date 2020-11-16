using System;
using System.Collections.Generic;

namespace Lab_1
{
    public abstract class Student
    {
        public string surname { get; private set; }
        public string name { get; private set; }
        public string middleName { get; private set; }
        public List<int> grades { get; private set; }
        List<Examen> examens = new List<Examen>();
        public Student(string surname, string name, string middleName, List<int> grades)
        {
            this.surname = surname;
            this.name = name;
            this.middleName = middleName;
            this.grades = grades;
        }
        public abstract int Exam(string name);

        public Examen GetOrAddExamen(string name)
        {
            foreach (Examen ex in examens)
                if (ex.name == name)
                    return ex;
            Examen examen = new Examen(name);
            examens.Add(examen);
            return examen;
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

    public class Botanist : Student
    {
        public Botanist(string surname, string name, string middleName, List<int> grades)
            : base(surname, name, middleName, grades)
        { }
        public override int Exam(string name)
        {
            Examen examen = GetOrAddExamen(name);
            return examen.Exam(4, 5);
        }
    }

    public class OrdinaryStudent : Student
    {
        public OrdinaryStudent(string surname, string name, string middleName, List<int> grades)
            : base(surname, name, middleName, grades)
        { }
        public override int Exam(string name)
        {
            Examen examen = GetOrAddExamen(name);
            if (examen.Limit())
                return examen.Exam(2, 5);
            else
                return -1;
        }
    }

    public class StudentCouncilMember : OrdinaryStudent
    {
        public StudentCouncilMember(string surname, string name, string middleName, List<int> grades)
            : base(surname, name, middleName, grades)
        { }

        public override int Exam(string name)
        {
            Examen examen = GetOrAddExamen(name);
            if (examen.LastAttempt())
                return 3;
            else 
                return examen.Exam(2, 5);
        }
    }
}
