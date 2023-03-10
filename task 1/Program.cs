// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая упорядочивает 
// по убыванию элементы каждой строки двумерного массива.

int InputSize(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] ArrayCreationAndFill(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void ArrayPrint(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void SelectionSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            int maxValue = j;
            for (int k = j+1; k < array.GetLength(1); k++)
            {
                if(array[i, k] > array[i, maxValue])
                {
                    maxValue = k;
                }
            }
        (array[i, maxValue], array[i, j]) = (array[i, j], array[i, maxValue]);
        }
    }
}

int rows = InputSize("Input number of rows");
int columns = InputSize("Input number of columns");
int[,] array = ArrayCreationAndFill(rows, columns);
ArrayPrint(array);
SelectionSort(array);
ArrayPrint(array);