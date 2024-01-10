// Numbers and Integer Math
// class OK (operadores e ordem de precedência)

// Integer Precision

int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

Console.WriteLine("----------------------");

// limits of integer number

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 23431234;
Console.WriteLine($"An example of overflow: {what}");
// overflowed the number
Console.WriteLine("----------------------");

// Numbers and Decimals
// diference precision - double vs decimal:

double ad = 1.0;
double bd = 3.0;
Console.WriteLine(ad / bd);

decimal aDec = 1.0M;
decimal bDec = 3.0M;
Console.WriteLine(aDec / bDec);

Console.WriteLine("----------------------");

//area of the circle:

double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine(area);
