//Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

Console.Write("Введите количество строк: ");


int n = int.Parse(Console.ReadLine() ?? "");


for (int y = 0; y < n; y++)
{
    int c = 1;
    for (int q = 0; q < n - y; q++)
    {
        Console.Write("   ");
    }

        for (int x = 0; x <= y; x++)
            {
                Console.Write("  {0}  ", c);
                c = c * (y - x) / (x + 1);

            }
    Console.WriteLine();
    Console.WriteLine();
}
Console.WriteLine();
