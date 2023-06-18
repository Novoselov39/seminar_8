Console.Clear();


int[,] GetArray(int size)
{
    // //[1,0,1,1,0,1,0,0]
    int[,] array = new int[size, size];
    for (int count = 0; count<=size/2;count++)
    {
        GoRight(array,0+count,0+count,size-1-count);
        GoFloor(array,size-1-count,1+count,size-1-count);
        GoLeft(array,size-1-count,0+count,size-2-count);
        GoTop(array,0+count,1+count,size-2-count);
    }
    return array;
}


int[,] GoRight(int[,] array, int i, int minJ, int maxJ)
{
    int num=0;
    if (i==0) num=1;
    else num = array[i,minJ-1]+1;
    for (int j=minJ; j<=maxJ;j++)
    {
        array[i,j]=num;
        num++;
    }
    return array;
}

int[,] GoFloor(int[,] array, int j, int minI, int maxI)
{
    
    int num = array[minI-1,j]+1;
    for (int i=minI; i<=maxI;i++)
    {
        array[i,j]=num;
        num++;
    }
    return array;
}

int[,] GoLeft(int[,] array, int i, int minJ, int maxJ)
{
    
    int num = array[i,maxJ+1]+1;
    for (int j=maxJ; j>=minJ;j--)
    {
        array[i,j]=num;
        num++;
    }
    return array;
}

int[,] GoTop(int[,] array, int j, int minI, int maxI)
{
    
    int num = array[maxI+1,j]+1;
    for (int i=maxI; i>=minI;i--)
    {
        array[i,j]=num;
        num++;
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


Console.Write($"Введите размер матрицы: ");
int s = int.Parse(Console.ReadLine());
PrintMass(GetArray(s));
Console.WriteLine();

