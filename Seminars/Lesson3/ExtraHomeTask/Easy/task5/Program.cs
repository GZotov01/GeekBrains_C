Console.Write("Введите натуральное число:\t");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = i + 1;
}

int sum = 0;
int count = 0;

foreach (int e in arr)
{
    if (n % e == 0)
    {
        sum += e;
        count += 1;
    }
}
Console.WriteLine($"Кол-во делителей: {count}\nСумма делителей: {sum}");
