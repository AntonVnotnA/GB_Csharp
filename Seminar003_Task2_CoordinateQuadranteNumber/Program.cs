// по координате выдает номер четверти если X!=0 и Y!=0

using static System.Console;
Clear();

WriteLine("Indicate X coordinate : ");
int x = int.Parse(ReadLine()!);
WriteLine("Indicate Y coordinate : ");
int y = int.Parse(ReadLine()!);

if(x == 0 || y == 0) // логическое ИЛИ
{
    WriteLine("Error!");
    return;
}
if(x>0 && y>0) // логическое И
{
    WriteLine($"x ={x}, y = {y} - I quater");
}
if(x<0 && y>0) // логическое И
{
    WriteLine($"x ={x}, y = {y} - II quater");
}
if(x<0 && y<0) // логическое И
{
    WriteLine($"x ={x}, y = {y} - III quater");
}
if(x>0 && y<0) // логическое И
{
    WriteLine($"x ={x}, y = {y} - IV quater");
}