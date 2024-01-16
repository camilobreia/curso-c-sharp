// Lists of Other Types

var fibonacciNumbers = new List<int> { 1, 1 };

var p = fibonacciNumbers[fibonacciNumbers.Count - 1];
var p2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

fibonacciNumbers.Add(p + p2);

foreach (var item in fibonacciNumbers)
{
    Console.WriteLine(item);
}