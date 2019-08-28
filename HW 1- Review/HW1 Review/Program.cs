using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            double cogs;
            double gears;

            Console.WriteLine("Please enter number of cogs purchased: ");
            cogs = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter number of gears purchased: ");
            gears = Convert.ToDouble(Console.ReadLine());


            Console.ReadKey();
        }
    }
}
