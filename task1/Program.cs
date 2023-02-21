// Составить частотный словарь элементов двумерного массива

void FillMas(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintMas(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}



Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] array = new int[m, n];
int sizeUnigueArray = 1;
int count = -1;
int[] uniqueArray = new int[sizeUnigueArray];
bool isZero = false;


FillMas(array);
PrintMas(array);
Console.WriteLine();


for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        int value = array[i, j];
        if (value == 0)
        {
            isZero = true;
            continue;
        }
        if (!IsValue(value))
        {
            AddUnigue(value);
        }
    }
}

void AddUnigue(int value)
{
    if (count == sizeUnigueArray - 2)
    {
        count++;
        uniqueArray[count] = value;
    }
    else
    {
        copyArray(value);
    }
}

bool IsValue(int value)
{
    foreach (int item in uniqueArray)
    {
        if (item == value)
        {
            return true;
        }
    }
    return false;
}


void PrintMas1D(int[] array)
{
    for (int j = 0; j < sizeUnigueArray; j++)
    {
        Console.Write($"{array[j]}  ");
    }
    Console.WriteLine();
}

void copyArray(int value)
{
    sizeUnigueArray++;
    int[] newUnique = new int[sizeUnigueArray];
    for (int i = 0; i < uniqueArray.Length; i++)
    {
        newUnique[i] = uniqueArray[i];
    }
    count++;
    newUnique[count] = value;
    uniqueArray = newUnique;
}

if (isZero)
{
    copyArray(0);
}

PrintMas1D(uniqueArray);

foreach (int item in uniqueArray)
{
    int countItem = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (item == array[i, j]) countItem++;
        }
    }
    Console.WriteLine(item + " встречается " + countItem + "раз");
}
