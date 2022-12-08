// Программа, принимающая значение элемента в двумерном массиве 
// и возвращающая позицию этого элемента или указание, что его нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
bool IsIncorrectInput(int number)
{
    return number < 1;
}
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int CountElementX(int[,] matrix, int x)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == x) count++;
        }
    }
    return count;
}
int[,] FindPosition(int[,] matrix, int x)
{
    int[,] position = new int[CountElementX(matrix, x), 2];
    int m = 0;
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == x)
            {
                position[m, n] = i;
                n++;
                position[m, n] = j;
                m++;
                n -= 1;
            }
        }
    }
    return position;
}
void PrintPosition(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j]);
            if (j != matrix.GetLength(1) - 1) Console.Write(",");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
Console.WriteLine("Программа определения наличия элемента с запрашиваемым значением в двумерном массиве");
Console.WriteLine("(программа возвращает позицию этого элемента).");
Console.WriteLine();
Console.WriteLine("Задайте размер массива.");
InputM:
Console.Write("Введите значение размерности m (число строк): ");
int m = int.Parse(Console.ReadLine()!);
if (IsIncorrectInput(m))
{
    Console.WriteLine();
    Console.WriteLine("Неверный ввод");
    Console.WriteLine();
    goto InputM;
}
InputN:
Console.Write("Введите значение размерности n (число столбцов): ");
int n = int.Parse(Console.ReadLine()!);
if (IsIncorrectInput(n))
{
    Console.WriteLine();
    Console.WriteLine("Неверный ввод");
    Console.WriteLine();
    goto InputN;
}
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine();
Console.WriteLine("Двумерный массив:");
PrintArray(matrix);
Console.WriteLine();
Console.Write("Введите значение искомого элемента массива: ");
int x = int.Parse(Console.ReadLine()!);
int[,] position = FindPosition(matrix, x);
Console.WriteLine();
if (CountElementX(matrix, x) == 0)
{
    Console.WriteLine("Такого числа в массиве нет.");
}
else
{
    Console.WriteLine("Позиция искомого элемента в массиве:");
    PrintPosition(position);
}
Console.WriteLine();