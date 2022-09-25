// двы стрелка стреляют по банкам идя на встречу друг другу. в какой-то момент попадают в одну банку. каждый знает сколько он сбил. вычислить сколько он не поразил

using static System.Console;
Clear();

Write("Общее количество сбитых банок первого стрелка = ");
int shooterone = Convert.ToInt32(ReadLine()!);
Write("Общее количество сбитых банок второго стрелка = ");
int shootertwo = Convert.ToInt32(ReadLine()!);

WriteLine($"Первый не сбил {shootertwo-1}");
WriteLine($"Второй не сбил {shooterone-1}");
