using System;

namespace Lab_1
{
    public class Examen
    {
        public string name { get; private set; }
        public int grade;
        int limit = 3;
        int count_attempts = 1;
        public Examen(string name)
        {
            this.name = name;
        }

        public int Exam(int min, int max)
        {
            count_attempts++;
            Random rnd = new Random();
            grade = rnd.Next(min, max + 1);
            return grade;
        }

        public bool Limit()
        {
            return limit >= count_attempts;
        }

        public bool LastAttempt()
        {
            return limit == count_attempts;
        }
    }
}
