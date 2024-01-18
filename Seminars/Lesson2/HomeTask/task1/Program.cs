// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

int number = 322;

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}