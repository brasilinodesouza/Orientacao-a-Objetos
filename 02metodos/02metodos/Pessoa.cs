using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02metodos
{
    internal class Pessoa
    {
        //metodo01
        public void apresentar()
        {

            Console.WriteLine("Ola");
        }



        //metodo02
        public void apresentar(string nome)
        {
            Console.WriteLine("Ola "+nome);

        }


        //metodo03
        public void apresentar(string nome, int idade)
        {
            Console.WriteLine("Ola "+nome+" vc tem "+idade+" anos");

        }

    }
}
