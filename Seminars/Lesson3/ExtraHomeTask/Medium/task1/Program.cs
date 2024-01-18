Console.Write("Введите натуральное число M:\t");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число N:\t");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr;

if (m >= n)
{
    arr = new int[m];
}
else
{
    arr = new int[n];
}

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = i + 1;
}


for (int i = 0; i < arr.Length; i++)
{
    if (m % arr[i] == 0 && n % arr[i] == 0)
    {
        Console.Write($"{arr[i]} ");
    }
}