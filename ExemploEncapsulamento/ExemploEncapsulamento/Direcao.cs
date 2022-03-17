using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEncapsulamento
{
    public class Direcao
    {

        private string Nome;

        private char Sexo;

        private int Idade;

        private double N1, N2;

        private double media()
        {
            return (N1 + N2) / 2;
        }

        public void ExbibirMensagem()
        {
            Console.Write("Informe seu nome: ");
            Nome = Console.ReadLine();

            Console.Write("Informe o seu gênero: ");
            Sexo = char.Parse(Console.ReadLine());

            Console.Write("Informe a sua idade: ");
            Idade = int.Parse(Console.ReadLine());

            Console.Write("Informe a primeira nota: ");
            N1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a segunda nota: ");
            N2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"MEDIA = {media()} ");

        }

    }
}
