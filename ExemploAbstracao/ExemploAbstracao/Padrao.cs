using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAbstracao
{
    public abstract class Padrao
    {
        
        
            // Obrigatorio
            public abstract void ExibirTaxaEmprestimo(double valor);

            // Opcional

            public void CalcularPoupanca(double valor, double taxa)
            {
                Console.WriteLine("Ganhos obtidos pela poupança RS" + (valor * taxa));
            }
        
    }
}
