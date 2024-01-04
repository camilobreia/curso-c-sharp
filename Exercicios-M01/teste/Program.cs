double n = 2.1;
int n1 = Convert.ToInt16(n);
int n2 = (int)n;
Console.WriteLine(n2);
Console.WriteLine(n1);

Console.WriteLine("-----------------------------");

Console.WriteLine($"A parte inteira do número é {Math.Floor(n)}");
Console.WriteLine($"Arredondando, temos o número {Math.Ceiling(n)}");

