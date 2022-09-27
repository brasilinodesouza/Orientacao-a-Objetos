using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07construtor
{
    internal class Pessoa
    {

        // Construtor
        public Pessoa()
        {
            Console.WriteLine("construtor executado");
        }

        public Pessoa(string nome)
        {
            Console.WriteLine("Ola "+nome);
        }


    }
}
