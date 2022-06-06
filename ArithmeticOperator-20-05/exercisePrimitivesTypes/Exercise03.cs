using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisePrimitivesTypes
{
    internal class Exercise03
    {
        public Exercise03()
        {
            Console.Write("Digite o total de vendas em reais: ");
            float carsSold = float.Parse(Console.ReadLine());
            double sellerCommissionPercent = 0.05;
            double sellerCommission = sellerCommissionPercent * carsSold;

            Console.WriteLine(" ");
            Console.WriteLine($"A comissão do mes de maio do vendedor foi de {sellerCommission,1:C}.\n");

        }
    }
}
