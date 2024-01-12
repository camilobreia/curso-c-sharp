// Arrays, List, and Collections

using System.Xml.Linq;

var names = new List<string> { "<name>", "Ana", "Felipe" };
// List<string> names = new List<string> { "<name>", "Ana", "Felipe" }; => podemos declarar a lista assim também, mas o mais comum é do primeiro modo

foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine("----------------------");

// foreach significa "para cada um desses nomes"

// o mesmo código mas de outro jeito:

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"Hello {names[i].ToUpper()}!");

}