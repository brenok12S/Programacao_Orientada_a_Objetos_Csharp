using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1;
            Pessoa p2;
            Pessoa p3;

            p1 = new Pessoa();
            Console.Write("Informe o nome da 1ª pessoa: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Informe a idade da 1ª pessoa: ");
            p1.Idade = Convert.ToInt32(Console.ReadLine());

            p2 = new Pessoa();
            Console.Write("Informe o nome da 2ª pessoa: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Informe a idade da 2ª pessoa: ");
            p2.Idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o nome da 3ª pessoa: ");
            string nome = Console.ReadLine();
            Console.Write("Informe a idade da 3ª pessoa: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            p3 = new Pessoa(nome, idade);

            if (p1.Idade > p2.Idade  && p1.Idade > p3.Idade) 
            {
                Console.WriteLine();
                Console.WriteLine("A pessoa mais velha é: ");
                Console.WriteLine();
                p1.ExibirDados();
            }
            else if (p2.Idade > p1.Idade && p2.Idade > p3.Idade) 
            {
                Console.WriteLine();
                Console.WriteLine("A pessoa mais velha é: ");
                Console.WriteLine();
                p2.ExibirDados();
            }
            else if (p3.Idade > p1.Idade && p3.Idade > p2.Idade) 
            {
                Console.WriteLine();
                Console.WriteLine("A pessoa mais velha é: ");
                Console.WriteLine();
                p3.ExibirDados();
            }
            else
            {
                Console.WriteLine("Todas as pessoas tem a mesma idade: ");
            }

            Console.ReadKey();
        }
    }
}
