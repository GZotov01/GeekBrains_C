int[] arr = new int[5] { 10, 2, 3, 4, 8 };

int max = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
}
Console.WriteLine($"Наибольшее значение: {max}");