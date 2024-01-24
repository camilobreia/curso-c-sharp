using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A011
{
    internal class Gerente : Imposto // HERANÇA
    {
        // Método
        public override void valeAlimentacao(double salario) // OVERRIDE => estou sobrescrevendo o método padrão
        {
            Console.WriteLine($"Desconto gerente do vale alimentação R${salario * 0.15}");
            // com isso sobrescrevemos o desconto padrão de alimentação
        }
    }
}
