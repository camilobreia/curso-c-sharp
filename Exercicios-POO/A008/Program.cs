// MÉTODOS GET / SET

namespace A008
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Pessoa p = new Pessoa();
             p.Nome = "Maggie"; // estamos enviando o valor com o SET
             Console.WriteLine(p.Nome); // estamos recebendo o valor com o GET 

            
        }
    }
}
