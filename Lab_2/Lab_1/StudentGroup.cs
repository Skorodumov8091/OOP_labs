using System;
using System.Collections.Generic;

namespace Lab_1
{
    public class StudentGroup
    {
        public string nameGroup { get; private set; }
        public int numberStudent { get; private set; }
        public List<Student> students { get; private set; }
        public StudentGroup(string nameGroup, int numberStudent)
        {
            this.nameGroup = nameGroup;
            this.numberStudent = numberStudent;
            this.students = new List<Student>();
        }
        public bool addStudent(Student student)
        {
            if (students.Count < numberStudent)
            {
                students.Add(student);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void removeStudent(Student student)
        {
            students.Remove(student);
        }
        public Student searchStudentByFIO(string surname, string name, string middleName)
        {
            if (students.Count != 0)
            {
                foreach (Student el in students)
                {
                    if (el.surname == surname && el.name == name && el.middleName == middleName)
                    {
                        return el;
                    }
                }
            }
            return null;
        }
        public void sortStudentGroupFIO()
        {
            students.Sort(CompareByFIO);
        }
        public static int CompareByFIO(Student student1, Student student2)
        {
            if (student1.surname == student2.surname)
            {
                if (student1.name == student2.name)
                {
                    return String.Compare(student1.middleName, student2.middleName);
                }
                else
                {
                    return String.Compare(student1.name, student2.name);
                }
                
            }
            else
            {
                return String.Compare(student1.surname, student2.surname);
            }
        }
        public void sortStudentGroupGrades() {
            students.Sort(CompareByGrades);
        }
        public static int CompareByGrades(Student student1, Student student2)
        {
            double srGrades1 = srGrades(student1);
            double srGrades2 = srGrades(student2);
            if (srGrades1 < srGrades2)
            { 
                return 1;
            } 
            else if (srGrades1 > srGrades2)
            { 
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public static double srGrades(Student student)
        {
            int size = student.grades.Count;
            double srGrades = 0;
            for (int i = 0; i < size; ++i)
            {
                srGrades += student.grades[i];
            }
            return srGrades /= size;
        }
        public override string ToString()
        {
            string str = "";
            foreach (Student el in students)
            {
                str += $"{ el.surname} { el.name} { el.middleName} ";
                for (int i = 0; i < el.grades.Count; ++i)
                {
                    str += $"{el.grades[i]} ";
                }
                str += "\n";
            }
            return str;
        }
    }
}
