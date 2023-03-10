// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку
//  с наименьшей суммой элементов.


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

int[] ArrayWithSums(int[,] array)
{
    int[] newArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        newArray[i] = sum;
    }
    return newArray;
}

int MinRow(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}

int rows = InputSize("Input number of rows");
int columns = InputSize("Input number of columns");
int[,] array = ArrayCreationAndFill(rows, columns);
ArrayPrint(array);
int[] arrayForMin = ArrayWithSums(array);
int minRow = MinRow(arrayForMin)+1;
System.Console.WriteLine($"Row with minimum sum of elements is number {minRow}");