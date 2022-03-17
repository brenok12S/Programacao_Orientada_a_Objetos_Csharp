using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaluloDistancia
{
    internal class Calculo
    {

        public Calculo()
        {
            this.Xa = 0;
            this.Xb = 0;
            this.Ya = 0;
            this.Yb = 0;
        }

        public Calculo(int xa, int xb, int ya, int yb )
        {
            this.Xa = xa;
            this.Xb = xb;
            this.Ya = ya;
            this.Yb = yb;
        }

        private int xa;

        public int Xa
        {
            get { return xa; }
            set { xa = value; }
        }

        private int xb;

        public int Xb
        {
            get { return xb; }
            set { xb = value; }
        }

        private int ya;

        public int Ya
        {
            get { return ya; }
            set { ya = value; }
        }

        private int yb;

        public int Yb
        {
            get { return yb; }
            set { yb = value; }
        }

        public void ExibirResposta()
        {
            double distanciaXY, diferencaX, diferencaX2, diferencaY, diferencaY2, distanciaResultado;

            diferencaX = (this.Xb - this.Xa);
            diferencaX2 = diferencaX * diferencaX;

            diferencaY = (this.Yb - this.Ya);
            diferencaY2 = diferencaY * diferencaY;

            distanciaXY = diferencaX2 + diferencaY2;

            distanciaResultado = Math.Sqrt(distanciaXY);

            Console.WriteLine("DISTANCIA: " + distanciaResultado);
        }

    }
}
