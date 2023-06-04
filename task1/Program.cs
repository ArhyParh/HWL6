// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
Console.Clear();
Main();
void Main()
{
    double[,] array = GetArray(5, 5);
    PrintArray(array);

}
double[,] GetArray(int rows, int column)
{
    double[,] array = new double[rows, column];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} |");
        }
        Console.WriteLine();
    }
}
