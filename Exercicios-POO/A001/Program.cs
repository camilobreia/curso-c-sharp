// Classes, atributos, métodos e objetos

// classes são como moldes, são abstratas e genéricas

namespace A001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciar (criar) um OBJETO:

            Pessoa obj = new Pessoa(); // aqui criamos um objeto chamado obj
            obj.nome = "Maggie";
            obj.idade = 08;
            obj.mensagem();
        }
    }
}
