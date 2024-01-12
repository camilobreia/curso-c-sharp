// Arrays, List, and Collections - cont.

// Adicionando e Removendo conteúdo na lista criada:

var names = new List<string> { "<name>", "Ana", "Felipe" };

names.Add("Ana Luísa");
names.Add("Bill");
names.Remove("<name>");

foreach (var name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

Console.WriteLine($"The list has {names.Count} people in it");