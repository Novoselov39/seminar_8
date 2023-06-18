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

int[,] SortRow(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int n = array.GetLength(1);
        for (int k = 0; k < n; k++)
        {
            for (int j = 0; j < n - 1 - k; j++)
            {
                if (array[i, j] > array[i, j + 1])
                {
                    int m = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = m;
                }
            }
        }
    }
    return array;
}

int[,] array = RandomMass(4, 3);
PrintMass(array);
SortRow(array);
Console.WriteLine();
PrintMass(array);