using System;

namespace MaiorIdade
{
    public class Pessoa
    {

        public Pessoa()
        {
            this.Nome = "";
            this.Idade = 0;
        }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        private int idade;

        public int Idade
        {
            get { return idade; }
            set
            {
                if (value >= 0) { idade = value; }
                else { this.Idade = 0; }
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Idade: " + this.Idade);
        }

    }
}
