// по заданному номеру координатной четверти, вывести возможный диапазон координатных точек в этой четверти

using static System.Console;
Clear();

WriteLine("Indicate number of the : ");
int number = int.Parse(ReadLine()!);

// if(number<1 ||number>4) //  || - &&, | - &
// {
//     WriteLine("Error!");
//     return;
// }
// if(number==1)
// {
//     WriteLine("X>0, Y>0");
// }
// if(number==2)
// {
//     WriteLine("X>0, Y>0");
// }
// if(number==3)
// {
//     WriteLine("X<0, Y<0");
// }
// if(number==4)
// {
//     WriteLine("X>0, Y<0");
// }

switch(number) // оператор перебирающий значения (кейсы), можно использовать вместо if 
{
    case 1:
    {
        WriteLine("X>0, Y>0");
        break;
    }
    case 2:
    {
        WriteLine("X>0, Y>0");
        break;
    }
    case 3:
    {
        WriteLine("X<0, Y<0");
        break;
    }
    case 4:
    {
        WriteLine("X>0, Y<0");
        break;
    }
    default:
    {
        WriteLine("Error!");
        break;
    }
}