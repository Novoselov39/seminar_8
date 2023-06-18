Console.Clear();


int[,,] RandomMass(int m, int n, int k)
{
    // //[1,0,1,1,0,1,0,0]
    int[,,] array = new int[m, n, k];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int l=0;
            while(l<k)
            {
                int element=new Random().Next(10,100);
                if(FindElement(array,element)) continue;
                array[i, j, l] = element;
                l++;
            }           

        }
    }
    return array;
}
void PrintMass(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                Console.Write($" {array[j, l, i]} ({j}, {l}, {i})");
            }
            Console.WriteLine();
        }

    }
}

bool FindElement(int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if(array[i, j, k]==el) return true;
            }
        }
    }
    return false;
}


PrintMass(RandomMass(2, 2, 2));
Console.WriteLine();


