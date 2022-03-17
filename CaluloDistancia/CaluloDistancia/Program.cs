using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaluloDistancia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculo c1 = new Calculo();

            c1.Xa = int.Parse(Console.ReadLine());
            c1.Xb = int.Parse(Console.ReadLine());
            c1.Ya = int.Parse(Console.ReadLine());
            c1.Yb = int.Parse(Console.ReadLine());

            c1.ExibirResposta();

            Console.ReadKey();
        }
    }
}
