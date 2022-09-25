// 3 человека делают кораблики. 1 в два раза быстрее двухх других

using static System.Console;
Clear();

Write("Сколько всего кораблей = ");
int ship = Convert.ToInt32(ReadLine()!);

if (ship%6 != 0)
{
    WriteLine("неверное значение");
    return;
}

WriteLine($"Девочка сделала {ship/3 * 2}, а мальчики сделали {ship/3}");