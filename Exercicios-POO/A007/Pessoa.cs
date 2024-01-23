using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A007
{
    internal class Pessoa
    {
        public Pessoa()
        {
            Console.WriteLine("Construtor Executado");
        }
        public Pessoa(string nome)
        {
            Console.WriteLine($"Olá {nome}");
        }
    }
}
