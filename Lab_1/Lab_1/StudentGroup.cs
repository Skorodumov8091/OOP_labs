using System;
using System.Collections.Generic;
using System.Text;

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
            int size_1 = student1.grades.Count;
            int size_2 = student2.grades.Count;
            double srGrades1 = 0;
            double srGrades2 = 0;
            for (int i = 0; i < size_1; ++i)
            {
                srGrades1 += student1.grades[i];
            }
            for (int i = 0; i < size_2; ++i)
            {
                srGrades2 += student2.grades[i];
            }
            srGrades1 /= size_1;
            srGrades2 /= size_2;
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
