// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int[] ReadInt(string text)
{
    System.Console.Write(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);
}

double[,] FillMatrix(int m, int n, int leftRange, int rightRange)
{
    var rand = new Random();
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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


///////////////////////////////////////////////////////////////////////////////////////////////////////

int[] size = ReadInt("Введите количество строк и столбцов через запятую:");
int[] range = ReadInt("Введите левую и правую границы массива через запятую:");
double[,] matrix = FillMatrix(size[0], size[1], range[0], range[1]);
PrintMatrix(matrix);
