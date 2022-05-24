/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.*/

int rows = 4;
int columns = 5;
int[,] array = new int [rows, columns];

FillArray(rows, columns, array);
PrintArray(rows, columns, array);

int sum = 0;
int minSum = 0;
int minIndex = 0;

int MinSum(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
         if (i == 0) 
            {
                sum += array[i, j];
                minSum += array[i, j]; 
            }
            else sum += array[i, j]; 
        }
        if (sum < minSum)
        {
            minSum = sum;
            minIndex = i;
        }
        sum = 0;
    }
    return minIndex;
}
Console.WriteLine();
Console.WriteLine("Индекс строки с наименьшей суммой элементов: " + MinSum(array));

void FillArray(int rows, int columns, int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0,10);
        }
    }
}

void PrintArray(int rows, int columns, int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(); 
    }
}

