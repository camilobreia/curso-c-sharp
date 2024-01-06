string prod1, prod2;
float prec1, prec2;


Console.Write("Produto 1: ");
prod1 = Console.ReadLine();
Console.Write("Preço 1: R$");
float.TryParse(Console.ReadLine(), out prec1);
Console.Write("Produto 2: ");
prod2 = Console.ReadLine();
Console.Write("Preço 2: R$");
float.TryParse(Console.ReadLine(), out prec2);

Console.SetCursorPosition(0, 7);
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Blue;

Console.WriteLine($"{" Produto", -20}{"Preço ", 13}");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.Gray;

Console.WriteLine($"{prod1, -20}{prec1, 13:C2}");

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.Gray;

Console.WriteLine($"{prod2, -20}{prec2, 13:C2}");

Console.ReadKey();