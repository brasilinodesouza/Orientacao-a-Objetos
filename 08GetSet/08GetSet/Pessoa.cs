using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08GetSet
{
    internal class Pessoa
    {
        // Atributo nome
        private string nome;

        // Get e Set
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

    }
}
