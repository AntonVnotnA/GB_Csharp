using static System.Console;
Clear();
WriteLine("Start");
WriteLine();

void FillArray(int[] collection) //метод который заполняет массив случайными числами. void - никаких значений не возвращает
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); //Положить в collection на позицию index случайное число из диапазона 1-10
        index++;
    }
}

void PrintArray(int[] col) // метод, который печатает массив. void - никаких значений не возвращает
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        WriteLine($"In position {position} there is the number {col[position]}");
        position++;
    }
}

int IndexOf(int[] collection, int find) //метод который ищет позицию заданного числа в массиве
{
    int count = collection.Length;
    int index = 0;
    int position = 0; //если поставить значение -1, то в случае есл элемента нет в массиве, на экране будет значение -1
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
    index++;
    }
    return position;
}

int [] array = new int[10]; // объявили переменную. создать массив и положить в него 10 элемнтов
FillArray(array);
PrintArray(array);
WriteLine();

int pos = IndexOf(array, 4);
WriteLine($"The position of number 4 is {pos}");

WriteLine();
WriteLine("Finish");

