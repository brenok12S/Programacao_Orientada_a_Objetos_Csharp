using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta Equacao = new Conta();

            Equacao.A = int.Parse(Console.ReadLine());
            Equacao.B = int.Parse(Console.ReadLine());
            Equacao.C = int.Parse(Console.ReadLine());

            Equacao.ExibirConta();

            Console.ReadKey();
                
        }
    }
}
