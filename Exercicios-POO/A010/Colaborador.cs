using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A010
{
    internal class Colaborador : Pessoa // para utilizar HERANÇA utilizamos : + o nome da classe que herdará
    {
        // Atributo:
        private double salario;

        // Método construtor:
        public Colaborador(string nome, int idade, double salario)
        {
            this.nome = nome; // caso não tivesse feito HERANÇA este atributo não conseguiria ser acessado
            this.idade = idade; // caso não tivesse feito HERANÇA este atributo não conseguiria ser acessado
            this.salario = salario;

            mensagemPessoa();
            mensagemColaborador();
        }

        // Método:
        private void mensagemColaborador()
        {
            Console.WriteLine($"Salário: {salario}");
        }
    }
}
