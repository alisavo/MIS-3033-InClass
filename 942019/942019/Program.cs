using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _942019
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            today.AddDays(26);
            DateTime future = today.AddDays(27);

            Console.WriteLine(today);
            Console.WriteLine(future);
            Console.WriteLine(today.ToLongDateString());

            var difference = future - today;
            Console.WriteLine(difference.Days);  //.days makes it the difference in days, without it it would be 27:00:00



            Console.ReadKey();
        }
    }
}
