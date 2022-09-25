using static System.Console; //вместо например Console.WriteLine достаточно написать WrilteLine
WriteLine("Please indicate numbers a and b : ");
int a = Convert.ToInt32(ReadLine()); //Convert.ToInt32 строку преобразовать в число и поместить в переменную
int b = Convert.ToInt32(ReadLine()); //Convert.ToInt32 строку преобразовать в число и поместить в переменную
int sqr = b * b;
if (a == sqr)
{
    WriteLine("yes");
}
else
{
    WriteLine("no");
}