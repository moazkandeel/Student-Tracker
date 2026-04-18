namespace Student_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];
            int[,] grades = new int[3, 5];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter student name: ");
                names[i] = Console.ReadLine();

                for (int k = 0; k < 5; k++)
                {
                    Console.Write("Enter grade " + (k + 1) + ": ");
                    grades[i, k] = int.Parse(Console.ReadLine());
                }
            }



            Console.WriteLine("\n Report ");


            for (int i = 0; i < 3; i++)
            {
                int sum = 0;

                for (int m = 0; m < 5; m++)
                {
                    sum += grades[i, m];
                }

                double average = sum / 5.0;

                string level;

                if (average < 20)
                    level = "Freshman";
                else if (average < 40)
                    level = "Sophomore";
                else if (average < 60)
                    level = "Junior";
                else
                    level = "Senior";

                Console.WriteLine("\nName: " + names[i]);
                Console.WriteLine("Average: " + average);
                Console.WriteLine("Level: " + level);
            }
        }
    }
}
