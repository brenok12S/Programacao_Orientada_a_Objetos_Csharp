using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAbstracao
{
    internal class PessoaFisica : Padrao
    {
        public override void ExibirTaxaEmprestimo(double valor)
        {
            Console.WriteLine("Taxa de empréstimo para pessoa Física R$ " + (valor * 0.1));
        }
        

        
    }
}
