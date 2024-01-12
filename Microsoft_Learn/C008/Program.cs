// Sort, Search, and Index Lists

var names = new List<string> { "Ana", "Lala", "Tony", "Aline" };

foreach (var name in names)
{
    Console.WriteLine(name);
}

var index = names.IndexOf("Ana");

if (index == -1)
{
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else
{
    Console.WriteLine($"The name {names[index]} was found at {index}");
}
Console.WriteLine("---------------------------------");

// para ordenar em ordem alfabética:

names.Sort();
foreach (var name2 in names)
{
    Console.WriteLine($"Hello {name2.ToUpper()}!");
}
