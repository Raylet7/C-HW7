// Программа, сортирующая элементы матрицы из целых чисел
//по возрастанию слева направо и сверху вниз
// (количество строк и столбцов задается с клавиатуры). 
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10
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
int[,] SelectionSort(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[k, l] < matrix[i, j])
                    {
                        int temporary = matrix[k, l];
                        matrix[k, l] = matrix[i, j];
                        matrix[i, j] = temporary;
                    }
                }
            }
        }
    }
    return matrix;
}
Console.WriteLine();
Console.WriteLine("Программа создания матрицы сортировкой элементов исходной матрицы из целых чисел.");
Console.WriteLine("Сортировка осуществляется по возрастанию слева направо и сверху вниз.");
Console.WriteLine("(Количество строк и столбцов задается с клавиатуры.)");
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
Console.WriteLine("Исходная матрица:");
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Новая матрица:");
int[,] newMatrix = SelectionSort(matrix);
PrintMatrix(newMatrix);
Console.WriteLine();