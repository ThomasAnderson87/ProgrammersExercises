using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisePrimitivesTypes
{
    public class Exercise01
    {
        public Exercise01()
        {
            Console.Write("Digite a idade do mais joven da turma: ");
            float minAge = float.Parse(Console.ReadLine());


            Console.Write("Digite a idade do mais joven da turma: ");
            float maxAge = float.Parse(Console.ReadLine());


            float ageRate = ((minAge + maxAge) / 2);

            Console.WriteLine(" ");
            Console.WriteLine($"A média de idades é {ageRate, 1:F}.\n");
        }
    }
}
