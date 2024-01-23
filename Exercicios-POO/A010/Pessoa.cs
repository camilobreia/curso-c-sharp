using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A010
{
    internal class Pessoa
    {
        // atributo ou método protect (apenas a classe que cria e classe que herda podem acessar)

        // Atributos/Propriedades:
        protected string nome;
        protected int idade;

        //Método:
        protected void mensagemPessoa()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
        }
        
    }
}
