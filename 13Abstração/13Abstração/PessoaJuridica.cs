using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Abstração
{
    internal class PessoaJuridica : Padrao
    {
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine("Taxa pessoa juridica R$ " + (valor * 0.2));
        }





    }
}
