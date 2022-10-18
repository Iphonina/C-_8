// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива.

int row = new Random().Next(3, 5);
int column = new Random().Next(3, 5);

int[,] matrix = new int[row, column];

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int J = 0; J < matr.GetLength(1); J++)
        {
            matr[i, J] = new Random().Next(1, 10);
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


int min = matrix[0, 0];
int i_min = 0;
int j_min = 0;
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        if (matrix[i, j] < min)
        {
            min = matrix[i, j];
            i_min = i;
            j_min = j;
        }
    }
}
Console.WriteLine();
Console.WriteLine($"{min}[{i_min + 1}, {j_min + 1}]");

int rowResult = row - 1;
int columnResult = column - 1;
int[,] result = new int[rowResult, columnResult];
int bias_i = 0;
int bias_j = 0;
for (int i = 0; i < rowResult; i++)
{
    if(i == i_min) bias_i++;
    bias_j = 0;
    for (int j = 0; j < columnResult; j++)
    {
       if(j == j_min) bias_j++;
       result[i, j] = matrix[i + bias_i, j + bias_j];
    }
}
Console.WriteLine();
PrintArray(result);
