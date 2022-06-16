/*Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

void CreateArray(int[,] array, int range)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    const int startIndex = 49;
    for (var i = startIndex + 0; i < startIndex + arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{((char)i)}]\t");
    }
    Console.WriteLine();
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[" + (i + 1) + "]\t");

        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int MinSumLineElements(int[,] array, int i)
{
    int MinSum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        MinSum += array[i, j];
    }
    return MinSum;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

Console.Clear();
Console.WriteLine($"\nВведите размер прямоугольного массива m x m и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] array = new int[m, m];
CreateArray(array, range);
Print2DArray(array);

int minSumLine = 0;
int sumLine = MinSumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = MinSumLineElements(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine($"\n{minSumLine + 1}-я - строкa с наименьшей суммой элементов равной {sumLine}");
