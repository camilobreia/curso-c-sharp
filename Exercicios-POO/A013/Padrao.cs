using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A013
{
    abstract class Padrao // classe abstrata
    {
        // Método Obrigatório
        public abstract void taxaEmprestimo(double valor); // observa-se que a regra do negócio ficará a cargo de cada classe (por isso termina em ;)

        // Método Opcional
        public void calculoPoupanca(double valor, double taxa) // método que pode ser usado pela pessoafísica ou pessoajuridica se quiser
        {
            Console.WriteLine($"Ganhos obtidos pela poupança R$ {valor * taxa}");
        }
    }
}
