// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);//[1; 10)
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] FindMinIndex(int[,] arrayA)
{
    int[] index = new int[2];
    int min = arrayA[0, 0];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayA.GetLength(1); j++)
        {
            if (min > arrayA[i, j])
            {
                min = arrayA[i, j];
                index[0] = i;
                index[1] = j;
            }
        }
    }
    return index;
}

int[,] DelPozitionMinElement(int[,] arrayA, int[] pozitionmin)
{
    int[,] delarrayindex = new int[arrayA.GetLength(0) - 1, arrayA.GetLength(1) - 1];
    for (int i = 0; i < arrayA.GetLength(0) - 1; i++)
    {
        if (i < pozitionmin[0])
            for (int j = 0; j < arrayA.GetLength(1) - 1; j++)
            {
                if (j < pozitionmin[1])
                    delarrayindex[i, j] = arrayA[i, j];
                else
                    delarrayindex[i, j] = arrayA[i, j + 1];
            }
        else
            for (int j = 0; j < arrayA.GetLength(1) - 1; j++)
                if (j < pozitionmin[1])
                    delarrayindex[i, j] = arrayA[i + 1, j];
                else
                    delarrayindex[i, j] = arrayA[i + 1, j + 1];
    }
    return delarrayindex;
}

Console.Write("Введите количество строк: ");    
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");    
int n = int.Parse(Console.ReadLine() ?? "0");
int [,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine("Массив после удаления строки и столбца содержащих минимальный элемент:");
int[] minPosition = FindMinIndex(array);
PrintArray (DelPozitionMinElement(array, minPosition));