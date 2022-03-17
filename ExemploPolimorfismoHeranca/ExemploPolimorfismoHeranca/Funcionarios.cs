using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPolimorfismoHeranca
{
    internal class Funcionarios
    {
        public string Nome { get; set; }

        public char Sexo { get; set; }

        public int Idade { get; set; }

        // Virtual deixa sobrescrever os metodos
        public virtual double ParticipacaoLucro()
        {
            return 12000;
        }
    }
}
