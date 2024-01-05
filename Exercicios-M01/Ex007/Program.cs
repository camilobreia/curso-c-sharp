Random ger = new Random();

int i = 0;
int f = 0;

Console.WriteLine("SORTEADOR DE NÚMERO");
Console.WriteLine("----------------------");
Console.Write("Início: ");
int.TryParse(Console.ReadLine(), out i);
Console.Write("Fim: ");
int.TryParse(Console.ReadLine(), out f);
Console.WriteLine("----------------------");

Console.SetCursorPosition(0, 5);
Console.WriteLine("SORTEANDO...");
Thread.Sleep(2000);

int r = ger.Next(i, f + 1);

Console.SetCursorPosition(0, 5);
Console.WriteLine($"Entre {i} e {f} sorteei o valor {r}");

Console.ReadKey();