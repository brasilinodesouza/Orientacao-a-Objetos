using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Abstração
{
    abstract class Padrao
    {
        //Obrigatorio
        public abstract void taxaEmprestimo(double valor);

        // Opcional
        public void calculoPoupanca(double valor, double taxa)
        {
            Console.WriteLine("Ganhos poupanca "+(valor*taxa));

        }




    }
}
