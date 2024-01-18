Console.Write("Введите натуральное число:\t");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = i + 1;
}

foreach (int e in arr)
{
    sum += e;
}
Console.WriteLine(sum);
