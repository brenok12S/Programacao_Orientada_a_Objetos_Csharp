using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAbstracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.ExibirTaxaEmprestimo(1000);

            PessoaJuridica pj = new PessoaJuridica();
            pj.ExibirTaxaEmprestimo(5000);
            

            Console.ReadKey();


        }
    }
}
