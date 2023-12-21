// Exercício 03:

float n;
Console.Write("Digite um número real: ");
float.TryParse(Console.ReadLine(), out n);
Console.WriteLine("-------------------------");
Console.WriteLine($"Você digitou o valor {n:N3}");
Console.WriteLine($"A parte inteira do número é {Math.Floor(n)}");
Console.WriteLine($"Arredondando, temos o número {Math.Ceiling(n)}");

/* Na resolução o professor usou duas variáveis e converteu N para inteiro
 * int n1 = (int) n;
 * int n2 = Convert.ToInt13(n);
 * no CW usou:
 * {n1:D} => para mostrar a parte inteira
 * {n2:D} => para mostrar o arredondamento
 */