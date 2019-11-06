using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1022019__pokemon_participation
{
    class PokeInfo
    {
       public int height {get;set;}
        public int weight { get; set; }
        public string name { get; set; }

        public List<Form> Form { get; set; }

        public override string ToString()
        {
            return $"{name} is {height} in tall and weighs {weight} lbs. the forms are {Form}";
        }
    }
    public class Form
    {
        public string name { get; set; }
        public string url { get; set; }

        
    }
}
