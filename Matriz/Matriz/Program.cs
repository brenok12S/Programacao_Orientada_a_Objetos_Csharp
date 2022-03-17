using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinhasColunas matriz1 = new LinhasColunas();
            matriz1.Linha = int.Parse(Console.ReadLine());
            matriz1.Coluna = int.Parse(Console.ReadLine());

            matriz1.ExibirMatriz();

            Console.ReadKey();
        }
    }
}
