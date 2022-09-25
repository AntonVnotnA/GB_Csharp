using static System.Console; //вместо например Console.WriteLine достаточно написать WrilteLine
Clear();
WriteLine("Please indicate number of a day : ");
int daynumber = Convert.ToInt32(ReadLine()); //Convert.ToInt32 строку преобразовать в число и поместить в переменную, ! - проверка на непустое значение

if (daynumber == 1)
{
    WriteLine("Monday");
}
if (daynumber == 2)
{
    WriteLine("Tuesday");
}
if (daynumber == 3)
{
    WriteLine("Wednesday");
}
if (daynumber == 4)
{
    WriteLine("Thursday");
}
if (daynumber == 5)
{
    WriteLine("Friday");
}
if (daynumber == 6)
{
    WriteLine("Suturday");
}
else if (daynumber == 7)
{
    WriteLine("Sunday");
}
else
{
    WriteLine("Incorrect day number");
}

// string day = "Incorrect day number";
// if (daynumber == 1) day = "Monday";
// if (daynumber == 2) day = "Tuesday";
// if (daynumber == 3) day = "Monday";
// if (daynumber == 4) day = "Monday";
// if (daynumber == 5) day = "Monday";
// if (daynumber == 6) day = "Monday";
// if (daynumber == 7) day = "Monday";
// WriteLine(day);