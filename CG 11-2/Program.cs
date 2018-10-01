using CG_11_2;
using System;
using System.Collections.Generic;
using System.IO;

namespace StudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("C:\\Users\\megha\\source\\repos\\CG 11-2\\CG 11-2\\StudentData.txt");

            List<Student> students = new List<Student>();

            string line;

            while ((line = file.ReadLine()) != null)
            {
                string[] items = line.Split(" ");
                Student s = new Student(items[0]);

                for (int i = 1; i < items.Length; i++)
                {
                    s.AddScore(Int32.Parse(items[i]));
                }

                students.Add(s);

            }
            foreach (Student item in students)
            {
                Console.WriteLine(item.Name + " " + item.Average());
            }
            Console.ReadLine();

        }
    }
}
