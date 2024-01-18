Console.Write("Введите натуральное число:\t");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = i + 1;
}

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] * arr[i] == n)
    {
        Console.WriteLine($"Число '{n}' является квадратом числа '{arr[i]}'");
        break;
    }
    else if (i == arr.Length - 1)
    {
        Console.WriteLine($"Введеное число '{n}' не является квадратом натурального числа");
    }
}