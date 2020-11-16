using System;

namespace Lab_1
{
    public class Examen
    {
        int limit = 3;
        int count_attempts = 1;
        public string name { get; private set; }

        public Examen(string name)
        {
            this.name = name;
        }

        public int Exam(int min, int max)
        {
            count_attempts++;
            Random rnd = new Random();
            return rnd.Next(min, max + 1);
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
