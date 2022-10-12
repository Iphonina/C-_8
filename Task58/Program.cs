// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int row1 = new Random().Next(3, 5);
int col1 = new Random().Next(3, 5);
int row2 = new Random().Next(3, 5);
int col2 = new Random().Next(3, 5);

int[,] matrixA = new int[row1, col1];
int[,] matrixB = new int[row2, col2];

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

FillArray(matrixA);
Console.WriteLine();
PrintArray(matrixA);

FillArray(matrixB);
Console.WriteLine();
PrintArray(matrixB);
Console.WriteLine();

if (col1 == row2)
{
    int[,] MatrixMultiplication(int[,] A, int[,] B)
    {
        int[,] C = new int[A.GetLength(0), B.GetLength(1)];
        for (int i = 0; i < C.GetLength(0); i++)
        {
            for (int j = 0; j < C.GetLength(1); j++)
            {
                for (int k = 0; k < A.GetLength(1); k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }
        return C;
    }

    int[,] matrixC = MatrixMultiplication(matrixA, matrixB);

    void PrintNewMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrixC[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    PrintNewMatrix(matrixC);
}
else Console.WriteLine($"Умножение невозможно!");