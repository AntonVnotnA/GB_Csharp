using static System.Console;
Clear();

//            0  1  2  3  4  5  6  7  8  9  10
int[] arr = { 3, 5, 8, 1, 3, 2, 7, 9, 8, 4, 6 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}

void SortArray(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++) 
    {
        int maxPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}

PrintArray(arr);
SortArray(arr);
PrintArray(arr);

// во вложенном цикле начинается сравнение со первого элемента {j=i+1}, т.к. нулевой элемент {i=0} уже назначен минимальным {i=0} , {minPosition = i} во внешнем цикле 
// во вложенном цикле идет перебор от {i+1} до {array;Length}
// от {0+1} перебрать {11} элементов, тода получислось бы что последний элемент д.б. 12-ым, а такого нет
// по этому во внешнем цикле искусственно вычитается единица {array.Length-1}
// от {0+1} до {11-1}, тогда получится что последний элемент 11-ый, что соответствует длине массива