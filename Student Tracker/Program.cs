using System;
using System.Collections.Generic;

namespace Student_Tracker
{
    enum StudentLevel
    {
        Freshman,
        Sophomore,
        Junior,
        Senior
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> students = new Dictionary<string, List<int>>();

            int studentCount = 3;

            for (int i = 0; i < studentCount; i++)
            {
                string name;

                while (true)
                {
                    Console.Write("Enter student name: ");
                    name = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(name) && !students.ContainsKey(name))
                        break;

                    Console.WriteLine("Invalid or duplicate name!");
                }

                List<int> grades = new List<int>();

                for (int k = 0; k < 5; k++)
                {
                    int grade;

                    while (true)
                    {
                        Console.Write($"Enter grade {k + 1}: ");
                        if (int.TryParse(Console.ReadLine(), out grade) && grade >= 0 && grade <= 100)
                            break;

                        Console.WriteLine("Invalid input! (0 - 100)");
                    }

                    grades.Add(grade);
                }

                students.Add(name, grades);
            }

            Console.WriteLine("\n Report ");

            List<string> keys = new List<string>(students.Keys);

            for (int i = 0; i < keys.Count; i++)
            {
                string name = keys[i];
                List<int> grades = students[name];

                int sum = 0;

                for (int j = 0; j < grades.Count; j++)
                {
                    sum += grades[j];
                }

                double avg = sum / 5.0;

                StudentLevel level;

                if (avg < 20)
                    level = StudentLevel.Freshman;
                else if (avg < 40)
                    level = StudentLevel.Sophomore;
                else if (avg < 60)
                    level = StudentLevel.Junior;
                else
                    level = StudentLevel.Senior;

                Console.WriteLine($"\nName: {name}");
                Console.WriteLine($"Average: {avg}");
                Console.WriteLine($"Level: {level}");
            }
        }
    }
}