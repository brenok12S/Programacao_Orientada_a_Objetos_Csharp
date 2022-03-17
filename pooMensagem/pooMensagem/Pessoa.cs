using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
	public class Pessoa
	{
		private int anoNascimento;

		public int AnoNascimento
		{
			get { return this.anoNascimento; }
			set { this.anoNascimento = value; }
		}

		private string nome;

		public string Nome
		{
			get { return nome; }
			set { nome = value.ToUpper(); }
		}

		// Vamos Melhorar

		private int idade;

		public int Idade
		{
			get { return this.idade; }
		}


		public void ExibirDados()
		{
			Console.WriteLine("Nome: " + this.Nome);
			Console.WriteLine("Ano de Nascimento: " + this.AnoNascimento);
			this.CalcularIdade();
			Console.WriteLine("Idade: " + this.Idade);
		}

		private void CalcularIdade()
		{
			DateTime data = DateTime.Now;
			int ano = data.Year;
			this.idade = ano - this.anoNascimento;
		}

	}
}
