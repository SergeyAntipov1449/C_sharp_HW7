// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void ShowValue(int[,] matrix, int rowIndex, int colIndex)
{
    if (rowIndex >= matrix.GetLength(0) || colIndex >= matrix.GetLength(1))
    {
        System.Console.WriteLine("Элемента с такими индексами не существует");
    }
    else
    {
        System.Console.WriteLine($"Значение элемента с индексами [{rowIndex}|{colIndex}] = {matrix[rowIndex, colIndex]}");
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



int[] size = ReadInt("Введите количество строк и столбцов через запятую:");
int[] range = ReadInt("Введите границы диапозона значений через запятую:");
int[] index = ReadInt("Введите значение строки и столбца элемента через запятую:");
int[,] matrix = FillMatrix(size[0], size[1], range[0], range[1]);
System.Console.WriteLine();
PrintMatrix(matrix);
System.Console.WriteLine();
ShowValue(matrix, index[0], index[1]);