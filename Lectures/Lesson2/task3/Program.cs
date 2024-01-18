int[] arr = new int[10] { 1, 2, 1, 7, 1, 35, 1, 3, 1, 5 };

int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    else
    {
        if (count == (arr.Length - 1))
        {
            Console.WriteLine("Четных чисел нет!");
        }
        count += 1;
    }
    
}