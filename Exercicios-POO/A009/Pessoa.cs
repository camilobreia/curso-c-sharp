using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A009
{
    internal class Pessoa
    {
        private string nome = "Analu";

        public Pessoa(string nome)
        {
            Console.WriteLine(nome);
            Console.WriteLine(this.nome); // this serve para "ligar" o atributo/propriedade ao método
        }
    }
}
