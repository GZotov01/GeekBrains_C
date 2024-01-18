// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
int number = 96;
int n1, n2;

if (number >= 10 && number <= 99)
{
    n1 = number / 10;
    n2 = number % 10;

    if (n1 > n2)
    {
        Console.WriteLine(n1);
    }
    else
    {
        Console.WriteLine(n2);
    }
}
else
{
    Console.WriteLine("Out of range");
}