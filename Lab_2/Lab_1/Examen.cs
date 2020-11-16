using System;

namespace Lab_1
{
    public class Examen
    {
        int limit = 3;
        public string name { get; private set; }

        public Examen(string name)
        {
            this.name = name;
        }

        public int Exam(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max + 1);
        }

        public bool Limit(int attempts)
        {
            return limit > attempts;
        }
    }
}
