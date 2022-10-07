using System;
using static System.Console;
namespace MyLibrary;
public class MyExample
{
    public static int[] GetArray(int size, int minValue, int maxValue)
    {
        int[] result = new int[size];
        Random rnd = new Random();
        for (int i = 0; i < size; i++)
        {
            result[i] = rnd.Next(minValue, maxValue + 1);
        }
        return result;
    }
}

