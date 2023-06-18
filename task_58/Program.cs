Console.Clear();


int[,] RandomMass(int m, int n)
{
    // //[1,0,1,1,0,1,0,0]
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(10);
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

int[,] MatrixProduct(int[,] array_1, int[,] array_2)
{
    int[,] result = new int[array_1.GetLength(0), array_1.GetLength(1)];
    for (int i = 0; i < array_1.GetLength(0); i++)
    {

        for (int j = 0; j < array_1.GetLength(1); j++)
        {
            int temp = 0;
            for (int k = 0; k < array_1.GetLength(1); k++)
            {
                temp = temp + array_1[i, k] * array_2[k, j];
            }
            result[i, j] = temp;
        }

    }
    return result;

}

int[,] array_1 = RandomMass(2, 2);
int[,] array_2 = RandomMass(2, 2);
PrintMass(array_1);
Console.WriteLine();
PrintMass(array_2);
Console.WriteLine("Результирующий массив:");
PrintMass(MatrixProduct(array_1, array_2));
