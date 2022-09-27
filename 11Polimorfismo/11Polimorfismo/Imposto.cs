using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Polimorfismo
{
    internal class Imposto
    {
        //Metodos

        public virtual void valeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto padrão do VA R$ "+(salario *0.1));
        }
        public virtual void valeTransporte(double salario)
        {
            Console.WriteLine("Desconto padrão do VT R$ " + (salario * 0.6));
        }


    }
}
