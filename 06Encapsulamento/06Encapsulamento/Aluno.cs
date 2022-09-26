using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Encapsulamento
{
    internal class Aluno
    {
        // Atributos
        private double nota1, nota2;
        
        // Media
        private double media()
        {
            return (nota1 + nota2) / 2;
        }

        // Mensagem
        public void mensagem()
        {
            Console.Write("Informe a nota 1: ");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe a nota 2: ");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Media é: "+media());


        }


    }
}
