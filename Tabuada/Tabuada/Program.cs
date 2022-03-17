using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EfetuaTabuada t1 = new EfetuaTabuada();

            t1.Multiplicador = int.Parse(Console.ReadLine());

            t1.ExibirTabuada();

            Console.ReadKey();
        }

        
    }
}
