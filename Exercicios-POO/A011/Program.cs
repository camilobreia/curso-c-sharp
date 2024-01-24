namespace A011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciar Estagiário
            Imposto objetoE = new Estagiario();
            // o objetoE vai ter acesso ao valeAlimentacao e valeTransporte da classe Imposto e se o estagiário tiver
            // algum método diferente, ele sobrescreverá o método que estiver na classe Imposto
            objetoE.valeAlimentacao(1000);
            objetoE.valeTransporte(1000);
            Console.WriteLine("--------------------------------------");

            // Instanciar Gerente
            Imposto objetoG = new Gerente();
            objetoG.valeAlimentacao(1000);
            objetoG.valeTransporte(1000);
            Console.WriteLine("--------------------------------------");


            // Instanciar Atendente
            Imposto objetoA = new Atendente();
            objetoA.valeAlimentacao(1000);
            objetoA.valeTransporte(1000);
        }
    }
}
