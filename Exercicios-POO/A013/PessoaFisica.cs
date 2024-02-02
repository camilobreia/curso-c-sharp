using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A013
{
    class PessoaFisica : Padrao
    {
        // tem que chamar o método obrigatório senão dá erro
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine($"Taxa de Empréstimo para Pessoa Física de {valor * 0.1}");
        }
    }
}
