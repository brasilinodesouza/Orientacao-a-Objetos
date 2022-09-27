using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Herança
{
    internal class Pessoa
    {
        // Atributos

        protected string nome;
        protected int idade;

        // Metodo
        protected void mensagemPessoa()
        {
            Console.WriteLine("Nome: "+nome);
            Console.WriteLine("Idade: "+idade);
        }


    }
}
