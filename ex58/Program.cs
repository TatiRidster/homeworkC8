/* Задайте две матрицы. Напишите программу,
 которая будет находить произведение двух матриц.*/
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
void MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
Console.Clear();
Console.WriteLine("Умножить две матрицы можно только в том случае, если число столбцов");
Console.WriteLine("первой матрицы равняется числу строк второй матрицы");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int k = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел для матриц: от 1 до ");

int[,] firstMatrix = new int[m, n];
CreateArray(firstMatrix, range);
Console.WriteLine($"\nПервая матрица:");
Print2DArray(firstMatrix);

int[,] secondMatrix = new int[n, k];
CreateArray(secondMatrix,range);
Console.WriteLine($"\nВторая матрица:");
Print2DArray(secondMatrix);

int[,] resultMatrix = new int[m,k];

MultiplicationMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
Print2DArray(resultMatrix);