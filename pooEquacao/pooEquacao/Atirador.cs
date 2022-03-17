using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooEquacao
{
    internal class Atirador
    {
        public Atirador()
        {
            this.AtiradorDeElite = " ";
            this.DistanciaTiro = 0;
            this.Level = 0;
        }

        public Atirador(string nome, int distancia, int level)
        {
            this.AtiradorDeElite = nome;
            this.DistanciaTiro = distancia;
            this.Level = level;
        }

        private string atiradorDeElite;

        public string AtiradorDeElite
        {
            get { return atiradorDeElite; }
            set { atiradorDeElite = value; }
        }

        private int distanciaTiro;

        public int DistanciaTiro
        {
            get { return distanciaTiro; }
            set 
            { 
                if (value >= 1000)
                {
                    Console.Write("Tiro de raspão");
                    Console.WriteLine("Inimgo perdeu - 30 HP");
                } else
                {
                    Console.WriteLine("Tiro certeiro");
                    Console.WriteLine("Alvo eliminado com dano critico de 100% com base na vida");
                }

                distanciaTiro = value; 
            }
        }

        private int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }


        public void ExibirAtirador()
        {
            Console.WriteLine(AtiradorDeElite + "é um atirador de elite  com level " + level);
        }


    }
}
