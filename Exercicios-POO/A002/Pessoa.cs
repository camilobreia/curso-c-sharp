using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A002
{
    internal class Pessoa // classe é nome do arquivo e toda classe começa com Letra Maiúscula
    {
        // Método 01
        public void apresentar()
        {
            Console.WriteLine("Olá!");
        }

        // Método 02
        public void apresentar(string nome) // o que está nos parênteses são PARÂMETROS
        {
            Console.WriteLine($"Olá {nome}!");
        }

        // Método 03
        public void apresentar(string nome, int idade)
        {
            Console.WriteLine($"Olá {nome} você tem {idade} anos");
        }


        // podemos ter vários métodos com o mesmo nome, desde que tenham PARÂMETROS DIFERENTES
    }
}
