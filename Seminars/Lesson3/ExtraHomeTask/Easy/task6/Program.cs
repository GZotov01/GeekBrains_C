Console.Write("Введите натуральное число > 5:\t");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 5)
{
    Console.WriteLine("Введенное число < 5");
}
else
{
    int[] arr = new int[n];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = i + 1;
    }

    double a, sumA = 0;

    foreach (int e in arr)
    {
        sumA += e;
    }
    a = sumA / arr.Length;

    double g, sumG = 1;

    foreach (int e in arr)
    {
        sumG *= e;
    }
    g = Math.Pow(sumG, 1.0 / n);

    Console.WriteLine(Math.Round(a / g, 2));
}

