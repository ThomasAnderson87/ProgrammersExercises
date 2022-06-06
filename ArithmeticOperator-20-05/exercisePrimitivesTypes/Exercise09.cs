using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisePrimitivesTypes
{
    internal class Exercise09
    {
        public Exercise09()
        {
            Console.Write("Digite o denominador valor: ");
            float denominator = float.Parse(Console.ReadLine());
            
            if (denominator != 0 )
            {                
                Console.Write("Digite o numerador valor: ");
                float numerator = float.Parse(Console.ReadLine());

                float total = numerator / denominator;

                float mod = numerator % denominator;

                Console.WriteLine(" ");
                Console.WriteLine($"O valor da divisão é {total}.");
                Console.WriteLine($"O modulo da divisão é {mod}. \n ");
                
            }
            else
            {
                Console.WriteLine("O seu divisor é igual a zero, não é possivel fazer essa divisão.\n");
            }

        }
    }
}
