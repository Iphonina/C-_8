// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] matrix = new int[2, 2, 2];

void FillArray(int[,,] matr)
{
    int start = new Random().Next(10, 50);
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                matr[i, j, k] = start;
                start= start + 1;
            }
        }
    }
}

void PrintArray(int[,,] matr)
{
    for (int k = 0; k < matr.GetLength(2); k++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j, k]} ");
            }
            Console.WriteLine();
        }
    }
}
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

void ShowMatrix(int[,,] table)
{
for (int k = 0; k < 2; k++)
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"{table[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}
Console.WriteLine();
ShowMatrix(matrix);
