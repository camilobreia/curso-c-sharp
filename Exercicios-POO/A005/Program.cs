// Modificadores de Acesso

namespace A005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto obj = new Produto();
            var nome = obj.nome; // somente o atributo NOME é visível
        }
    }
}
