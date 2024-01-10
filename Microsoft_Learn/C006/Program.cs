// Combining Branches and Loops

int div3 = 0;

for (int count = 1; count <= 20; count++)
{
    if (count % 3 == 0)
    {
        div3 = div3 + count;
    }
}

Console.WriteLine($"The sum is: {div3}");
