Console.Write("Enter ammount of numbers: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];
int i = 0;
while (i < n)
{
    arr[i] = i + 1;
    Console.Write($"{arr[i]} ");
    i++;
}