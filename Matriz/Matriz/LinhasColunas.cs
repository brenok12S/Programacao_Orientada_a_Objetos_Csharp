using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    public class LinhasColunas
    {

        public LinhasColunas()
        {
            this.Linha = 0;
            this.Coluna = 0;
        }

        public LinhasColunas(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }

        private int linha;

        public int Linha
        {
            get { return linha; }
            set { linha = value; }
        }

        private int coluna;

        public int Coluna
        {
            get { return coluna; }
            set { coluna = value; }
        }

        public void ExibirMatriz()
        {
            int[,] mat = new int[this.Linha, this.Coluna];

            for (int i = 0; i < this.Linha; i++)
            {
                for (int j = 0; j < this.Coluna; j++)
                {
                    Console.Write("Elemento[" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("MATRIZ DIGITADA: ");
            for (int i = 0; i < this.Linha; i++)
            {
                for (int j = 0; j < this.Coluna; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }

                Console.WriteLine();

            }

        }

    }
}
