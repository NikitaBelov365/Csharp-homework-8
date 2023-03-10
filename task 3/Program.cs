// Задача 3: Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.


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

int[,] MultipliedArray(int[,] array1, int[,] array2)
{
    int[,] multipliedArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                multipliedArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return multipliedArray;
}

int rows1 = InputSize("Input number of rows in 1st array");
int columns1 = InputSize("Input number of columns in 1st array");
int rows2 = InputSize("Input number of rows in 2nd array");
int columns2 = InputSize("Input number of columns in 2nd array");
int[,] array1 = ArrayCreationAndFill(rows1, columns1);
int[,] array2 = ArrayCreationAndFill(rows2, columns2);
ArrayPrint(array1);
ArrayPrint(array2);
int[,] multipliedArray = MultipliedArray(array1, array2);
ArrayPrint(multipliedArray);