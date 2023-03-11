// Задача 4: * Напишите программу, 
// которая заполнит спирально квадратный массив. 


int InputSize(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

// часа 4 ушло, но работает)
int[,] ArrayCreationAndFill(int rows, int columns) 
{
    int counter = 0;
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = i; j < columns-i; j++)
        {
            array[i, j] = counter;
            if(counter == rows*columns-1) return array;
            counter += 1;
            if (j == columns - 1-i)
            {
                for (int k = 1+i; k < rows-i; k++)
                {
                    array[k, j] = counter;
                    if(counter == rows*columns-1) return array;
                    counter += 1;
                    if (k == rows - 1-i)
                    {
                        for (int l = columns - 2-i; l >= 0+i; l--)
                        {
                            array[k, l] = counter;
                            if(counter == rows*columns-1) return array;
                            counter += 1;
                            if (l == 0+i)
                            {
                                for (int m = rows - 2-i; m > 0+i; m--)
                                {
                                    array[m, l] = counter;
                                    if(counter == rows*columns-1) return array;
                                    counter += 1;
                                }
                            }
                        }
                    }
                }
            }
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
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int rows = InputSize("Input ammount of rows in array");
int columns = InputSize("Input ammount of columns in array");
int[,] array = ArrayCreationAndFill(rows, columns);
ArrayPrint(array);