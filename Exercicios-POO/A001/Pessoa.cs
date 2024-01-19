using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A001
{
    internal class Pessoa // aqui é a Classe (super genérica - pessoa)
    {
        // ATRIBUTOS (caracaterísticas que o objeto tem):

        public string nome;

        public int idade;

        // MÉTODOS: (que são funções)

        // void => é nulo (não quer armazenar, somente quer exibir na tela)
        public void mensagem()
        {
            Console.WriteLine($"Olá {nome} você tem {idade} anos"); // a AÇÃO do método/função
        }
    }
}
