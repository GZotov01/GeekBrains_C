Console.Write("Введите натуральное число:\t");
int n = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[n];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Math.Sqrt(i + 1);
}

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 5 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
}