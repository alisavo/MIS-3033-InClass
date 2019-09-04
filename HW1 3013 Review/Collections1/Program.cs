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
            string[] fruit = { "apple", "orange", "banana", "grapes", "blueberries" };
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
            Console.WriteLine();

            //Array2
            char[] lowercaseLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            Console.WriteLine(Convert.ToString(uppercaseLetters[0]) + lowercaseLetters[11] + lowercaseLetters[8] + lowercaseLetters[18]+lowercaseLetters[0]
                + " " + uppercaseLetters[21]+lowercaseLetters[14]);

            Console.WriteLine();
            //Lists
            List<double> examGrade = new List<double>();
            examGrade.Add(100);
            examGrade.Add(80);
            examGrade.Add(100);
            examGrade.Add(90);



            //Dictionaries
            Dictionary<string, double> fruitPricing = new Dictionary<string, double>();
            fruitPricing.Add("apple", 0.99);
            fruitPricing.Add("orange", 0.50);
            fruitPricing.Add("banana", 0.50);
            fruitPricing.Add("grapes", 2.99);
            fruitPricing.Add("blueberries", 1.99);

            Console.WriteLine("Please choose a fruit (apple, orange, banana, grapes, or blueberries): ");
            userInput = Console.ReadLine();
            Console.WriteLine(fruitPricing[userInput]);


            Console.ReadKey();



        }
    }
}
