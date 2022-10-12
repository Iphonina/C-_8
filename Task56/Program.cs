// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой 
// элементов: 1 строка
int row = 3;
int column = 4;
int[,] matrix = new int[row, column];

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int J = 0; J < matr.GetLength(1); J++)
        {
            matr[i, J] = new Random().Next(1, 5);
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int J = 0; J < matr.GetLength(1); J++)
        {
            Console.Write($"{matr[i, J]} ");
        }
        Console.WriteLine();
    }
}
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

void SumLines(int[,] arr)
{
    int sumFirstLine = 0;
    for (int k = 0; k < arr.GetLength(1); k++)
    {
        sumFirstLine += arr[0, k];
    }
    int sumMin = sumFirstLine;
    int indexMin = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sumOfLine = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumOfLine += arr[i, j];
            if (sumOfLine < sumMin)
            {
                sumMin = sumOfLine;
                indexMin = i;
            }
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов {indexMin + 1}");
}
SumLines(matrix);

