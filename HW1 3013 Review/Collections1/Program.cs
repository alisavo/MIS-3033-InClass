using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array1
            string userInput;
            string[] fruit = { "apple", "orange", "banana", "grape", "blueberries" };
            double[] prices = { 0.99, 0.50, 0.50, 2.99, 1.99 };
            int index;

            Console.WriteLine("Please choose a fruit (apple, orange, banana, grapes or blueberries): ");
            userInput = Console.ReadLine();

            for(index=0;index<=fruit.Length-1;index++)
            {
            //    Console.WriteLine("Please choose a fruit (apple, orange, banana, grapes or blueberries): ");
              //  userInput = Console.ReadLine();


                if (userInput == fruit[index]);
                {
                    Console.WriteLine($"The price of the fruit is ${prices[index]}");
                }

            }



            Console.ReadKey();



        }
    }
}
