using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04ExercicioIMC
{
    internal class Pessoa
    {
        public string nome;
        public double peso;
        public double altura;

        public double calculo()
        {
            return peso / (altura * altura);
        }
        public string resultadoIMC(double imc)
        {
            string retorno;

            if (imc < 18.5)
            {
                retorno = "Abaixo do peso";
            }
            else if ( imc <= 25 )
            {
                retorno = "Peso normal";
            }
            else if (imc <= 30)
            {
                retorno = "Acima do eso";
            }
            else if (imc <= 35)
            {
                retorno = "Obesidade1";
            }
            else if (imc <= 40 )
            {
                retorno = "Obesidade2";
            }
            else
            {
                retorno = "Obesidade3";
            }

            return retorno;
        }

        public void mensagem()
        {
            double obterCalculo = calculo();

            string obterSituacao = resultadoIMC(obterCalculo);

            Console.WriteLine("Seu imc é de: " +obterCalculo);
            Console.WriteLine("Sua situacao é de: " + obterSituacao);
        }
    }
}
