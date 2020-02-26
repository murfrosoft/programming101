using System;

namespace Program101
{
    class Program
    {
        static int IntPrompt(string text)
        {
            bool goodParse = false;
            int result = 0;
            while (!goodParse)
            {
                try
                {
                    Console.Write(text);
                    result = Convert.ToInt32(Console.ReadLine());
                    goodParse = true;
                }
                catch
                {
                    Console.WriteLine("*Invalid input. Try again*");
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            // Prompt for grades
            int count = IntPrompt("How many grades will you enter: ");

            while (count < 3)
            {
                Console.WriteLine("*Minimum value of 3 expected*");
                count = IntPrompt("How many grades will you enter: ");
            }

            int[] grades = new int[count];
            Console.WriteLine();

            int minGrade = int.MaxValue;
            int minIndex = 0;
            int sumGrade = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = IntPrompt($"Enter grade {i + 1}: ");
                sumGrade += grades[i];
                if (grades[i] < minGrade)
                {
                    minGrade = grades[i];
                    minIndex = i;
                }
            }

            // Print entered grades:
            Console.WriteLine("\nYour grades:");

            for (int i = 0; i < grades.Length; i++)
            {
                if (i == minIndex)
                {
                    Console.WriteLine("{0} *dropped*", grades[i]);
                }
                else
                {
                    Console.WriteLine("{0}", grades[i]);
                }
            }

            Console.WriteLine("\nAverage of grades is {0:F}", (sumGrade - minGrade) / (double)(grades.Length - 1));

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
