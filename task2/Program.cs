// 
void FillMas (int[,]array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintMas(int [,] array)
{for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}


    
Console.Write("Введите количество строк: ");    
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");    
int n = int.Parse(Console.ReadLine() ?? "0");
int [,] array = new int[m, n];
int [,] array2 = new int[m,n];



FillMas(array);
PrintMas(array);
Console.WriteLine();
FillMas(array2);
PrintMas(array2);
Console.WriteLine();


Console.WriteLine("Произведение двух матриц");
Console.WriteLine();
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array3.GetLength(1); j++)
    {
        array3[i, j] = array[i, j] * array2[i, j];
    }
}

PrintMas(array3);