using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooAreaDeRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.Write("Informe a base: ");
            retangulo.BaseRet = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a altura: ");
            retangulo.AlturaRet = Convert.ToDouble(Console.ReadLine());
            retangulo.ExibirDados();
            Console.ReadKey();



        }
    }
}
