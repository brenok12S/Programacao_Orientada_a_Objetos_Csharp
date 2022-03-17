using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAbstracao
{
    internal class PessoaJuridica : Padrao
    {
        public override void ExibirTaxaEmprestimo(double valor)
        {
            Console.WriteLine("Taxa de empréstimo para pessoa Jurídica R$ " + (valor * 0.2));
        }
    }
}
