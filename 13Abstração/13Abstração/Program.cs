using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Abstração
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.taxaEmprestimo(1000);

            Console.WriteLine("------------------------");

            PessoaJuridica pj = new PessoaJuridica();
            pj.taxaEmprestimo(1000);



        }
    }
}
