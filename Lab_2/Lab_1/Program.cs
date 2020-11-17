using System.Collections.Generic;
using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Botanist("Петров", "Петр", "Петрович", new List<int> { 5, 4, 4, 3, 5, 2 });
            Student student2 = new OrdinaryStudent("Петров", "Петр", "Викторович", new List<int> { 5, 5, 3, 5, 5 });
            Student student3 = new StudentCouncilMember("Иванов", "Иван", "Иванович", new List<int> { 5, 3, 4, 2 });

            Console.WriteLine(student1);
            student1.Exam("Math"); 
            Console.WriteLine(student1);
            student1.Exam("Philosophy"); 
            Console.WriteLine(student1);

            student2.Exam("Math"); 
            Console.WriteLine(student2);
            student2.Exam("Philosophy"); 
            Console.WriteLine(student2);
            student2.Exam("Philosophy"); 
            student2.Exam("Philosophy"); 
            Console.WriteLine(student2);
            student2.Exam("Philosophy"); 
            Console.WriteLine(student2);

            student3.Exam("Math");
            Console.WriteLine(student3);
            student3.Exam("Philosophy"); 
            student3.Exam("Philosophy");
            Console.WriteLine(student3);
            student3.Exam("Philosophy");
            Console.WriteLine(student3);
        }
    }
}
