Console.Write("Введите натуральное число:\t");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = i + 1;
}

for (int i = 0; i < arr.Length; i++)
{
    if (n % arr[i] == 0)
    {
        Console.Write($"{arr[i]} ");
    }
}