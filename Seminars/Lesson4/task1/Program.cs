int[] CreateArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(0, 100);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}
bool IsSimple(int n)
{
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}
int GetPrimeQuantity(int[] array)
{
    int countPrimes = 0;

    foreach (int e in array)
    {
        if (IsSimple(e) == true)
        {
            countPrimes += 1;
        }
    }
    return countPrimes;
}

Console.Write("size: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(n);
int result = GetPrimeQuantity(arr);
Console.WriteLine($"\n{result}");