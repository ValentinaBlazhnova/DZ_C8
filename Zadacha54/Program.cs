/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.*/

int rows = Input("Введите колличество строк в массиве: ");
int columns = Input("Введите колличество столбцов в массиве: ");
int[,] array = new int[rows, columns];

FillArray(rows, columns, array);
PrintArray(rows, columns, array);

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        for (int k = 0; k < columns; k++)
        {
            if (array[i, j] <= array[i, k]) continue;
            int temporary = array[i, j];
            array[i, j] = array[i, k];
            array[i, k] = temporary;
        }
    }
}

 Console.WriteLine();
 PrintArray(rows, columns, array);

int Input(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}

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

