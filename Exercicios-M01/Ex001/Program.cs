// Exercício 1:

Console.SetCursorPosition(30, 10);
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.White;
Thread.Sleep(1000);
Console.Write(" MEU ");
Console.ResetColor();

Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Green;
Thread.Sleep(1000);
Console.Write(" BRASIL ");
Console.ResetColor();

Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Yellow;
Thread.Sleep(1000);
Console.WriteLine(" BRASILEIRO ");
Console.ResetColor();

Console.ReadKey();