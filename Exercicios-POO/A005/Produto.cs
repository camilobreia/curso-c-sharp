using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace A005
{
    internal class Produto
    {
        /* Modificadores de acesso: é a maneira que temos de visualizar um atributo (propriedade) ou método
         * 
         * public -> Atributos e métodos visíveis em qualquer classe
         * private -> Atributos e métodos visíveis apenas na classe onde são criados
         * protected -> Atributos e métodos visíveis em classes onde são criados ou herdados (herança)
         * 
         */

        public string nome;
        private double valor;

    }
}
