using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPolimorfismoHeranca
{
    internal class FuncionarioN1 : Funcionarios
    {

        // Polimorfismo
        public override double ParticipacaoLucro()
        {
            return base.ParticipacaoLucro() * 0.1;
        }

    }
}
