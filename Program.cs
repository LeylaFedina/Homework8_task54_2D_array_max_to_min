/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.Clear();
int[,] generateTwodimensionalArray(int height, int width, int randomStart, int randomEnd)
{
    int[,] twodimensionalArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twodimensionalArray[i, j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return twodimensionalArray;
}

void print2DArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write((arrayToPrint[i, j]) + "\t");
        }
        Console.WriteLine();
    }
}

int[,] sortedArray(int[,] inputArray)
{
    int temp;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 1; j < inputArray.GetLength(1); j++)
        {
            if (inputArray[i, j - 1] < inputArray[i, j])
            {
                temp = inputArray[i, j - 1];
                inputArray[i, j - 1] = inputArray[i, j];
                inputArray[i, j] = temp;
                j = 0;
            }
        }
    }
    return inputArray;
}

int[,] generateArray = generateTwodimensionalArray(5, 5, 1, 9);
print2DArray(generateArray);
Console.WriteLine("__________________________________");
int[,] sortArray = sortedArray(generateArray);
print2DArray(sortArray);