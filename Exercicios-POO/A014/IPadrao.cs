using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A014
{
    interface IPadrao
    {
        // INTERFACE SOMENTE PERMITE MÉTODOS OBRIGATÓRIOS
        void somar(int n1, int n2); // não precisa definir se é public, pois por padrão INTERFACE SERÁ PUBLIC

        void subtrair(int n1, int n2);
    }
}
