// Программа, позволяющая задать двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
void FillArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-100, 101) / 10.0;
        }
    }
}
void PrintArray(double[,] matrix)
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
Console.WriteLine();
Console.WriteLine("Программа создания двумерного массива случайных вещественных чисел");
Console.WriteLine("(размер массива вводится с клавиатуры).");
Console.WriteLine();
Console.Write("Введите значение размерности m (число строк): ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение размерности n (число столбцов): ");
int n = int.Parse(Console.ReadLine()!);
double[,] matrix = new double[m, n];
FillArray(matrix);
Console.WriteLine();
Console.WriteLine("Двумерный массив:");
PrintArray(matrix);
Console.WriteLine();