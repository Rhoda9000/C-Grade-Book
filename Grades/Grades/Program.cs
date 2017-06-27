using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBookTest
    {
        public static void getGrades(int[,] grades)
        {
            for (int student = 0; student < 10; student++)
            {
                Console.Write("Enter 5 grades for student ");
                Console.WriteLine(student + 1);
                for (int grade = 0; grade < 5; grade++)
                {
                    grades[student, grade] = int.Parse(Console.ReadLine());

                    if ((grades[student, grade] < 0) || (grades[student, grade] > 100))
                        Console.WriteLine("Invalid number ,try again", grade--);
                }
            }
            Console.WriteLine("Thank you.");
        }
        static void Main(string[] args)
        {

            int[,] grades = new int[10, 5];
            getGrades(grades);


            int[,] gradesArray = { { grades[0,0], grades[0,1], grades[0,2],grades[0,3],grades[0,4] },
                                   { grades[1,0], grades[1,1], grades[1,2],grades[1,3],grades[1,4] },
                                   { grades[2,0], grades[2,1], grades[2,2],grades[2,3],grades[2,4] },
                                   { grades[3,0], grades[3,1], grades[3,2],grades[3,3],grades[3,4] },
                                   { grades[4,0], grades[4,1], grades[4,2],grades[4,3],grades[4,4] },
                                   { grades[5,0], grades[5,1], grades[5,2],grades[5,3],grades[5,4] },
                                   { grades[6,0], grades[6,1], grades[6,2],grades[6,3],grades[6,4] },
                                   { grades[7,0], grades[7,1], grades[7,2],grades[7,3],grades[7,4] },
                                   { grades[8,0], grades[8,1], grades[8,2],grades[8,3],grades[8,4] },
                                   { grades[9,0], grades[9,1], grades[9,2],grades[9,3],grades[9,4] } };
            GradeBook myGradeBook = new GradeBook(gradesArray);
            myGradeBook.ProcessGrades();

        }
    }
}
