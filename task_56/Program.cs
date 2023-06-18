Console.Clear();


int[,] RandomMass(int m, int n)
{
    // //[1,0,1,1,0,1,0,0]
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(100);
        }
    }
    return array;
}
void PrintMass(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MinSumRow(int[,] array)
{
    int summax = 0;
    int rowmax = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (summax < sum)
        {
            summax = sum;
            rowmax = i + 1;
        }

    }
    Console.WriteLine($"Минимальная сумма: {summax}");
    Console.WriteLine($"Строка с минимальной суммой: {rowmax}");

}

int[,] array = RandomMass(4, 3);
PrintMass(array);

Console.WriteLine();

MinSumRow(array);