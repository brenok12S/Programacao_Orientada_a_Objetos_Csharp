using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPolimorfismoHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FuncionarioN1 n1 = new FuncionarioN1();
            n1.Nome = "Breno";
            n1.Sexo = 'M';
            n1.Idade = 23;

            FuncionarioN2 n2 = new FuncionarioN2();
            n2.Nome = "Sabrina";
            n2.Sexo = 'F';
            n2.Idade = 21;

            FuncionarioN3 n3 = new FuncionarioN3();
            n3.Nome = "Carla";
            n3.Sexo = 'F';
            n3.Idade = 26;

            Console.WriteLine($"Nome: {n1.Nome}\nSEXO: {n1.Sexo}\nIdade: {n1.Idade}\nParticipação: {n1.ParticipacaoLucro().ToString("F2")}\n\n");
            Console.WriteLine($"Nome: {n2.Nome}\nSEXO: {n2.Sexo}\nIdade: {n2.Idade}\nParticipação: {n2.ParticipacaoLucro().ToString("F2")}\n\n");
            Console.WriteLine($"Nome: {n3.Nome}\nSEXO: {n3.Sexo}\nIdade: {n3.Idade}\nParticipação: {n3.ParticipacaoLucro().ToString("F2")}\n\n");

            Console.ReadKey();

        }
    }
}
