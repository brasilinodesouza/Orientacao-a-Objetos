using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();

            obj.apresentar();
            obj.apresentar("Neto");
            obj.apresentar("Neto", 30);



        }
    }
}
