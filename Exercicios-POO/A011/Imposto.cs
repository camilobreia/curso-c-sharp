using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A011
{
    internal class Imposto
    {
        // Métodos
        public virtual void valeAlimentacao(double salario) //usamos VIRTUAL para indicar ao c# que este método pode sofrer modificações
        {
            Console.WriteLine($"Desconto padrão do vale alimentação R${salario * 0.1}");
        }
        public void valeTransporte(double salario)
        {
            Console.WriteLine($"Desconto padrão do vale transporte R${salario * 0.06}");
        }
    }
}
