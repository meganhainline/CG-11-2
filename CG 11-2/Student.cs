using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CG_11_2
{
    class Student
    {
        public List<int> scores = new List<int>();
        public string Name { get; set; }


        public Student(string name)
        {
            Name = name;
        }

        public void AddScore(int score)
        {
            scores.Add(score);
        }

        public double Average()
        {
            return scores.Average(x => x);
        }
    }
}

