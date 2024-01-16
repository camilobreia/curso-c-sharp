// fibonacci

var fibonacciNumbers = new List<int> { 1, 1 };

while (fibonacciNumbers.Count < 20)
{
    var p = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var p2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(p + p2);

}

foreach (var item in fibonacciNumbers)
{
    Console.WriteLine(item);
}

Console.WriteLine("------------------------------------------");

/*var fibonacciNumbers2 = new List<int> { 1, 1 };

for (int i = 2; i < 20; i++)
{
    var previus = fibonacciNumbers2[fibonacciNumbers2.Count - 1];
    var previus2 = fibonacciNumbers2[fibonacciNumbers2.Count - 2];

    fibonacciNumbers2.Add(previus + previus2);

}

foreach (var item2 in fibonacciNumbers2)
{
    Console.WriteLine(item2);
}*/