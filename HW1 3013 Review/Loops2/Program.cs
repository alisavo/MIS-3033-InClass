using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            double examScore;
            int numTest=0, response=0;
            double test = 0;
            double examAverage;



            while (response<2)
            {
               Console.WriteLine("Please enter your exam score: ");
               examScore = Convert.ToInt32(Console.ReadLine());

                test = test + examScore;
                numTest++;

                Console.WriteLine("Do you have another exam score to enter? Press 1 for Yes or Press 2 for No");
                response = Convert.ToInt32(Console.ReadLine());

                if (response==1)
                {

                   // Console.WriteLine("Please enter exam score: ");

                }
                else if (response==2)
                {
                    Console.WriteLine("Have a nice day!");
                }

            }
            examAverage = test / numTest;
            Console.WriteLine($"Your average exam grade is: {examAverage}");
            Console.ReadKey();
        }
    }
}
