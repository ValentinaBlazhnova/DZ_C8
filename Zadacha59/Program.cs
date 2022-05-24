/* Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на 
пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7*/


int rows = Input("Введите количество строк в массиве: ");
int columns = Input("Введите количество столбцов в массиве: ");
int[,] array = new int[rows, columns];

FillArray(rows, columns, array);
PrintArray(rows, columns, array);

int minNumber = array[0, 0]; //Минимальные значения
int minRows = 0;
int minColumns = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (array[i, j] <= minNumber)
        {
            minNumber = array[i, j];
            minRows = i;
            minColumns =j;
        }
    }
}
Console.WriteLine("Наименьший элемент: " + minNumber);

for (int i = 0; i < rows; i++) // Преобразованный массив
{
    for (int j = 0; j < columns; j++)
    {
        {
            if ((i == minRows) || (j == minColumns))
                continue;
            else
                Console.Write(array[i, j] + " ");
        }
    }
    Console.WriteLine();
}
 

int Input (string output)
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
            array[i, j] = new Random().Next(0,100);
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
