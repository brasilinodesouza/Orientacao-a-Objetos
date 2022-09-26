using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03exercicioEscolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();



            Console.Write("Nome:");
            aluno.nome = Console.ReadLine();
            Console.Write("Nota1:");
            aluno.nota1 = int.Parse(Console.ReadLine());
            Console.Write("Nota2:");
            aluno.nota2 = int.Parse(Console.ReadLine());
            aluno.mensagem();


        }
    }
}
