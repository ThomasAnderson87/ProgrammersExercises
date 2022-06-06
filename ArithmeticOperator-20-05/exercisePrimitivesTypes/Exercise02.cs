using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisePrimitivesTypes
{
    public class Exercise02
    {
        public Exercise02()
        {
            float real = 5.26F;

            Console.Write("Digite o valor de euros a serem convertidos:  ");
            float euro = float.Parse(Console.ReadLine());
            float euroInReal = real * euro;
            
            Console.WriteLine(" ");
            Console.WriteLine($"{euro, 1:C} euros equivale a {euroInReal, 1:C} em reais. \n");
        }
    }
}
