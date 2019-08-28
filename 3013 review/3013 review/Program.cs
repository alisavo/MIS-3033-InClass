using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3013_review
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conditionals
            
            string firstName = "jhsfd";
            
            if(firstName.Length % 3==0)
            {
                Console.WriteLine("Fizz");
            }

            if(firstName.Length % 5==0)
            {
                Console.WriteLine("Buzz");

            }

            if(firstName.Length%5==0 && firstName.Length % 3==0)
            {
                Console.WriteLine("FizzBuzz");
            }


            Console.ReadKey();
        }
    }
}
