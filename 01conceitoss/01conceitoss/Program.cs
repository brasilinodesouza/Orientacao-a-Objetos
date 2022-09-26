using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01conceitoss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciar o objeto

            Pessoa p = new Pessoa();

            Console.Write("Nome: ");
            p.nome = Console.ReadLine();

            Console.Write("Idade:");
            p.idade =int.Parse(Console.ReadLine());

            p.mensagem();

        }
    }
}
