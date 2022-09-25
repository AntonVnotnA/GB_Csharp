using static System.Console;
Clear();

for (int i = 2; i < 10 ; i++)
{
    for (int j = 2; j < 10; j++)
    {
        WriteLine($"{i} x {j} = {i*j}");
    }
    WriteLine();
}
