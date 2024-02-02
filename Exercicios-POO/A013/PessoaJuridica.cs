using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A013
{
    class PessoaJuridica : Padrao
    {
        // tem que chamar o método obrigatório da classe padrão, senão dá erro
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine($"Taxa de Empréstimo para Pessoa Jurídica {valor * 0.2}");
        }
    }
}
