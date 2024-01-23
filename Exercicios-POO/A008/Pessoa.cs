using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A008
{
    internal class Pessoa
    {
        private string nome;
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome=value; //vai pegar o valor que o usuário vai informar em outra classe
            }
        }

    }
}
