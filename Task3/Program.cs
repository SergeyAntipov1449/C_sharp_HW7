// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void ArMeanCol(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        double result = Math.Round((sum / matrix.GetLength(0)), 2);
        System.Console.WriteLine($"Стреднее арифметическое элементов столбца {j + 1} равно {result}");
    }

}

int[,] FillMatrix(int row, int col, int rightRange, int leftRange)
{
    var rand = new Random();
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(rightRange, leftRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[] ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////

int[] size = ReadInt("Введите количество строк и столбцов через запятую:");
int[] range = ReadInt("Введите границы диапозона значений через запятую:");

int[,] matrix = FillMatrix(size[0], size[1], range[0], range[1]);
System.Console.WriteLine();
PrintMatrix(matrix);
System.Console.WriteLine();
ArMeanCol(matrix);
