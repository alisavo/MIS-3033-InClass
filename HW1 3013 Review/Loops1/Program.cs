using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            int examGrades, studentAverage=0;
            int studentScore;

            for (examGrades=1; examGrades<=3; examGrades++)
            {
                Console.Write("Please enter your exam score: ");
                studentScore = Convert.ToInt32(Console.ReadLine());
                studentAverage = (studentScore+studentScore+studentScore)/3;
            }

            Console.WriteLine($"Your average exam grade is: {studentAverage}%");

            Console.ReadKey();

        }
    }
}
