// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
// и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

int x = 1;
int y = 0;

if (x > 0 && y > 0)
{
    Console.WriteLine("I четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("III четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("IV четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("II четверть");
}
else
{
    Console.WriteLine("Координата x, y должна быть ненулевая");
}