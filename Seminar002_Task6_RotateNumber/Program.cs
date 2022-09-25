// развернуть трехзначное число
// развернуть N-значное число


// using static System.Console;
// Clear();
// int number = new Random().Next(100, 999 + 1);
// WriteLine(number);
// int a0 = number % 10; // забрать младший разряд, дает остаток от деления на 10
// int a1 = (number / 10) % 10;
// int a2 = number / 100; // забрать старщий разряд, дает целочисленную часть от деления на 10
// WriteLine($"{a0}{a1}{a2}");



// using static System.Console;
// Clear();
// Write("Print a number : ");
// int number = int.Parse(ReadLine()!); //это метод в C #, который преобразует строковое представление в соответствующее числовое целочисленное значение
// string result = string.Empty; // создание пустой строки
// while(number > 0)
// {
//     result += number % 10; // result = result + number % 10
//     number /= 10; // number=number/10
// }
// int newnumber = int.Parse(result);
// WriteLine($"New rotated number is {newnumber}");


//РЕШЕНИЕ ЧЕРЕЗ СТРОКУ
// using static System.Console;
// Clear();
// Write("Print a number : ");
// string number = ReadLine();
// string result = string.Empty;
// int index = 0;
// while (index < number.Length)
// {
//     result = number[index] + result;
//     index++;
// }
// WriteLine($"New rotated number is {result}");
