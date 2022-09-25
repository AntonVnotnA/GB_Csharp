Console.Clear();

int xa = 50, ya = 1,
    xb = 1, yb = 20,
    xc = 100, yc = 20;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = yb;

int count = 0;

while(count < 10000)
{
    int randomnumber = new Random().Next(0, 3); // 0 1 2

    if (randomnumber == 0)
    {
        x = (x +  xa) / 2;
        y = (y + ya) / 2;
    }

        if (randomnumber == 1)
    {
        x = (x +  xb) / 2;
        y = (y + yb) / 2;
    }

        if (randomnumber == 2)
    {
        x = (x +  xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1; // count +=1 OR count++
}
