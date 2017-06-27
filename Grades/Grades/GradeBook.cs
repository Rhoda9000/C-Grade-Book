using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        private int[,] grades;

        public GradeBook(int[,] gradesArray)
        {
            grades = gradesArray;
        }


        public void ProcessGrades()
        {
            OutputGrades();
            Console.WriteLine("\n{0} {1}\n{2} {3}\n", "Lowest grade is", GetMin(), "Highest grade is", GetMax());
            OutputBarChart();
        }

        public int GetMin()
        {
            int lowGrade = grades[0, 0];
            foreach (int grade in grades)
            {
                if (grade < lowGrade)
                    lowGrade = grade;
            }
            return lowGrade;
        }

        public int GetMax()
        {
            int highGrade = grades[0, 0];

            foreach (int grade in grades)
            {
                if (grade > highGrade)
                    highGrade = grade;
            }
            return highGrade;
        }

        public double GetAverage(int student)
        {
            int amount = grades.GetLength(1);
            int total = 0;

            for (int exam = 0; exam < amount; ++exam)

                total += grades[student, exam];

            return (double)total / amount;

        }


        public String letter(int gradeletter)
        {
            int amount = grades.GetLength(1);
            int total = 0;

            for (int test = 0; test < amount; ++test)

                total += grades[gradeletter, test];
            String letterGrade = "";
            if (((double)total / amount >= 90))
            {
                letterGrade = "A";
            }
            else if (((double)total / amount >= 80))
            {
                letterGrade = "B";
            }
            else if (((double)total / amount >= 70))
            {
                letterGrade = "C";
            }
            else if (((double)total / amount >= 60))
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            return letterGrade;
        }


        public void OutputBarChart()
        {
            Console.WriteLine("Overall grade distribution:");
            int[] frequency = new int[11];

            foreach (int grade in grades)
            {
                ++frequency[grade / 10];
            }

            for (int count = 0; count < frequency.Length; ++count)
            {
                if (count == 10)
                    Console.Write(" 100: ");
                else
                    Console.Write("{0:D2}-{1:D2}: ", count * 10, count * 10 + 9);

                for (int stars = 0; stars < frequency[count]; ++stars)

                    Console.Write("*");

                Console.WriteLine();
            }
        }


        public void OutputGrades()
        {
            Console.WriteLine("Welcome To The Grade Results:\n");
            Console.Write("              ");

            for (int test = 0; test < grades.GetLength(1); ++test)

                Console.Write("Test {0}  ", test + 1);
            Console.WriteLine("Average");
            for (int student = 0; student < grades.GetLength(0); ++student)
            {
                Console.Write("Student {0,2}", student + 1);
                for (int grade = 0; grade < grades.GetLength(1); ++grade)

                    Console.Write("{0,8}", grades[student, grade]);
                Console.WriteLine("  {0,9:F}", GetAverage(student) + " " + letter(student));

            }
        }
    }
}
