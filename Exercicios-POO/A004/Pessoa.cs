using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A004
{
    internal class Pessoa
    {
        public double peso;
        public double altura;

        public double imc()
        {
            return peso / (altura * altura);
        }

        public void mensagem()
        {
            double obterImc = imc();

            if (obterImc < 18.5)
            {
                Console.WriteLine($"Seu IMC é {Math.Round(obterImc, 3)} e você está Abaixo do Peso.");
            }
            else if ((obterImc >= 18.5) && (obterImc < 25))
            {
                Console.WriteLine($"Seu IMC é {Math.Round(obterImc, 3)} e você está no Peso Normal.");
            }
            else if ((obterImc >= 25) && (obterImc < 30))
            {
                Console.WriteLine($"Seu IMC é {Math.Round(obterImc, 3)} e você está Acima do Peso.");
            }
            else if ((obterImc >= 30) && (obterImc < 35))
            {
                Console.WriteLine($"Seu IMC é {Math.Round(obterImc, 3)} e você está com Obesidade nível I.");
            }
            else if ((obterImc >= 35) && (obterImc < 40))
            {
                Console.WriteLine($"Seu IMC é {Math.Round(obterImc, 3)} e você está com Obesidade nível II.");
            }
            else
            {
                Console.WriteLine($"Seu IMC é {Math.Round(obterImc, 3)} e você está com Obesidade nível III.");
            }
        }
    }
}
