// What are Loops?

int counter = 0;
while (counter < 10) //if put "true" will be a infinite loop
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
}

Console.WriteLine("------------------------------------");

int counter2 = 0;
do
{
    Console.WriteLine($"Hello World! The counter is {counter2}");
    counter2++;
} while (counter2 < 10);

Console.WriteLine("------------------------------------");

for (int counter3 = 0; counter3 < 10; counter3++)
{
    Console.WriteLine($"Hello World! The counter is {counter3}");
}

Console.WriteLine("------------------------------------");


for (int row = 1; row < 11; row++)
{
    Console.WriteLine($"The row is {row}");
}

Console.WriteLine("------------------");

for (char column = 'a'; column < 'k'; column++)
{
    Console.WriteLine($"The column is {column}");
}

Console.WriteLine("-----------------------");

for (int row2 = 1; row2 < 11; row2++)
{
    for (char column2 = 'a'; column2 < 'k'; column2++)
    {
        Console.WriteLine($"The cell is ({row2}, {column2})");
    }
}