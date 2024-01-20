using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A006
{
    internal class Aluno
    {
        // Atributos
        private double nota1, nota2;

        // Média

        private double media()
        {
            return (nota1 + nota2) / 2;
        }

        // Mensagem

        public void mensagem()
        {
            Console.WriteLine("Informe a primeira nota do aluno: ");
            double.TryParse(Console.ReadLine(), out nota1);

            Console.WriteLine("Informe a segunda nota do aluno: ");
            double.TryParse(Console.ReadLine(), out nota2);

            Console.WriteLine("A média é "+media());
        }
    }
}
