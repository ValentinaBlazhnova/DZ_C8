/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/

int rows = Input("Введите количество строк в матрице: ");
int columns = Input("Введите количество столбцов в матрице: ");
int[,] matrix1 = new int[rows, columns];
int[,] matrix2 = new int[rows, columns];

FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();

FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine("Произведение двух матриц равно: ");

int[,] outputMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

ProductMatrix(matrix1, matrix2, outputMatrix);
PrintArray(outputMatrix);

int[,] ProductMatrix(int[,] matrix1, int[,] matrix2, int[,] outputMatrix)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    { 
       return matrix1;
    }
    
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int k =0; k < matrix1.GetLength(1); k++)
            {
                outputMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return outputMatrix;
}

int Input (string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(0,10);
        }
    }
}

void PrintArray(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write(matrix1[i, j] + " ");
        }
        Console.WriteLine(); 
    }
}
