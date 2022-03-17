using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Programa que calcula a idade de uma pessoa");
			Console.WriteLine();

			Pessoa p1 = new Pessoa();

			Console.Write("Informe seu nome: ");
			p1.Nome = Console.ReadLine();
			Console.Write("Informe o seu ano de nascimento: ");
			p1.AnoNascimento = Convert.ToInt32(Console.ReadLine());
			p1.ExibirDados();
			Console.ReadKey();

		}
	}
}
