using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    public class EfetuaTabuada
    {

        public EfetuaTabuada()
        {
            this.Multiplicador = 0;
            this.Contador = 0;
        }

        public EfetuaTabuada(int multiplicador, int contador)
        {
            this.Multiplicador = multiplicador;
            this.Contador = contador;
        }

        private int multiplicador;

        public int Multiplicador
        {
            get { return multiplicador; }
            set { multiplicador = value; }
        }

        private int contador;

        public int Contador
        {
            get { return contador; }
            set { contador = value; }
        }

        public void ExibirTabuada()
        {
            Console.WriteLine();

            for (this.Contador = 0; this.Contador <= 10; this.Contador++)
            {
                Console.WriteLine(this.Multiplicador + "X" + this.Contador + "=" + this.Multiplicador * this.Contador);
            }
        }



    }
}
