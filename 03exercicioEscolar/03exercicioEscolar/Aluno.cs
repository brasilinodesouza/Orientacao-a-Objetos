using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03exercicioEscolar
{
    internal class Aluno
    {
        //atributos
        public string nome;
        public double nota1, nota2;

        //metodos media
        public double media() 
        {
            return (nota1 + nota2) / 2;
        }


        //metodo situacao
        public string situacao(double media)
        {
            return media >= 7 ? "Aprovado" : "Reprovado";
        }


        //metodo mensagem
        public void mensagem()
        {
            //obter media
            double obertMedia = media();

            //obter situacao
            string obtersituacao = situacao(obertMedia);

            //mensagem
            Console.WriteLine(nome+" esta "+obtersituacao+" com a media "+obertMedia);

        }

    }
}
