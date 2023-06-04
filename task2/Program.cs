//  Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
Console.Clear();
Random rnd = new Random();
Main();
void Main()
{
    Console.WriteLine("Введите значение элемента через пробел:...");
    int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    int[,] res = GetArray(5, 5, 0, 20);
    PrintArray(res);
    PrintResult(arr, res);
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
void PrintArray(int[,] array)
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
Boolean DoesTheElementin(int[] array, int[,] arrayx2)
{
    if (array[0] > arrayx2.GetLength(0) - 1 || array[1] > arrayx2.GetLength(1) - 1)
    {
        return false;
    }
    else return true;
}
void PrintResult(int[] array, int[,] arrayx2)
{
    if (DoesTheElementin(array, arrayx2) == true)
    {
        Console.WriteLine(arrayx2[array[0], array[1]]);
    }
    else Console.WriteLine("Данного элемента в массиве нет.");
}