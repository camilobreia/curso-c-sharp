using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace A003
{
    internal class Aluno
    {
        // Atributos:
        public string nome;
        public double nota1, nota2;

        // Média
        public double media()
        {
            return (nota1 + nota2)/2;
        }

        // Situação        
        public string situacao(double media)
        {
            return media >= 7 ? "APROVADO" : "REPROVADO";
        }

        // Mensagem
        public void mensagem()
        {
            // Obter a média
            double obterMedia = media();

            // Obter a situação
            string obterSituacao = situacao(obterMedia);

            Console.WriteLine($"O aluno {nome} está {obterSituacao} com média {obterMedia}");
        }
    }
}
