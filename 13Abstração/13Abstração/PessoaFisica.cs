using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Abstração
{
    internal class PessoaFisica : Padrao
    {
        //Metodo obrigatorio

        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine("Taxa pessoa fisica R$ "+(valor*0.1));
        }




    }
}
