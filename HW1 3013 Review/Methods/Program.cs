using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static double LineValueForY(double m, double x, double b)
        {
            double Y;
            Y = (m * x) + b;
            return Y;
        }

        static void Main(string[] args)
        {
            double inputSlope, xValue, yValue;
            double yIntercept;
            Console.WriteLine("What is the value of your slope? ");
            inputSlope = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the value of x?");
            xValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the value of your Y-Intercept? ");
            yIntercept = Convert.ToDouble(Console.ReadLine());

            yValue = LineValueForY(inputSlope, xValue, yIntercept);
            Console.WriteLine($"Y= {yValue}");










            Console.ReadKey();

        }


    }

}
