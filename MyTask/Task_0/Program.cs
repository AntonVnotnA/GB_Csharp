//

using MyLibrary;
using static System.Console;
Clear();

int[] array = MyExample.GetArray(9, 1, 9);
WriteLine(String.Join(",", array));