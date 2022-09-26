using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04ExercicioIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            Console.Write("Nome:");
            p.nome = Console.ReadLine();
            Console.Write("Peso:");
            p.peso = double.Parse(Console.ReadLine());
            Console.Write("Altura:");
            p.altura = double.Parse(Console.ReadLine());

            p.mensagem();

        }
    }
}
