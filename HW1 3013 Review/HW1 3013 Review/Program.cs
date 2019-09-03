using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_3013_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            double cogsWholeSale = 79.99;
            double gearsWholeSale = 250.00;
            double standardMarkUp = 0.15;
            double specialMarkUp = 0.125;
            double saleTax = 0.89;
            double cogPrice, gearPrice, taxAmount;
            double total;
            int numOfCogs;
            int numOfGears;
        
            Console.WriteLine("Please enter number of cogs: ");
            numOfCogs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter number of gears: ");

            numOfGears = Convert.ToInt32(Console.ReadLine());



            if (numOfCogs >= 10 || numOfGears >= 10 || numOfGears + numOfCogs >= 16)

            {

                cogPrice = (numOfCogs * cogsWholeSale) - (numOfCogs * cogsWholeSale * specialMarkUp);

                gearPrice = (numOfGears * gearsWholeSale) - (numOfGears * gearsWholeSale * specialMarkUp);



                //  Console.WriteLine($"Your Cog Price before tax will be: {cogPrice}");

                //  Console.WriteLine($"Your Gear Price before tax will be: {gearPrice}");

            }

            else

            {

                cogPrice = (numOfCogs * cogsWholeSale) - (numOfCogs * cogsWholeSale * standardMarkUp);

                gearPrice = (numOfGears * gearsWholeSale) - (numOfGears * gearsWholeSale * standardMarkUp);



                //Console.WriteLine($"Your Cog Price before tax will be: {cogPrice}");

                //Console.WriteLine($"Your Gear Price before tax will be: {gearPrice}");

            }



            //Calculate

            taxAmount = ((cogPrice + gearPrice) * saleTax);

            total = (cogPrice + gearPrice) + taxAmount;



            Console.WriteLine($"Your Cog Price before tax will be: {cogPrice}");

            Console.WriteLine($"Your Gear Price before tax will be: {gearPrice}");

            Console.WriteLine($"Your Tax amount is (8.9%): {taxAmount}");

            Console.WriteLine($"Your total purchase is: {total}");



            Console.ReadKey();
        }
    }
}
