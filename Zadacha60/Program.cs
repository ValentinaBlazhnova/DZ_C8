/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
 которая будет построчно выводить массив, добавляя индексы каждого элемента.*/

int rows = Input("Введите количество строк в массиве: ");
int columns = Input("Введите количество столбцов в массиве: ");
int page = Input("Введите количество страниц в массиве: ");
int[, ,] array3D = new int[rows, columns, page];

FillArray(array3D);
PrintArray(array3D);

int Input (string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[, ,] array3D)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        { 
            for (int k = 0; k < page; k++)
            {
            array3D[i, j, k] = new Random().Next(10,100);
            int temp =  array3D[i, j, k];
            if (temp == array3D[i, j, k])
            continue;
            }
        }     
    }
}

void PrintArray(int[, ,] array3D)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < page; k++)
            {
                Console.Write($"{i}{j}{k} {array3D[i, j, k]}");
            }
            Console.WriteLine(); 
        }
    }
}