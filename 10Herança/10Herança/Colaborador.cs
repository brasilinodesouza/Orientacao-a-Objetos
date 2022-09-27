using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Herança
{
    internal class Colaborador : Pessoa
    {

        //Atributos
        private double salario;

        //construtor
        public Colaborador(string nome, int idade, double salario)
        {
            this.nome = nome;
            this.idade = idade; 
            this.salario = salario;

            mensagemPessoa();
            mensagemColaborador();

        }

        //Metodo
        private void mensagemColaborador()
        {
            Console.WriteLine("Salario: "+salario);
        }


    }
}
