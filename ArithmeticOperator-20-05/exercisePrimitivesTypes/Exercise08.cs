using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisePrimitivesTypes
{
    internal class Exercise08
    {
        public Exercise08()
        {
            Console.Write("Digite o primeiro valor a ser subtraido: ");
            float num01 = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor a ser subtraido: ");
            float num02 = float.Parse(Console.ReadLine());

            float total = num01 - num02;

            Console.WriteLine($"O total é {total}.\n");

            if (total >= 0)
            {
                Console.WriteLine("TOTAL POSITIVO.\n");
            }
            else
            {
                Console.WriteLine("TOTAL NEGATIVO.\n");
            }

        }
    }
}
