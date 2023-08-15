using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class StudentMarks
    {
        static double CalculateAverage(double[] marks)
        {
            double total = 0;
            foreach (double mark in marks)
            {
                total += mark;
            }
            return total / marks.Length;
        }

        static double FindHighestMark(double[] marks)
        {
            double highestMark = marks[0];
            for (int i = 1; i < marks.Length; i++)
            {
                if (marks[i] > highestMark)
                {
                    highestMark = marks[i];
                }
            }
            return highestMark;
        }

        static void Main(string[] args)
        {
            const int numStudents = 10;
            double[] studentMarks = new double[numStudents];

            Console.WriteLine($"Enter marks for {numStudents} students:");

            for (int i = 0; i < numStudents; i++)
            {
                Console.Write($"Enter marks for student {i + 1}: ");
                studentMarks[i] = Convert.ToDouble(Console.ReadLine());
            }

            double averageMarks = CalculateAverage(studentMarks);
            double highestMark = FindHighestMark(studentMarks);

            Console.WriteLine($"Average marks: {averageMarks}");
            Console.WriteLine($"Highest mark: {highestMark}");
        }
    }
}
