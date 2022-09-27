using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estagiario
            Imposto objetoE = new Estagiario();
            objetoE.valeAlimentacao(1000);
            objetoE.valeTransporte(1000);
            Console.WriteLine("---------------------------------");

            //Gerente
            Imposto objetoG = new Gerente();
            objetoG.valeAlimentacao(5000);
            objetoG.valeTransporte(1000);
            Console.WriteLine("---------------------------------");

            //Atendente
            Imposto objetoA = new Atendente();
            objetoA.valeAlimentacao(3000);
            objetoA.valeTransporte(1000);
            Console.WriteLine("---------------------------------");


        }
    }
}
