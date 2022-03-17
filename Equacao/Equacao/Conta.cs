using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equacao
{
    public class Conta
    {
        public Conta()
        {
            this.A = 0;
            this.B = 0;
            this.C = 0;
        }

        public Conta(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        private int a;

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        private int b;

        public int B
        {
            get { return b; }
            set { b = value; }
        }

        private int c;

        public int C
        {
            get { return c; }
            set { c = value; }
        }

        public void ExibirConta()
        {
            int delta;

            double bhaskaraPositivo, bhaskaraNegativo; 

            delta = (this.B * this.B) - 4 * (this.A * this.C);
            Console.WriteLine("DELTA: " + delta);

            bhaskaraPositivo = (-this.B + Math.Sqrt(delta)) / (2 * this.A);
            Console.WriteLine("X': " + bhaskaraPositivo);

            bhaskaraNegativo = (-this.B - Math.Sqrt(delta)) / (2 * this.A);
            Console.WriteLine("X'': " + bhaskaraNegativo);
        }

    }
}
