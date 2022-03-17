using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooAnimaisDeEstimacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Animal a3 = new Animal();
            Animal a4 = new Animal();
            Animal a5 = new Animal();

            int tlCachrro = 0, tlGato = 0, tlPeixe = 0;

            Console.Write("Informe o nome do 1ª animal: ");
            a1.Nome = Console.ReadLine();
            Console.Write("Informe o tipo(Cachorro, Gato ou Peixe): ");
            a1.Tipo = Console.ReadLine();
            

            if (a1.Tipo == "Cachorro") tlCachrro++;
            if (a1.Tipo == "Gato") tlGato++;
            if (a1.Tipo == "Peixe") tlPeixe++;

            Console.Write("Informe o nome do 2ª animal: ");
            a2.Nome = Console.ReadLine();
            Console.Write("Informe o tipo(Cachorro, Gato ou Peixe): ");
            a2.Tipo = Console.ReadLine();

            if (a2.Tipo == "Cachorro") tlCachrro++;
            if (a2.Tipo == "Gato") tlGato++;
            if (a2.Tipo == "Peixe") tlPeixe++;

            Console.Write("Informe o nome do 3ª animal: ");
            a3.Nome = Console.ReadLine();
            Console.Write("Informe o tipo(Cachorro, Gato ou Peixe): ");
            a3.Tipo = Console.ReadLine();

            if (a3.Tipo == "Cachorro") tlCachrro++;
            if (a3.Tipo == "Gato") tlGato++;
            if (a3.Tipo == "Peixe") tlPeixe++;

            Console.Write("Informe o nome do 4ª animal: ");
            a4.Nome = Console.ReadLine();
            Console.Write("Informe o tipo(Cachorro, Gato ou Peixe): ");
            a4.Tipo = Console.ReadLine();

            if (a4.Tipo == "Cachorro") tlCachrro++;
            if (a4.Tipo == "Gato") tlGato++;
            if (a4.Tipo == "Peixe") tlPeixe++;

            Console.Write("Informe o nome do 5ª animal: ");
            a5.Nome = Console.ReadLine();
            Console.Write("Informe o tipo(Cachorro, Gato ou Peixe): ");
            a5.Tipo = Console.ReadLine();
            Console.WriteLine();

            if (a5.Tipo == "Cachorro") tlCachrro++;
            if (a5.Tipo == "Gato") tlGato++;
            if (a5.Tipo == "Peixe") tlPeixe++;

            Console.WriteLine($"Cachorros: {tlCachrro}");
            Console.WriteLine();

            Console.WriteLine($"Gatos: {tlGato}");
            Console.WriteLine();

            Console.WriteLine($"Peixes: {tlPeixe}");
            Console.WriteLine();

            int total = tlCachrro + tlGato + tlPeixe;

            Console.WriteLine($"Total de animais: {total}");
            Console.ReadKey();



        }
    }
}
