using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09This
{
    internal class Pessoa
    {
        // Atributo 
        private string nome = "Mi pelo atributo";

        // Construtor
        public Pessoa(string nome)
        {
            Console.WriteLine(nome);
            Console.WriteLine(this.nome);
        }


    }
}
