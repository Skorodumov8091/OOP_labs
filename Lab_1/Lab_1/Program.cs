using System.Collections.Generic;
using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание студентов student1-student6
            Student student1 = new Student("Петров", "Петр", "Петрович", new List<int> { 5, 4, 4, 3, 5, 2 });
            Student student2 = new Student("Петров", "Петр", "Викторович", new List<int> { 5, 5, 3, 5, 5 });
            Student student3 = new Student("Иванов", "Иван", "Иванович", new List<int> { 5, 3, 4, 2 });
            Student student4 = new Student("Иванов", "Сергей", "Иванович", new List<int> { 4, 4, 4, 4, 2, 4 });
            Student student5 = new Student("Дмитриев", "Дмитрий", "Дмитриевич", new List<int> { 5, 5, 5, 5 });
            Student student6 = new Student("Павлов", "Павел", "Павлович", new List<int> { 5, 5, 4 });      

            // Создание группы studentGroup_1
            StudentGroup studentGroup1 = new StudentGroup("Группа_1", 2);

            // Добавление студентов в группу studentGroup_1
            if (!studentGroup1.addStudent(student1))
            {
                Console.WriteLine("Больше нет мест в группе.");
            }
            if (!studentGroup1.addStudent(student2))
            {
                Console.WriteLine("Больше нет мест в группе.");
            }
            // Выведется сообщение, т. к. больше нет мест в группе
            if (!studentGroup1.addStudent(student3))
            {
                Console.WriteLine("Больше нет мест в группе.");
            }
            Console.WriteLine(studentGroup1);

            // Удаление студента из группы
            studentGroup1.removeStudent(student1);
            Console.WriteLine(studentGroup1);

            // Поиск студента по ФИО (+)
            if (studentGroup1.searchStudentByFIO("Петров", "Петр", "Викторович") != null)
            {
                Console.WriteLine("Студент состоит в группе.");
            }
            else
            {
                Console.WriteLine("Студент не состоит в группе.");
            }

            // Поиск студента по ФИО (-)
            if (studentGroup1.searchStudentByFIO("Иванов", "Петр", "Иванович") != null)
            {
                Console.WriteLine("Студент состоит в группе.");
            }
            else
            {
                Console.WriteLine("Студент не состоит в группе.");
            }

            StudentGroup studentGroup2 = new StudentGroup("Группа_2", 15);

            // Добавление студентов в группу studentGroup_2
            if (!studentGroup2.addStudent(student1))
            {
                Console.WriteLine("Больше нет мест в группе.");
            }
            if (!studentGroup2.addStudent(student2))
            {
                Console.WriteLine("Больше нет мест в группе.");
            }
            if (!studentGroup2.addStudent(student3))
            {
                Console.WriteLine("Больше нет мест в группе.");
            }
            if (!studentGroup2.addStudent(student4))
            {
                Console.WriteLine("Больше нет мест в группе.");
            }
            if (!studentGroup2.addStudent(student5))
            {
                Console.WriteLine("Больше нет мест в группе.");
            }
            if (!studentGroup2.addStudent(student6))
            {
                Console.WriteLine("Больше нет мест в группе.");
            }

            Console.WriteLine();
            Console.WriteLine("Сортировка по ФИО: ");
            studentGroup2.sortStudentGroupFIO();  
            Console.WriteLine(studentGroup2);

            Console.WriteLine("Сортировка по оценкам: ");
            studentGroup2.sortStudentGroupGrades();
            Console.WriteLine(studentGroup2);
        }
    }
}
