// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
Console.Clear();
Random rnd = new Random();
Main();
void Main()
{
    Console.WriteLine("Введите размерность(строки столбцы) массива через пробел:...");
    int [] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    int [,] res = GetArray(arr[0],arr[1],0,10);
    PrintArray(res);
    double[] result = FindTheMidle(res);
}
int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] back = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            back[i, j] = rnd.Next(minValue, maxValue);
        }
    }
    return back;
}
double[] FindTheMidle(int [,] array)
{
    double [] back = new double[array.GetLength(1)];
    for(int i = 0; i< array.GetLength(0); i ++)
    {
        for(int j = 0; j< array.GetLength(1);j++)
        {
            back[j] +=array[i,j];
        }
    }
    for(int i = 0; i<back.Length; i++)
    {
        back[i] /= array.GetLength(0);
        Console.Write($"{back[i]} |");
    }
    return back;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} |");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.Write("|");
}
