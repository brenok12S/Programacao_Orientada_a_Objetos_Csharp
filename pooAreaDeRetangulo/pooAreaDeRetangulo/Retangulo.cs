using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooAreaDeRetangulo
{
    public class Retangulo
    {
        public Retangulo()
        {
            this.BaseRet = 0;
            this.AlturaRet = 0;
        }

        // Base do Retângulo
        private double baseRet;

        public double BaseRet
        {
            get { return baseRet; }
            set {
                if (value < 0) { baseRet = 0; }
                else { baseRet = value; } 
            }
        }

        private double alturaRet;

        public double  AlturaRet
        {
            get { return alturaRet; }
            set {
                if( value >= 0 ) { alturaRet = value; }
                else { value = 0;  }
            }
        }

        public double Area
        {
            get { return alturaRet*baseRet; }
        }

        public void ExibirDados()
        {
            Console.WriteLine("Base: " + this.BaseRet);
            Console.WriteLine("Altura: " + this.AlturaRet);
            Console.WriteLine("Area: " + this.Area);
        }
    }
}
