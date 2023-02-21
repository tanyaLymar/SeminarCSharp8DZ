/* Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно 
на экран выводя индексы соответствующего элемента*/


int[,,] matrix =
{
    {
        {30,20,25},
        {40,55,25}

    },

    {
        {36,14,18 },
        {22,33,45}

    }

};

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            Console.Write($"[" + i + "," + j + "," + k + "] -");
            Console.Write($" {matrix[i, j, k]} ");

            Console.WriteLine();

        }

    }

    Console.WriteLine();
}
