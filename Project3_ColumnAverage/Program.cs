// Программа, задающая двумерный массив из целых чисел и
// определяющая среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
bool IsIncorrectInput(int number)
{
    return number < 1;
}
void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintMatrix(int[,] matrix)
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
double[] GetColumnAverage(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    int position = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
            array[position] = Math.Round(sum / matrix.GetLength(0), 1);
        }
        position++;
    }
    return array;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1) Console.Write("; ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Программа определения среднего арифметического элементов каждого столбца матрицы.");
Console.WriteLine("(матрица генерируется из целых чисел).");
Console.WriteLine();
Console.WriteLine("Задайте размер матрицы.");
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
FillMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Матрица:");
PrintMatrix(matrix);
Console.WriteLine();
double[] array = GetColumnAverage(matrix);
Console.WriteLine("Среднее арифметическое каждого столбца матрицы:");
PrintArray(array);
Console.WriteLine();