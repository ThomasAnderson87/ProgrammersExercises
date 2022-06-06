using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisePrimitivesTypes
{
    internal class Exercise06
    {
        public Exercise06() 
        {
            Console.Write("Digite seu peso em metros:");
            float height = float.Parse(Console.ReadLine());

            float idealWeight = (float)(72.7 * height) - 58;

            Console.WriteLine($"Seu peso ideal é {idealWeight}.\n");         

        }
    }
}
