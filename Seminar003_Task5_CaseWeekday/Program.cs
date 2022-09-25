// по заданному номеру дню недели вывести его название

using static System.Console;
Clear();

Write("Please print a week day number from 1 to 7 : ");
int daynumber = Convert.ToInt32(ReadLine()!);

switch(daynumber) // оператор перебирающий значения (кейсы), можно использовать вместо if 
{
    case 1:
    {
        WriteLine("Monday");
        break;
    }
    case 2:
    {
        WriteLine("Tuesday");
        break;
    }
    case 3:
    {
        WriteLine("Wednesday");
        break;
    }
    case 4:
    {
        WriteLine("Thursday");
        break;
    }
    case 5:
    {
        WriteLine("Friday");
        break;
    }
    case 6:
    {
        WriteLine("Saturday");
        break;
    }
    case 7:
    {
        WriteLine("Sunday");
        break;
    }
    default:
    {
        WriteLine("Error!");
        break;
    }
}