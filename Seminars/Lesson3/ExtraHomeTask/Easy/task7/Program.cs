Console.Write("Введите натуральное число > 2:\t");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 2)
{
    Console.WriteLine("Введенное число < 2");
}
else
{
    int[] numbers = new int[n];

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = i + 1;
    }

    double g, sumG = 1;

    foreach (int e in numbers)
    {
        sumG *= e;
    }
    g = Math.Pow(sumG, 1.0 / n);

    double[] squareNumbers = new double[n];

    for (int i = 0; i < squareNumbers.Length; i++)
    {
        squareNumbers[i] = Math.Pow(i, 2);
    }

    double sum = 0;

    for (int i = 0; i < squareNumbers.Length; i++)
    {
        if (squareNumbers[i] > g)
        {
            sum += squareNumbers[i];
            Console.Write($"{sum} ");
        }
    }
}

