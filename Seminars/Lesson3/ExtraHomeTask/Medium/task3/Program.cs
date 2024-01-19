Console.Write("Введите натуральное число:\t");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = i + 1;
}

int firstDigit, secondDigit;
foreach (int e in arr)
{
    firstDigit = e / 100;
    secondDigit = e / 10;
    if (firstDigit != 0 && secondDigit != 0)
    {
        Console.Write($"{e} ");
    }
}