using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisePrimitivesTypes
{
    internal class Exercise05
    { 
        public Exercise05()
        {
            float farenheit, celsius;

            Console.Write("Digite a temperatura em Farenheit para ser convertida: ");
            farenheit = float.Parse(Console.ReadLine());

            celsius = ((farenheit - 32) * 5) / 9;

            Console.WriteLine($"{farenheit} Farenheit equivalem a {celsius} Celsius.\n");

        }
    }
}
