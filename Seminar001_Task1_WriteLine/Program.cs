using static System.Console; //вместо например Console.WriteLine достаточно написать WrilteLine

Clear();
Write("Please indicate numbers num1 and num2 : ");
int num1 = Convert.ToInt32(ReadLine()); //Convert.ToInt32 строку преобразовать в число и поместить в переменную
int num2 = int.Parse(ReadLine()!); // int.Parse строку преобразовать в число и поместить в переменную 
int sqr1 = num1 * num1;
int sqr2 = Convert.ToInt32(Math.Pow(num2, 2)); // Math - метод Pow(num2,2) число num2 возвести в степень 2
WriteLine($"Квадрат числа  {num1} = {sqr1}"); // $ - параметрический вывод данных в строку, чтобы выводились значения переменных, а не {num1} и {sqr1}
WriteLine("Квадрат числа  {num2} = {sqr2}");