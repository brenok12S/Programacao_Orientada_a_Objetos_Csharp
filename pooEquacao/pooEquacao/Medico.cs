using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooEquacao
{
    public class Medico
    {
        public Medico()
        {
            this.MedicoDeGuerra = " ";
            this.Level = 0;
        }

        private int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        private  string medicoDeGuerra;

        public  string MedicoDeGuerra
        {
            get { return medicoDeGuerra; }
            set { medicoDeGuerra = value; }
        }

        public void ExibirDados()
        {
            Console.WriteLine(MedicoDeGuerra + " é um medico de guerra com level " + Level);
        }

        public void CuidarDeUmAliado()
        {
            Console.WriteLine(MedicoDeGuerra + " está cuidando de um companheiro de equipe");
            Console.WriteLine("Companheiro de equipe recupera 100 de HP");
        }

    }       
}
