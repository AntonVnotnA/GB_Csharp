using static System.Console;
Clear();
WriteLine("Let's get started!");

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 4};
int n = array.Length;
int find = 4;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        WriteLine($"There is such number {find} with index {index} in the array");
        break;
    }
    index++;
}
// else
// {
//     WriteLine($"There is NO such number {find} in the array");
//     break;
// }