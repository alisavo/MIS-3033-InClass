using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Adam";
            int counter = 0;
            string wordWithHyphen="";
            while(counter < word.Length)
            {
                if(counter==word.Length-1)
                {
                    Console.Write(word[counter] + "-");
                    wordWithHyphen += word[counter] + "-";
                }

                else
                {
                    Console.Write(word[counter] + "-");
                    wordWithHyphen += word[counter] + "-";
                }
                
                
                
                // (+=) = wordWithHyphen = wordWithHyphen + word[counter] + "-";
                counter++;
            }

            for(int i=word.Length-1; i>=0; i--)
            {
                Console.Write(word[i]);
            }

            Console.WriteLine("\n" + wordWithHyphen);
            Console.ReadKey();
        }
    }
}
