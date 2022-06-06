using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisePrimitivesTypes
{
    internal class Exercise04
    {
        public Exercise04()
        {
            double farenheit, celsius;

            Console.Write("Digite a temperatura em Celsius para ser convertida: ");
            celsius = Double.Parse(Console.ReadLine());

            farenheit = ((9 * celsius) + 160) / 5;

            Console.WriteLine(" ");
            Console.WriteLine($"{celsius} Celsius equivalem a {farenheit} Farenheit.\n");

        }
    }
}
