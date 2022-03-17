using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooEquacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medico m1 = new Medico();

            m1.MedicoDeGuerra = "Breno";
            m1.Level = 50;

            m1.ExibirDados();
            m1.CuidarDeUmAliado();

          

            Atirador a1 = new Atirador();

            a1.AtiradorDeElite = "Jotaro";
            a1.Level = 45;

            a1.ExibirAtirador();

            a1.DistanciaTiro = 5000;

           

            Console.ReadKey();


        }
    }
}
