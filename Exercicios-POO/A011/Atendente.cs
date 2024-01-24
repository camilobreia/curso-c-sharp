using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A011
{
    internal class Atendente : Imposto // HERANÇA
    {
        public override void valeAlimentacao(double salario) // OVERRIDE => estou sobrescrevendo o método padrão
        {
            Console.WriteLine($"Desconto atendente do vale alimentação R${salario * 0.12}");
            // com isso sobrescrevemos o desconto padrão de alimentação
        }
    }
}
