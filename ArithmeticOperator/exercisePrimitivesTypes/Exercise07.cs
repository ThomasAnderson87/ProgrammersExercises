using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisePrimitivesTypes
{
    internal class Exercise07
    {
        public Exercise07()
        {
            Console.Write("Digite sua primeira nota: ");
            float grade01 = float.Parse(Console.ReadLine());
            Console.Write("Digite sua segunda nota: ");
            float grade02 = float.Parse(Console.ReadLine());
            Console.Write("Digite sua terceira nota: ");
            float grade03 = float.Parse(Console.ReadLine());
            Console.Write("Digite sua quarta nota: ");
            float grade04 = float.Parse(Console.ReadLine());

            float rate = (grade01 + grade02 + grade03 + grade04) / 4;

            Console.WriteLine($"Sua média é {rate}");

            if (rate >= 7)
            {
                Console.WriteLine("Você foi aprovado\n");
            }
            else
            {
                Console.WriteLine("Você foi reprovado\n");
            }

        }
    }
}
